namespace PassWraith
{
    partial class PasswordHead
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.usernameLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.titleLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passIconPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passIconPic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainPanel.BorderRadius = 4;
            this.mainPanel.Controls.Add(this.usernameLbl);
            this.mainPanel.Controls.Add(this.titleLbl);
            this.mainPanel.Controls.Add(this.passIconPic);
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(339, 70);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Click += new System.EventHandler(this.mainPanel_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = false;
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Font = new System.Drawing.Font("Roboto Bk", 9F);
            this.usernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.usernameLbl.Location = new System.Drawing.Point(78, 38);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(243, 15);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "shade@shade.ga";
            this.usernameLbl.Click += new System.EventHandler(this.usernameLbl_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = false;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Roboto Bk", 12F);
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(79, 18);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(242, 21);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Adobe";
            this.titleLbl.Click += new System.EventHandler(this.titleLbl_Click);
            // 
            // passIconPic
            // 
            this.passIconPic.BackColor = System.Drawing.Color.Transparent;
            this.passIconPic.BorderRadius = 2;
            this.passIconPic.ImageRotate = 0F;
            this.passIconPic.Location = new System.Drawing.Point(19, 15);
            this.passIconPic.Name = "passIconPic";
            this.passIconPic.Size = new System.Drawing.Size(40, 40);
            this.passIconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passIconPic.TabIndex = 0;
            this.passIconPic.TabStop = false;
            this.passIconPic.Click += new System.EventHandler(this.passIconPic_Click);
            // 
            // PasswordHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.mainPanel);
            this.Name = "PasswordHead";
            this.Size = new System.Drawing.Size(339, 70);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passIconPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        public Guna.UI2.WinForms.Guna2PictureBox passIconPic;
        public Guna.UI2.WinForms.Guna2HtmlLabel usernameLbl;
        public Guna.UI2.WinForms.Guna2HtmlLabel titleLbl;
    }
}
