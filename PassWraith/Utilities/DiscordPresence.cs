using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassWraith.Utilities
{
    public class DiscordPresence
    {

        private readonly DiscordRpcClient client;

        public DiscordPresence() {
            this.client = new DiscordRpcClient("1122096234723819541");
        }

        public void Init()
        {
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = "Managing Passwords",
                State = "In-Password-Manager",
                Assets = new Assets()
                {
                    LargeImageKey = "main",
                    LargeImageText = "PassWraith",
                }
            });
        }
    }
}
