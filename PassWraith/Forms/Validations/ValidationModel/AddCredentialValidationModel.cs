using Guna.UI2.WinForms;

namespace PassWraith.Forms.Validations.ValidationModel
{
    public class AddCredentialValidationModel
    {
        public Guna2TextBox txtUsername { get; set; }
        public Guna2TextBox txtPassword { get; set; }
        public Guna2TextBox txtConfirmPassword { get; set; }
        public Guna2TextBox txtWebsiteUrl { get; set; }
        public Guna2TextBox txtWebsiteIconUrl { get; set; }
        public Guna2TextBox txtWebsiteName { get; set; }
        public Guna2DateTimePicker txtExpiryDate { get; set; }
        public Guna2TextBox txtCardNumber { get; set; }
        public Guna2TextBox txtNotes { get; set; }
        public Guna2TextBox txtPin { get; set; }
        public Guna2ComboBox cmbPasswordType { get; set; }
    }
}
