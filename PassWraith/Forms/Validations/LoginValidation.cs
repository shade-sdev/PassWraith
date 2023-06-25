using Microsoft.Extensions.DependencyInjection;
using PassWraith.Data;
using PassWraith.Forms.Validations.ValidationModel;
using PassWraith.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PassWraith.Forms.Validations
{
    public class LoginValidation : FormHelper
    {
        private static readonly IServiceProvider serviceProvider;
        private IPassWraithContext _context;

        protected LoginValidationModel model;
        protected List<object> controls;

        public void InitControls(LoginValidationModel model, IPassWraithContext _context)
        {
            this.model = model;
            controls = new List<object> {
            model.txtPassword, model.txtSecretKey
            };
            this._context = _context;
        }

        public bool ValidateLogin()
        {
            ResetControlsBorderColor(controls, Color.FromArgb(64, 64, 64));
            bool isFormValid = true;

            if (!_context.IsUserRegistered())
            {
                Application.Run(serviceProvider.GetRequiredService<Login>());
                this.Close();
            }

            if (string.IsNullOrEmpty(model.txtPassword.Text))
            {
                SetError(model.txtPassword);
                isFormValid = false;
            }

            if (!PasswordHelper.VerifyPassword(model.txtPassword.Text, _context.Get().Password))
            {
                SetError(model.txtPassword);
                isFormValid = false;
            }

            if (string.IsNullOrEmpty(model.txtSecretKey.Text) || model.txtSecretKey.Text.Length < 8)
            {
                SetError(model.txtSecretKey);
                isFormValid = false;
            }

            return isFormValid;
        }
    }
}
