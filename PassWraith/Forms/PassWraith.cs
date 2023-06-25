using PassWraith.Controls.MouseEvents;
using PassWraith.Data;
using PassWraith.Data.Entities;
using PassWraith.Properties;
using PassWraith.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassWraith
{
    public partial class PassWraith : Form
    {
        private readonly IPassWraithContext passWraithContext;
        private readonly PasswraithMouseEvents mouseEvents;
        private readonly DiscordPresence discord = new DiscordPresence();

        public PassWraith(IPassWraithContext passWraithContext)
        {
            InitializeComponent();
            this.passWraithContext = passWraithContext;
            mouseEvents = new PasswraithMouseEvents(passWraithContext, BuildDependencides());
            mouseEvents.InitMouseEvents();
            discord.Init();
            Console.WriteLine(CommaSeparatedHelper.ToPasswordEntities("C:\\Users\\Shade\\Desktop\\Chrome Passwords.csv"));
        }

        private async void PassWraith_Load(object sender, EventArgs e)
        {
            List<PasswordEntity> passwords = passWraithContext.GetAll();
            passwords.SelectMany(pass => new[] { pass.UserName, pass.WebSiteName }).ToList().ForEach(pass => this.searchBox.AutoCompleteCustomSource.Add(pass));
            await LoadPasswordHeadsAsync(passwords);
        }

        public async Task LoadPasswordHeadsAsync(List<PasswordEntity> passwords)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            var downloadTasks = passwords.Select(async item =>
            {
                PasswordHead passwordHead = new PasswordHead
                {
                    Name = item.Id.ToString(),
                    usernameLabel = item.CredentialType == PasswordEntity.Type.Login ? item.UserName : item.CardNumber,
                    titleLabel = item.WebSiteName,
                };

                passwordHead.ControlClick += mouseEvents.User_click;

                await AddPasswordHeadAsync(passwordHead);

                await Task.Run(async () =>
                {
                    passwordHead.passBoxImage = await DownloadImageAsync(item.WebSiteIconUrl);
                });
            });

            await Task.WhenAll(downloadTasks);
        }

        public async Task ClearFlpMain()
        {
            await Task.Run(() =>
            {
                if (flpMain.InvokeRequired)
                {
                    flpMain.BeginInvoke(new MethodInvoker(() =>
                    {
                        flpMain.Controls.Clear();
                    }));
                }
                else
                {
                    flpMain.Controls.Clear();
                }
            });
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
                            } catch (Exception ex)
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
                if (flpMain.InvokeRequired)
                {
                    flpMain.Invoke(new Action(() => AddPasswordHead(ph)));
                }
                else
                {
                    AddPasswordHead(ph);
                }
            });
        }

        private void AddPasswordHead(PasswordHead ph)
        {
            flpMain.Controls.Add(ph);
        }

    }
}