using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassWraith.Utilities
{
    public class PasswordHelper
    {
        public static string EncryptPassword(string password)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
            return hashedPassword;
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            bool passwordMatches = BCrypt.Net.BCrypt.Verify(password, hashedPassword);
            return passwordMatches;
        }
    }
}
