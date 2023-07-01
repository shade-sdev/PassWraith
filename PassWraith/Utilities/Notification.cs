using PassWraith.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassWraith.Utilities
{
    public class Notification
    {
        public static void ShowNotification(ToolTipIcon icon, int timeout, string title, string message)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = Icon.FromHandle(Resources._00016.GetHicon());
            notifyIcon.Text = "Passwraith";
            notifyIcon.Visible = true;

            notifyIcon.ShowBalloonTip(timeout, title, message, icon);
        }
    }

}
