/*
 * File: PasswordHelper.cs
 * Author: Shade
 * Date: 06/23
 * Description: Provides utility methods for password management and encryption operations.
 */

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace PassWraith.Utilities
{

    /// <summary>
    /// Provides utility methods for password management and encryption operations.
    /// </summary>
    internal class PasswordHelper
    {

        /// <summary>
        /// Encrypts a password using BCrypt hashing algorithm.
        /// </summary>
        /// <param name="password">The password to be encrypted.</param>
        /// <returns>The hashed password.</returns>
        public static string EncryptPassword(string password)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
            return hashedPassword;
        }

        /// <summary>
        /// Verifies whether a password matches a hashed password using BCrypt hashing algorithm.
        /// </summary>
        /// <param name="password">The password to be verified.</param>
        /// <param name="hashedPassword">The hashed password to compare against.</param>
        /// <returns>True if the password matches the hashed password, otherwise false.</returns>
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            bool passwordMatches = BCrypt.Net.BCrypt.Verify(password, hashedPassword);
            return passwordMatches;
        }

        /// <summary>
        /// Derives a cryptographic key from a password and a secret key using the PBKDF2 algorithm.
        /// </summary>
        /// <param name="password">The password from which to derive the key.</param>
        /// <param name="secretKey">The secret key used in the key derivation process.</param>
        /// <returns>The derived key as a byte array.</returns>
        public static byte[] DeriveKeyFromPassword(string password, string secretKey)
        {
            const int iterations = 10000;
            const int keySize = 32;

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(secretKey), iterations))
            {
                byte[] keyBytes = pbkdf2.GetBytes(keySize);
                return keyBytes;
            }
        }

        /// <summary>
        /// Converts a string value to a secure string.
        /// </summary>
        /// <param name="value">The string value to convert.</param>
        /// <returns>A SecureString representation of the value.</returns>
        public static SecureString ConvertToSecureString(string value)
        {
            var secureString = new SecureString();
            foreach (char c in value)
            {
                secureString.AppendChar(c);
            }
            secureString.MakeReadOnly();
            return secureString;
        }

        /// <summary>
        /// Converts a SecureString to its plain text representation.
        /// </summary>
        /// <param name="secureString">The SecureString to convert.</param>
        /// <returns>The plain text string representation of the SecureString.</returns>
        public static string ConvertToUnsecureString(SecureString secureString)
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

        /// <summary>
        /// Encrypts a string using AES (Advanced Encryption Standard) algorithm.
        /// </summary>
        /// <param name="plainText">The plain text string to encrypt.</param>
        /// <param name="key">The cryptographic key used for encryption.</param>
        /// <returns>The encrypted string as a Base64-encoded representation.</returns>
        public static string EncryptString(string plainText, byte[] key)
        {
            byte[] encryptedBytes;

            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.Mode = CipherMode.CBC;

                byte[] iv = aes.IV;

                using (var encryptor = aes.CreateEncryptor(aes.Key, iv))
                {
                    using (var ms = new MemoryStream())
                    {
                        ms.Write(iv, 0, iv.Length);

                        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                            cs.Write(plainTextBytes, 0, plainTextBytes.Length);
                            cs.FlushFinalBlock();
                        }

                        encryptedBytes = ms.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(encryptedBytes);
        }

        /// <summary>
        /// Decrypts a string that was encrypted using AES (Advanced Encryption Standard) algorithm.
        /// </summary>
        /// <param name="encryptedText">The encrypted string as a Base64-encoded representation.</param>
        /// <param name="key">The cryptographic key used for decryption.</param>
        /// <returns>The decrypted plain text string.</returns>
        public static string DecryptString(string encryptedText, byte[] key)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.Mode = CipherMode.CBC;

                byte[] iv = new byte[aes.BlockSize / 8];
                Array.Copy(encryptedBytes, 0, iv, 0, iv.Length);

                using (var decryptor = aes.CreateDecryptor(aes.Key, iv))
                {
                    using (var ms = new MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                        {
                            cs.Write(encryptedBytes, iv.Length, encryptedBytes.Length - iv.Length);
                            cs.FlushFinalBlock();
                        }

                        byte[] decryptedBytes = ms.ToArray();
                        return Encoding.UTF8.GetString(decryptedBytes);
                    }
                }
            }
        }
    }
}
