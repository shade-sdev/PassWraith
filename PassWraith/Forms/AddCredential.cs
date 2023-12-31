﻿using PassWraith.Data;
using PassWraith.Data.Entities;
using PassWraith.Forms.Validations;
using PassWraith.Forms.Validations.ValidationModel;
using PassWraith.Utilities;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters.Entities;

namespace PassWraith.Forms
{
    public partial class AddCredential : AddCredentialValidation, IValidationModel<AddCredentialValidationModel, PasswordEntity>
    {

        private readonly IPassWraithContext _context;

        public AddCredential(PasswordEntity password, IPassWraithContext context) : base()
        {
            InitializeComponent();
            SetComboBoxDataSource<PasswordEntity.Type>(cmbPasswordType);
            InitControls(BuildValidationModel());
            _context = context;
            if (password != null)
            {
                LoadForm(password);
            };
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            bool isValid = false;

            switch ((PasswordEntity.Type)cmbPasswordType.SelectedValue)
            {
                case PasswordEntity.Type.Login:
                    Task<bool> validateLoginTask = Task.Run(() => ValidateLogin());
                    isValid = await validateLoginTask;
                    btnSave.Enabled = !isValid;
                    if (isValid)
                    {
                        await SaveForm();
                    }
                    break;

                case PasswordEntity.Type.Card:
                    Task<bool> validateCardTask = Task.Run(() => ValidateCard());
                    isValid = await validateCardTask;
                    btnSave.Enabled = !isValid;
                    if (isValid)
                    {
                        await SaveForm();
                    }
                    break;

                default:
                    SetError(cmbPasswordType);
                    break;
            }
        }

        public AddCredentialValidationModel BuildValidationModel()
        {
            return new AddCredentialValidationModel
            {
                txtUsername = txtUsername,
                txtPassword = txtPassword,
                txtConfirmPassword = txtConfirmPassword,
                txtWebsiteUrl = txtWebsiteUrl,
                txtWebsiteIconUrl = txtWebsiteIconUrl,
                txtWebsiteName = txtWebsiteName,
                txtExpiryDate = txtExpiryDate,
                txtCardNumber = txtCardNumber,
                txtNotes = txtNotes,
                txtPin = txtPin,
                cmbPasswordType = cmbPasswordType
            };
        }

        public PasswordEntity BuildEntity()
        {
            return new PasswordEntity
            {
                Id = SanitizeInt(lblId.Text),
                UserName = Sanitize(txtUsername.Text),
                WebSiteName = Sanitize(txtWebsiteName.Text),
                WebsiteSiteUrl = Sanitize(txtWebsiteUrl.Text),
                WebSiteIconUrl = BuildFavicon(txtWebsiteUrl.Text, txtWebsiteIconUrl.Text),
                Password = BuildPassword((PasswordEntity.Type)Enum.Parse(typeof(PasswordEntity.Type), cmbPasswordType.Text),
                PasswordEntity.Type.Login, Sanitize(txtPassword.Text), true),
                CredentialType = (PasswordEntity.Type)Enum.Parse(typeof(PasswordEntity.Type), cmbPasswordType.Text),
                CardNumber = Sanitize(txtCardNumber.Text),
                PIN = BuildPassword((PasswordEntity.Type)Enum.Parse(typeof(PasswordEntity.Type), cmbPasswordType.Text),
                PasswordEntity.Type.Card, Sanitize(txtPin.Text), true),
                CardExpiryDate = DateTime.Parse(txtExpiryDate.Text),
                Notes = Sanitize(txtNotes.Text)
            };
        }

        public void LoadForm(PasswordEntity entity)
        {
            lblId.Text = entity.Id.ToString();
            txtUsername.Text = entity.UserName;
            txtWebsiteName.Text = entity.WebSiteName;
            txtWebsiteUrl.Text = entity.WebsiteSiteUrl;
            txtWebsiteIconUrl.Text = entity.WebSiteIconUrl;
            txtPassword.Text = BuildPassword(entity.CredentialType, PasswordEntity.Type.Login, entity.Password, false);
            txtConfirmPassword.Text = txtPassword.Text;
            cmbPasswordType.SelectedIndex = GetEnumOrdinal(entity.CredentialType);
            txtCardNumber.Text = entity.CardNumber;
            txtPin.Text = BuildPassword(entity.CredentialType, PasswordEntity.Type.Card, entity.PIN, false);
            txtExpiryDate.Text = entity.CardExpiryDate.ToString();
            txtNotes.Text = entity.Notes;
        }

        public async Task SaveForm()
        {
            saveProgress.Visible = true;
            saveProgress.AutoStart = true;
            _ = BuildEntity().Id == 0 ? _context.Save(BuildEntity()) : _context.Update(BuildEntity().Id, BuildEntity());
            var passWraithForm = Application.OpenForms.OfType<PassWraith>().FirstOrDefault();
            await passWraithForm.mouseEvents.ClearFlpMain();
            passWraithForm.mouseEvents.CURRENT_PAGE = 1;
            await passWraithForm.mouseEvents.Load(passWraithForm.mouseEvents.filterType);
            saveProgress.Visible = false;
            Close();
        }

        public string BuildPassword(PasswordEntity.Type type, PasswordEntity.Type actualType, string password, bool isEncrypt)
        {
            if (isEncrypt)
            {
                if (type == actualType)
                {
                    return PasswordHelper.EncryptString(password, PasswordHelper.GetKey());
                }
                return null;
            }
            else
            {
                if (type == actualType)
                {
                    return PasswordHelper.DecryptString(password, PasswordHelper.GetKey());
                } 
                return null;
            }
        }
    }
}