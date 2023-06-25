using PassWraith.Forms.Validations.ValidationModel;
using PassWraith.Utilities;
using System.Collections.Generic;
using System.Drawing;

namespace PassWraith.Forms.Validations
{
    public class RegisterValidation : FormHelper
    {

        protected RegisterValidationModel model;
        protected List<object> controls;

        public void InitControls(RegisterValidationModel model)
        {
            this.model = model;
            controls = new List<object> {
            model.txtPassword, model.txtConfirmPassword
            };
        }

        public bool ValidateRegister()
        {
            ResetControlsBorderColor(controls, Color.FromArgb(64, 64, 64));
            bool isFormValid = true;

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
    }
}
