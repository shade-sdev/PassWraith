using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassWraith
{
    public partial class PasswordHead : UserControl
    {
        public PasswordHead()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("User Click on control")]
        public event EventHandler ControlClick
        {

            add
            {
                _controlClick += value;
            }
            remove
            {
                _controlClick -= value;
            }
        }

        public string controlName
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }

        public Color controlBackgroundColor
        {
            get
            {
                return this.mainPanel.FillColor;
            }

            set
            {
                this.mainPanel.FillColor = value;
            }
        }

        public string titleLabel
        {
            get
            {
                return titleLbl.Text;
            }

            set
            {
                titleLbl.Text = value;
            }
        }

        public string usernameLabel
        {
            get
            {
                return usernameLbl.Text;
            }

            set
            {
                usernameLbl.Text = value;
            }
        }

        public Guna2PictureBox passBox
        {
            get
            {
                return passIconPic;
            }

            set
            {
                passIconPic = value;
            }
        }

        public Image passBoxImage
        {
            get {
                return passIconPic.Image; 
            }

            set
            {
                passIconPic.Image = value;
            }

        }

        private EventHandler _controlClick;

        private void mainPanel_Click(object sender, EventArgs e)
        {
            this._controlClick?.Invoke(this, e);
        }

        private void titleLbl_Click(object sender, EventArgs e)
        {
            this._controlClick?.Invoke(this, e);
        }

        private void usernameLbl_Click(object sender, EventArgs e)
        {
            this._controlClick?.Invoke(this, e);
        }

        private void passIconPic_Click(object sender, EventArgs e)
        {
            this._controlClick?.Invoke(this, e);
        }
    }
}
