using PassWraith.Controls.MouseEvents;
using PassWraith.Data;
using PassWraith.Utilities;
using System;
using System.Windows.Forms;

namespace PassWraith
{
    public partial class PassWraith : Form
    {
        private readonly IPassWraithContext passWraithContext;
        public readonly PasswraithMouseEvents mouseEvents;
        private readonly DiscordPresence discord = new DiscordPresence();

        public PassWraith(IPassWraithContext passWraithContext)
        {
            InitializeComponent();
            this.passWraithContext = passWraithContext;
            mouseEvents = new PasswraithMouseEvents(passWraithContext, BuildDependencides());
            mouseEvents.InitMouseEvents();
            discord.Init();
        }

        private async void PassWraith_Load(object sender, EventArgs e)
        {
            await mouseEvents.Load(FilterType.ALL);
        }

    }
}