using PassWraith.Data.Entities;
using PassWraith.Forms.Validations.ValidationModel;
using PassWraith.Forms.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassWraith.Data;
using Microsoft.Extensions.DependencyInjection;
using PassWraith.Utilities;

namespace PassWraith.Forms
{
    public partial class Login : LoginValidation, IValidationModel<LoginValidationModel, UserPasswordEntity>
    {

        private readonly IServiceProvider serviceProvider;
        private readonly IPassWraithContext _context;

        public Login(IPassWraithContext _context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this._context = _context;
            this.serviceProvider = serviceProvider;
            InitControls(BuildValidationModel(), this._context);
        }

        public UserPasswordEntity BuildEntity()
        {
            throw new NotImplementedException();
        }

        public LoginValidationModel BuildValidationModel()
        {
            return new LoginValidationModel
            {
                txtPassword = txtPassword,
                txtSecretKey = txtSecretKey,
            };
        }

        public void LoadForm(UserPasswordEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task SaveForm()
        {
            throw new NotImplementedException();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValid = false;

            Task<bool> validateLoginTask = Task.Run(() => ValidateLogin());
            isValid = await validateLoginTask;
            btnLogin.Enabled = !isValid;
            if (isValid)
            {
                Constants.secretKey = PasswordHelper.ConvertToSecureString(txtSecretKey.Text);
                Constants.userPassword = _context.Get().Password;
                Constants.key = PasswordHelper.DeriveKeyFromPassword(Constants.userPassword, PasswordHelper.ConvertToUnsecureString(Constants.secretKey));
                Hide();
                using (var passWraith = serviceProvider.GetRequiredService<PassWraith>())
                {
                    passWraith.ShowDialog();
                    Close();
                }

            }
        }
    }
}
