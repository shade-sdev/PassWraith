using PassWraith.Data.Entities;
using PassWraith.Forms.Validations.ValidationModel;
using PassWraith.Forms.Validations;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassWraith.Utilities;
using PassWraith.Data;
using Microsoft.Extensions.DependencyInjection;

namespace PassWraith.Forms
{
    public partial class Register : RegisterValidation, IValidationModel<RegisterValidationModel, UserPasswordEntity>
    {
        private readonly IServiceProvider serviceProvider;
        private readonly IPassWraithContext _context;

        public Register(IPassWraithContext _context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this._context = _context;
            InitControls(BuildValidationModel());
            this.serviceProvider = serviceProvider;
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

        public UserPasswordEntity BuildEntity()
        {
            return new UserPasswordEntity()
            {
                Password = PasswordHelper.EncryptPassword(txtPassword.Text)
            };
        }

        public RegisterValidationModel BuildValidationModel()
        {
            return new RegisterValidationModel
            {
                txtConfirmPassword = txtConfirmPassword,
                txtPassword = txtPassword
            };
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            bool isValid = false;

            Task<bool> validateRegisterTask = Task.Run(() => ValidateRegister());
            isValid = await validateRegisterTask;
            btnRegister.Enabled = !isValid;
            if (isValid)
            {
                await SaveForm();
            }
        }

        public async Task SaveForm()
        {

            await Task.Run(() => { 
            _context.Save(BuildEntity());
            });
            Hide();
            using (var login = serviceProvider.GetRequiredService<Login>())
            {
                login.ShowDialog();
                Close();
            }
   
        }

        public void LoadForm(UserPasswordEntity entity)
        {
            // No need to implement
        }
    }
}
