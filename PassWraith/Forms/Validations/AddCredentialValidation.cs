using PassWraith.Forms.Validations.ValidationModel;
using PassWraith.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;

namespace PassWraith.Forms.Validations
{

    public class AddCredentialValidation : FormHelper
    {
        private readonly string VISA_CARD_REGEX = "^4[0-9]{12}(?:[0-9]{3})?$";
        private readonly string MASTER_CARD_REGEX = "^(?:5[1-5][0-9]{14})$";
        private readonly string PIN_REGEX = "^[0-9]{3,4}$";
        private readonly string VALID_WEBSITE_REGEX = @"^(http(s)?://)?([\w-]+.)+[\w-]+(/[\w- ;,./?%&=]*)?$";

        protected AddCredentialValidationModel model;
        protected List<object> controls;

        public void InitControls(AddCredentialValidationModel model)
        {
            this.model = model;
            controls = new List<object> {
            model.txtUsername, model.txtPassword, model.txtConfirmPassword, model.txtWebsiteName, model.txtWebsiteUrl,
                model.txtExpiryDate, model.txtCardNumber, model.txtNotes,model.txtPin, model.cmbPasswordType, model.txtWebsiteIconUrl
            };
        }

        public bool ValidateLogin()
        {
            ResetControlsBorderColor(controls, Color.FromArgb(64, 64, 64));
            bool isFormValid = true;

            if (string.IsNullOrEmpty(model.txtUsername.Text))
            {
                SetError(model.txtUsername);
                isFormValid = false;
            }
            if (string.IsNullOrEmpty(model.txtWebsiteName.Text))
            {
                SetError(model.txtWebsiteName);
                isFormValid = false;
            }
            if (string.IsNullOrEmpty(model.txtWebsiteUrl.Text) && !(new Regex(VALID_WEBSITE_REGEX).IsMatch(model.txtWebsiteUrl.Text)))
            {
                SetError(model.txtWebsiteUrl);
                isFormValid = false;
            }
            if (!string.IsNullOrEmpty(model.txtWebsiteIconUrl.Text) && (!new Regex(VALID_WEBSITE_REGEX).IsMatch(model.txtWebsiteIconUrl.Text) || !IsImageExtension(model.txtWebsiteIconUrl.Text)))
            {
                SetError(model.txtWebsiteIconUrl);
                isFormValid = false;
            }
            if (string.IsNullOrEmpty(model.txtPassword.Text))
            {
                SetError(model.txtPassword);
                isFormValid = false;
            }
            if (string.IsNullOrEmpty(model.txtConfirmPassword.Text))
            {
                SetError(model.txtPassword);
                isFormValid = false;
            }
            if (model.txtConfirmPassword.Text != model.txtPassword.Text)
            {
                SetError(model.txtPassword);
                SetError(model.txtConfirmPassword);
                isFormValid = false;
            }
            return isFormValid;
        }

        public bool ValidateCard()
        {
            ResetControlsBorderColor(controls, Color.FromArgb(64, 64, 64));
            bool isFormValid = true;

            if (string.IsNullOrEmpty(model.txtWebsiteName.Text))
            {
                SetError(model.txtWebsiteName);
                isFormValid = false;
            }
            if (!string.IsNullOrEmpty(model.txtWebsiteUrl.Text) && !(new Regex(VALID_WEBSITE_REGEX).IsMatch(model.txtWebsiteUrl.Text)))
            {
                SetError(model.txtWebsiteUrl);
                isFormValid = false;
            }
            if (!string.IsNullOrEmpty(model.txtWebsiteIconUrl.Text) && (!new Regex(VALID_WEBSITE_REGEX).IsMatch(model.txtWebsiteIconUrl.Text) || !IsImageExtension(model.txtWebsiteIconUrl.Text)))
            {
                SetError(model.txtWebsiteIconUrl);
                isFormValid = false;
            }
            if (string.IsNullOrEmpty(model.txtCardNumber.Text))
            {
                SetError(model.txtCardNumber);
                isFormValid = false;
            }

            if (string.IsNullOrEmpty(model.txtPin.Text))
            {
                SetError(model.txtPin);
                isFormValid = false;
            }

            if (string.IsNullOrEmpty(model.txtExpiryDate.Text))
            {
                SetError(model.txtExpiryDate);
                isFormValid = false;
            }

            if (string.IsNullOrEmpty(model.txtExpiryDate.Text))
            {
                SetError(model.txtExpiryDate);
                isFormValid = false;
            }

            if (!(new Regex(VISA_CARD_REGEX).IsMatch(model.txtCardNumber.Text) || new Regex(MASTER_CARD_REGEX).IsMatch(model.txtCardNumber.Text)))
            {
                SetError(model.txtCardNumber);
                isFormValid = false;
            }

            if (!(new Regex(PIN_REGEX).IsMatch(model.txtPin.Text)))
            {
                SetError(model.txtPin);
                isFormValid = false;
            }

            if (DateTime.Parse(model.txtExpiryDate.Text).Date < DateTime.Now.Date)
            {
                SetError(model.txtExpiryDate);
                isFormValid = false;
            }

            return isFormValid;
        }
    }
}
