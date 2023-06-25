using Guna.UI2.WinForms;
using PassWraith.Data;
using PassWraith.Data.Entities;
using PassWraith.Dependencies;
using PassWraith.Forms;
using PassWraith.Properties;
using PassWraith.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassWraith.Controls.MouseEvents
{
    public class PasswraithMouseEvents
    {
        private readonly IPassWraithContext _context;
        private PasswordEntity selectedPasswordEntity;
        private PasswraithDependencies dependencies;

        public PasswraithMouseEvents(IPassWraithContext _context, PasswraithDependencies dependencies)
        {
            this._context = _context;
            this.dependencies = dependencies;
        }


        public void InitMouseEvents()
        {
            Dictionary<string, List<Control>> controlMap = new Dictionary<string, List<Control>>()
            {
                { "Username", new List<Control> { dependencies.DispUsernamePanel, dependencies.DispBtnUsernameCopy, dependencies.DispLblUsernameTitle, dependencies.DispLblUsername } },
                     { "Password", new List<Control> { dependencies.DispPasswordPanel, dependencies.DispTxtPassword, dependencies.DispBtnPasswordView, dependencies.DispBtnPasswordCopy, dependencies.DispLblPasswordTitle } },
                       { "Website", new List<Control> { dependencies.DispWebsitePanel, dependencies.DispBtnWebsiteCopy, dependencies.DispLblWebsiteTitle, dependencies.DispLblWebsiteName } },
                {"AddButton", new List<Control> { dependencies.AddBtn,} },
                     {"EditButton", new List<Control> { dependencies.EditBtn,} },
                  {"StarButton", new List<Control> { dependencies.StarPicBox,} }
            };

            foreach (string key in controlMap.Keys)
            {
                foreach (Control control in controlMap[key])
                {
                    switch (key)
                    {
                        case "Username":
                            control.MouseEnter += dispUsernamePanel_MouseEnter;
                            control.MouseLeave += dispUsernamePanel_MouseLeave;
                            CopyViewEvent(control);
                            break;

                        case "Password":
                            control.MouseEnter += dispPasswordPanel_MouseEnter;
                            control.MouseLeave += dispPasswordPanel_MouseLeave;
                            CopyViewEvent(control);
                            break;

                        case "Website":
                            control.MouseEnter += dispWebsitePanel_MouseEnter;
                            control.MouseLeave += dispWebsitePanel_MouseLeave;
                            CopyViewEvent(control);
                            break;
                        case "AddButton":
                            control.Click += AddBtn_Click;
                            break;
                        case "EditButton":
                            control.Click += EditBtn_Click;
                            break;
                        case "StarButton":
                            dependencies.StarPicBox.Click += Favourite_Click;
                            break;
                        default:
                            throw new Exception("What the fck?");
                    }
                }
            }
        }

        public void dispUsernamePanel_MouseEnter(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                dependencies.DispUsernamePanel.BeginInvoke((MethodInvoker)delegate
                {
                    dependencies.DispUsernamePanel.FillColor = Color.FromArgb(40, 40, 40);
                    dependencies.DispBtnUsernameCopy.Visible = true;
                });
            });
        }

        public void dispUsernamePanel_MouseLeave(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                dependencies.DispUsernamePanel.BeginInvoke((MethodInvoker)delegate
                {
                    dependencies.DispUsernamePanel.FillColor = Color.FromArgb(30, 30, 30);
                    dependencies.DispBtnUsernameCopy.Visible = false;
                });
            });
        }

        public void dispPasswordPanel_MouseEnter(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                dependencies.DispPasswordPanel.BeginInvoke((MethodInvoker)delegate
                {
                    dependencies.DispPasswordPanel.FillColor = Color.FromArgb(40, 40, 40);
                    dependencies.DispTxtPassword.FillColor = Color.FromArgb(40, 40, 40);
                    dependencies.DispTxtPassword.BorderColor = Color.FromArgb(40, 40, 40);
                    dependencies.DispTxtPassword.FocusedState.BorderColor = Color.FromArgb(40, 40, 40);
                    dependencies.DispTxtPassword.HoverState.BorderColor = Color.FromArgb(40, 40, 40);
                    dependencies.DispBtnPasswordView.Visible = true;
                    dependencies.DispBtnPasswordCopy.Visible = true;
                });
            });
        }

        public void dispPasswordPanel_MouseLeave(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                dependencies.DispPasswordPanel.BeginInvoke((MethodInvoker)delegate
                {
                    dependencies.DispPasswordPanel.FillColor = Color.FromArgb(30, 30, 30);
                    dependencies.DispTxtPassword.FillColor = Color.FromArgb(30, 30, 30);
                    dependencies.DispTxtPassword.BorderColor = Color.FromArgb(30, 30, 30);
                    dependencies.DispTxtPassword.FocusedState.BorderColor = Color.FromArgb(30, 30, 30);
                    dependencies.DispTxtPassword.HoverState.BorderColor = Color.FromArgb(30, 30, 30);
                    dependencies.DispBtnPasswordView.Visible = false;
                    dependencies.DispBtnPasswordCopy.Visible = false;
                });
            });
        }

        public void dispWebsitePanel_MouseEnter(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                dependencies.DispWebsitePanel.BeginInvoke((MethodInvoker)delegate
                {
                    dependencies.DispWebsitePanel.FillColor = Color.FromArgb(40, 40, 40);
                    dependencies.DispBtnWebsiteCopy.Visible = true;
                });
            });
        }

        public void dispWebsitePanel_MouseLeave(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                dependencies.DispWebsitePanel.BeginInvoke((MethodInvoker)delegate
                {
                    dependencies.DispWebsitePanel.FillColor = Color.FromArgb(30, 30, 30);
                    dependencies.DispBtnWebsiteCopy.Visible = false;
                });
            });
        }

        public void Btn_copy(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;

            if (button.Name == "dispBtnUsernameCopy")
            {
                Clipboard.SetText(dependencies.DispLblUsername.Text);
            }
            else if (button.Name == "dispBtnPasswordCopy")
            {
                Clipboard.SetText(dependencies.DispTxtPassword.Text);
            }
            else
            {
                Clipboard.SetText(dependencies.DispLblWebsiteName.Text);
            }
        }

        public void Btn_view(object sender, EventArgs e)
        {
            if (dependencies.DispTxtPassword.UseSystemPasswordChar)
            {
                dependencies.DispTxtPassword.PasswordChar = '\0';
                dependencies.DispTxtPassword.UseSystemPasswordChar = false;
                dependencies.DispTxtPassword.Text = PasswordHelper.DecryptString(dependencies.DispTxtPassword.Text,
                    PasswordHelper.DeriveKeyFromPassword(_context.Get().Password, PasswordHelper.ConvertToUnsecureString(Constants.secretKey)));
            }
            else
            {
                dependencies.DispTxtPassword.PasswordChar = '●';
                dependencies.DispTxtPassword.UseSystemPasswordChar = true;
                dependencies.DispTxtPassword.Text = PasswordHelper.EncryptString(dependencies.DispTxtPassword.Text,
                    PasswordHelper.DeriveKeyFromPassword(_context.Get().Password, PasswordHelper.ConvertToUnsecureString(Constants.secretKey)));
            }
        }

        public void CopyViewEvent(Control control)
        {
            if (control is Guna2Button && "View" == control.Tag.ToString())
            {
                control.Click += Btn_view;
            }
            else if (control is Guna2Button && "Copy" == control.Tag.ToString())
            {
                control.Click += Btn_copy;
            }
        }

        public async void User_click(object sender, EventArgs e)
        {
            var passHead = (PasswordHead)sender;

            await Task.Run(() =>
            {
                this.selectedPasswordEntity = _context.Get(int.Parse(passHead.Name));
                dependencies.StarPicBox.Image = !selectedPasswordEntity.IsFavourite ? Resources.icons8_star_60px : Resources.icons8_star_480px;
                dependencies.FlpMain.BeginInvoke((MethodInvoker)delegate
                {
                    ResetPanelData();
                    dependencies.FlpMain.Controls
                        .OfType<PasswordHead>()
                        .Where(passHeadz => passHeadz.controlBackgroundColor == Color.FromArgb(23, 93, 220))
                        .ToList()
                        .ForEach(passHeadz => passHeadz.controlBackgroundColor = Color.FromArgb(30, 30, 30));
                });
            });

            passHead.Invoke(new Action(() => passHead.controlBackgroundColor = Color.FromArgb(23, 93, 220)));
            dependencies.LblDisplayUserName.Text = passHead?.usernameLabel;
            dependencies.LblDisplayWebsiteName.Text = passHead?.titleLabel;
            dependencies.DisplayPicBox.Image = passHead?.passBoxImage;
        }

        private void ResetPanelData()
        {
            switch (selectedPasswordEntity.CredentialType)
            {
                case PasswordEntity.Type.Login:
                    dependencies.DispLblUsernameTitle.Text = "Username";
                    dependencies.DispLblUsername.Text = selectedPasswordEntity.UserName;
                    dependencies.DispLblPasswordTitle.Text = "Password";
                    dependencies.DispTxtPassword.Text = selectedPasswordEntity.Password;
                    dependencies.DispLblWebsiteName.Text = selectedPasswordEntity.WebSiteName;
                    dependencies.TxtNotes.Text = selectedPasswordEntity.Notes;
                    break;

                case PasswordEntity.Type.Card:
                    dependencies.DispLblUsernameTitle.Text = "Card Number";
                    dependencies.DispLblUsername.Text = selectedPasswordEntity.CardNumber;
                    dependencies.GunaToolTip.SetToolTip(dependencies.DispLblUsername, selectedPasswordEntity.CardExpiryDate.ToString());
                    dependencies.DispLblPasswordTitle.Text = "PIN";
                    dependencies.DispTxtPassword.Text = selectedPasswordEntity.PIN;
                    dependencies.DispLblWebsiteName.Text = selectedPasswordEntity.WebSiteName;
                    dependencies.TxtNotes.Text = selectedPasswordEntity.Notes;
                    break;
            }
        }

        public void AddBtn_Click(object sender, EventArgs e)
        {
            AddCredential addCredential = new AddCredential(null, _context);
            addCredential.ShowDialog();
        }

        public void EditBtn_Click(object sender, EventArgs e)
        {
            AddCredential addCredential = new AddCredential(selectedPasswordEntity, _context);
            addCredential.ShowDialog();
        }

        public async void Favourite_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (selectedPasswordEntity == null) return;
                _context.SetFavourite(selectedPasswordEntity.Id);
                dependencies.StarPicBox.Image = !selectedPasswordEntity.IsFavourite ? Resources.icons8_star_60px : Resources.icons8_star_480px;
            });

        }

    }
}
