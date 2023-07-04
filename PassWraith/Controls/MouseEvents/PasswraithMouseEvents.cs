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
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassWraith.Controls.MouseEvents
{
    public class PasswraithMouseEvents
    {
        private readonly IPassWraithContext _context;
        private readonly int PAGE_SIZE = 8;

        private PasswordEntity selectedPasswordEntity;
        private PasswraithDependencies dependencies;

        public int CURRENT_PAGE = 1;
        private bool IS_DATA_LOADING = false;
        public FilterType filterType = FilterType.ALL;

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
                 {"DeleteButton", new List<Control> { dependencies.DeleteBtn,} },
                  {"RestoreButton", new List<Control> { dependencies.RestoreBtn,} },
                  {"StarButton", new List<Control> { dependencies.StarPicBox,} },
                   {"ImportButton", new List<Control> { dependencies.BtnImport,} },
                   {"ExportButton", new List<Control> { dependencies.BtnExport,} },
                   {"FlowLayoutPanel", new List<Control> { dependencies.FlpMain,} },
                   {"FilterButton", new List<Control> { dependencies.AllItemsBtn, dependencies.BtnFavourites, dependencies.BtnTrash, dependencies.BtnCards} },
                   {"SearchButton", new List<Control> { dependencies.SearchBox} },
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
                        case "DeleteButton":
                            control.Click += DeleteBtn_Click;
                            break;
                        case "RestoreButton":
                            control.Click += RestoreBtn_Click;
                            break;
                        case "StarButton":
                            control.Click += Favourite_Click;
                            break;
                        case "ImportButton":
                            control.Click += ImportBtn_Click;
                            break;
                        case "ExportButton":
                            control.Click += ExportBtn_Click;
                            break;
                        case "FlowLayoutPanel":
                            control.MouseWheel += FlpMain_MouseWheel;
                            break;
                        case "FilterButton":
                            control.Click += Filter_Click;
                            break;
                        case "SearchButton":
                            control.KeyDown += SearchBox_KeyDownAsync;
                            break;
                        default:
                            throw new Exception("What the fck?");
                    }
                }
            }
        }

        public async void SearchBox_KeyDownAsync(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    await ClearFlpMain();
                    await Load(filterType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //public void SearchBox_TextChange(object sender, EventArgs e)
        //{
        //    dependencies.MainTimer?.Stop();
        //    dependencies.MainTimer = new Timer();
        //    dependencies.MainTimer.Interval = 500;
        //    dependencies.MainTimer.Tick += async (s, _) =>
        //    {
        //        await ClearFlpMain();
        //        await Load(filterType);
        //        dependencies.MainTimer.Stop();
        //    };

        //    dependencies.MainTimer.Start();
        //}

        public async void Filter_Click(object sender, EventArgs e)
        {

            var btn = (Guna2Button)sender;
            await ResetFilterButtons();
            btn.FillColor = Color.FromArgb(23, 93, 220);
            await Task.Run(() =>
            {
                btn.BeginInvoke((MethodInvoker)async delegate
                {
                    if (Enum.TryParse(btn.Tag.ToString(), true, out FilterType filter))
                    {
                        filterType = filter;
                    }
                    CURRENT_PAGE = 1;
                    await ClearFlpMain();
                    await Load(filterType);
                });

            });
        }

        public async Task ResetFilterButtons()
        {
            await Task.Run(() =>
             {
                 List<Guna2Button> filterButtons = new List<Guna2Button> { dependencies.AllItemsBtn, dependencies.BtnFavourites, dependencies.BtnTrash, dependencies.BtnCards };

                 foreach (var button in filterButtons)
                 {
                     button.FillColor = Color.Transparent;
                 }
             });
        }

        public async Task ClearFlpMain()
        {
            await Task.Run(() =>
            {
                if (dependencies.FlpMain.InvokeRequired)
                {
                    dependencies.FlpMain.BeginInvoke(new MethodInvoker(() =>
                    {
                        dependencies.FlpMain.Controls.Clear();
                    }));
                }
                else
                {
                    dependencies.FlpMain.Controls.Clear();
                }
            });
        }

        public async Task Load(FilterType filter)
        {
            try
            {
                await Task.Delay(100);
                var passwords = _context.Filter(filter, dependencies.SearchBox.Text.Trim(), CURRENT_PAGE, PAGE_SIZE);
                dependencies.SearchBox.BeginInvoke(new MethodInvoker(() =>
                {
                    dependencies.SearchBox.AutoCompleteCustomSource.Clear();
                    passwords.SelectMany(pass => new[] { pass.UserName, pass.WebSiteName }).ToList().ForEach(pass => dependencies.SearchBox.AutoCompleteCustomSource.Add(pass));
                }));


                await LoadPasswordHeadsAsync(passwords)
                    .ContinueWith(async task =>
                    {
                        if (CURRENT_PAGE == 1)
                        {
                            await ClickFirstControl();
                        }
                    });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        // PANEL BUTTON


        public void Btn_copy(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;

            if (button.Name == "dispBtnUsernameCopy")
            {
                Clipboard.SetText(dependencies.DispLblUsername.Text);
            }
            else if (button.Name == "dispBtnPasswordCopy")
            {
                Clipboard.SetText(PasswordHelper.DecryptString(dependencies.DispTxtPassword.Text,
                    PasswordHelper.GetKey()));
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
                    PasswordHelper.GetKey());
            }
            else
            {
                dependencies.DispTxtPassword.PasswordChar = '●';
                dependencies.DispTxtPassword.UseSystemPasswordChar = true;
                dependencies.DispTxtPassword.Text = PasswordHelper.EncryptString(dependencies.DispTxtPassword.Text,
                    PasswordHelper.GetKey());
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

        // ACTION BUTTON

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

        public async void DeleteBtn_Click(Object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (selectedPasswordEntity == null) return;
                _context.Delete(selectedPasswordEntity.Id);

            });
            await ClearFlpMain();
            CURRENT_PAGE = 1;
            await Load(filterType);
        }

        public async void RestoreBtn_Click(Object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (selectedPasswordEntity == null) return;
                _context.Restore(selectedPasswordEntity.Id);

            });
            await ClearFlpMain();
            CURRENT_PAGE = 1;
            await Load(filterType);
        }

        public void ImportBtn_Click(object sender, EventArgs e)
        {
            Import import = new Import(_context);
            import.ShowDialog();
        }

        public void ExportBtn_Click(object sender, EventArgs e)
        {
            CommaSeparatedHelper.ExportExcel(_context);
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

        // PANEL

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

        // SCROLL

        private async void FlpMain_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                int visibleHeight = dependencies.FlpMain.ClientSize.Height;
                int totalHeight = dependencies.FlpMain.DisplayRectangle.Height;
                int scrollPosition = dependencies.FlpMain.VerticalScroll.Value;

                if (scrollPosition + visibleHeight >= totalHeight && !IS_DATA_LOADING)
                {
                    IS_DATA_LOADING = true;

                    CURRENT_PAGE = CURRENT_PAGE + 1;
                    await Load(filterType);
                    IS_DATA_LOADING = false;
                }
            }
        }

        // PasswordHead

        private async Task ClickFirstControl()
        {
            await Task.Run(async () =>
            {
                await Task.Delay(500);
                PasswordHead control = dependencies.FlpMain.Controls.OfType<PasswordHead>().FirstOrDefault();
                dependencies.FlpMain.BeginInvoke((MethodInvoker)delegate
                {
                    if (control != null)
                    {
                        control = dependencies.FlpMain.Controls.OfType<PasswordHead>().FirstOrDefault();
                        Type controlType = this.GetType();
                        MethodInfo buttonClickMethod = controlType.GetMethod("User_click", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
                        if (buttonClickMethod != null)
                        {
                            buttonClickMethod.Invoke(this, new object[] { control, EventArgs.Empty });
                        }
                    }
                });
            });
        }

        private Task LoadPasswordHeadsAsync(List<PasswordEntity> passwords)
        {
            var downloadTasks = passwords.Select(async item =>
            {
                PasswordHead passwordHead = new PasswordHead
                {
                    Name = item.Id.ToString(),
                    usernameLabel = item.CredentialType == PasswordEntity.Type.Login ? item.UserName : item.CardNumber,
                    titleLabel = item.WebSiteName,
                };

                passwordHead.ControlClick += User_click;

                await AddPasswordHeadAsync(passwordHead);

                _ = Task.Run(async () =>
                {
                    passwordHead.passBoxImage = await DownloadImageAsync(FormHelper.BuildFavicon(item.WebsiteSiteUrl, item.WebSiteIconUrl));
                });
            });

            _ = Task.WhenAll(downloadTasks);
            return Task.CompletedTask;
        }

        private async Task<Image> DownloadImageAsync(string imageUrl)
        {
            if (imageUrl == null)
            {
                return Resources.icons8_Identification_Documents_128px;
            }
            using (var webClient = new WebClient())
            {
                try
                {
                    var imageBytes = await webClient.DownloadDataTaskAsync(imageUrl);
                    using (var memoryStream = new MemoryStream(imageBytes))
                    {
                        if (imageUrl.Contains(".ico"))
                        {
                            try
                            {
                                Icon icon = new Icon(memoryStream);
                                Image image = icon.ToBitmap();
                                return image;
                            }
                            catch (Exception ex)
                            {
                                return Resources.icons8_Identification_Documents_128px;
                            }

                        }
                        return Image.FromStream(memoryStream);
                    }
                }
                catch (WebException ex)
                {
                    Console.WriteLine($"Failed to download image: {ex.Message}");
                    return Resources.icons8_Identification_Documents_128px;
                }
            }
        }

        private Task AddPasswordHeadAsync(PasswordHead ph)
        {
            return Task.Run(() =>
            {
                if (dependencies.FlpMain.InvokeRequired)
                {
                    dependencies.FlpMain.Invoke(new Action(() => AddPasswordHead(ph)));
                }
                else
                {
                    AddPasswordHead(ph);
                }
            });
        }

        private void AddPasswordHead(PasswordHead ph)
        {
            dependencies.FlpMain.Controls.Add(ph);
        }

    }
}

public enum FilterType
{
    ALL, FAV, DEL, CARD
}