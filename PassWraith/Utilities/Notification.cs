using PassWraith.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace PassWraith.Utilities
{
    public class Notification
    {
        public static void ShowNotification(ToolTipIcon icon, int timeout, string title, string message)
        {
            Constants.notifyIcon.Icon = Icon.FromHandle(Resources._00016.GetHicon());
            Constants.notifyIcon.Text = "Passwraith";
            Constants.notifyIcon.Visible = true;

            Constants.notifyIcon.ShowBalloonTip(timeout, title, message, icon);
        }
    }

}
