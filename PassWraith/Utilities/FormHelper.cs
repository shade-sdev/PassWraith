using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PassWraith.Utilities
{
    public abstract class FormHelper : Form
    {
        public void SetError(object Control)
        {
            switch (Control)
            {
                case Guna2TextBox textBox:
                    textBox.BorderColor = Color.Red;
                    break;
                case Guna2ComboBox comboBox:
                    comboBox.BorderColor = Color.Red;
                    break;
                case Guna2DateTimePicker dateTimePicker:
                    dateTimePicker.BorderColor = Color.Red;
                    break;
                default:
                    break;
            }
        }

        public void SetComboBoxDataSource<TEnum>(Guna2ComboBox comboBox)
        {
            comboBox.DataSource = Enum.GetValues(typeof(TEnum));
        }

        public int GetEnumOrdinal<TEnum>(TEnum enumValue) where TEnum : Enum
        {
            return (int)Convert.ChangeType(enumValue, typeof(int));
        }

        public String Sanitize(string s) { 
            if(string.IsNullOrEmpty(s)) return null;
            return s.Trim();
        }

        public int SanitizeInt(string i) { 
            if(string.IsNullOrEmpty(i)) return 0;
            return Convert.ToInt32(i);
        }

        public bool IsImageExtension(string url)
        {
            string extension = Path.GetExtension(url);
            if (extension == null)
            {
                return false;
            }
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".ico", ".svg" };
            string lowercaseExtension = extension.ToLowerInvariant();
            return imageExtensions.Contains(lowercaseExtension);
        }

        public static string BuildFavicon(string websiteUrl, string iconUrl)
        {
            if (string.IsNullOrEmpty(websiteUrl) && string.IsNullOrEmpty(iconUrl))
            {
                return null;
            }

            if (!string.IsNullOrEmpty(websiteUrl) && string.IsNullOrEmpty(iconUrl))
            {
                Uri myUri = new Uri(websiteUrl);
                string host = myUri.Host;
                return "https://" + host + "/favicon.ico";
            }

            return iconUrl;
        }

        public void ResetControlsBorderColor(List<object> controls, Color color)
        {
            foreach (object control in controls)
            {
                switch (control)
                {
                    case Guna2TextBox textBox:
                        textBox.BorderColor = color;
                        break;
                    case Guna2ComboBox comboBox:
                        comboBox.BorderColor = color;
                        break;
                    case Guna2DateTimePicker dateTimePicker:
                        dateTimePicker.BorderColor = color;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
