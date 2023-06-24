using Guna.UI2.WinForms;
using PassWraith.Controls.MouseEvents;
using PassWraith.Dependencies;

namespace PassWraith
{

    partial class PassWraith
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassWraith));
            this.leftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.midPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.mainFormBorderLess = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.leftDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.midDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.rightDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.rightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNotes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.dispWebsitePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dispLblWebsiteName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dispLblWebsiteTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dispPasswordPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dispTxtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.dispLblPasswordTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dispUsernamePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dispLblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dispLblUsernameTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.displayPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Seperator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblDisplayUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDisplayWebsiteName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flpMainDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gunaToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.editBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dispBtnWebsiteCopy = new Guna.UI2.WinForms.Guna2Button();
            this.dispBtnPasswordView = new Guna.UI2.WinForms.Guna2Button();
            this.dispBtnPasswordCopy = new Guna.UI2.WinForms.Guna2Button();
            this.dispBtnUsernameCopy = new Guna.UI2.WinForms.Guna2Button();
            this.starPicBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.displayPicBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTrash = new Guna.UI2.WinForms.Guna2Button();
            this.btnFavourites = new Guna.UI2.WinForms.Guna2Button();
            this.allItemsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.leftPanel.SuspendLayout();
            this.midPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.dispWebsitePanel.SuspendLayout();
            this.dispPasswordPanel.SuspendLayout();
            this.dispUsernamePanel.SuspendLayout();
            this.displayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.starPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.leftPanel.Controls.Add(this.btnTrash);
            this.leftPanel.Controls.Add(this.btnFavourites);
            this.leftPanel.Controls.Add(this.allItemsBtn);
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(255, 625);
            this.leftPanel.TabIndex = 0;
            // 
            // midPanel
            // 
            this.midPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.midPanel.Controls.Add(this.addBtn);
            this.midPanel.Controls.Add(this.searchBox);
            this.midPanel.Controls.Add(this.flpMain);
            this.midPanel.Location = new System.Drawing.Point(255, -1);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(375, 625);
            this.midPanel.TabIndex = 1;
            // 
            // flpMain
            // 
            this.flpMain.AutoScroll = true;
            this.flpMain.Location = new System.Drawing.Point(15, 76);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(399, 570);
            this.flpMain.TabIndex = 0;
            // 
            // mainFormBorderLess
            // 
            this.mainFormBorderLess.BorderRadius = 8;
            this.mainFormBorderLess.ContainerControl = this;
            this.mainFormBorderLess.DockIndicatorTransparencyValue = 0.6D;
            this.mainFormBorderLess.ShadowColor = System.Drawing.Color.DimGray;
            this.mainFormBorderLess.TransparentWhileDrag = true;
            // 
            // leftDrag
            // 
            this.leftDrag.DockIndicatorTransparencyValue = 0.6D;
            this.leftDrag.TargetControl = this.leftPanel;
            this.leftDrag.UseTransparentDrag = true;
            // 
            // midDrag
            // 
            this.midDrag.DockIndicatorTransparencyValue = 0.6D;
            this.midDrag.TargetControl = this.midPanel;
            this.midDrag.UseTransparentDrag = true;
            // 
            // rightDrag
            // 
            this.rightDrag.DockIndicatorTransparencyValue = 0.6D;
            this.rightDrag.TargetControl = this.rightPanel;
            this.rightDrag.UseTransparentDrag = true;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rightPanel.Controls.Add(this.editBtn);
            this.rightPanel.Controls.Add(this.guna2Panel1);
            this.rightPanel.Controls.Add(this.Separator2);
            this.rightPanel.Controls.Add(this.dispWebsitePanel);
            this.rightPanel.Controls.Add(this.dispPasswordPanel);
            this.rightPanel.Controls.Add(this.dispUsernamePanel);
            this.rightPanel.Controls.Add(this.displayPanel);
            this.rightPanel.Location = new System.Drawing.Point(630, -1);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(512, 625);
            this.rightPanel.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txtNotes);
            this.guna2Panel1.Controls.Add(this.lblNotes);
            this.guna2Panel1.Location = new System.Drawing.Point(45, 430);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(422, 184);
            this.guna2Panel1.TabIndex = 5;
            // 
            // txtNotes
            // 
            this.txtNotes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = resources.GetString("txtNotes.DefaultText");
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtNotes.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtNotes.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.Color.White;
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtNotes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtNotes.Location = new System.Drawing.Point(0, 22);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(422, 162);
            this.txtNotes.TabIndex = 5;
            this.txtNotes.TextOffset = new System.Drawing.Point(-9, -8);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = false;
            this.lblNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblNotes.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblNotes.Location = new System.Drawing.Point(2, 2);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(252, 16);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notes";
            // 
            // Separator2
            // 
            this.Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Separator2.Location = new System.Drawing.Point(45, 401);
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(422, 10);
            this.Separator2.TabIndex = 4;
            // 
            // dispWebsitePanel
            // 
            this.dispWebsitePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dispWebsitePanel.BorderRadius = 4;
            this.dispWebsitePanel.Controls.Add(this.dispBtnWebsiteCopy);
            this.dispWebsitePanel.Controls.Add(this.dispLblWebsiteName);
            this.dispWebsitePanel.Controls.Add(this.dispLblWebsiteTitle);
            this.dispWebsitePanel.Location = new System.Drawing.Point(45, 318);
            this.dispWebsitePanel.Name = "dispWebsitePanel";
            this.dispWebsitePanel.Size = new System.Drawing.Size(422, 60);
            this.dispWebsitePanel.TabIndex = 3;
            // 
            // dispLblWebsiteName
            // 
            this.dispLblWebsiteName.AutoSize = false;
            this.dispLblWebsiteName.BackColor = System.Drawing.Color.Transparent;
            this.dispLblWebsiteName.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispLblWebsiteName.ForeColor = System.Drawing.Color.White;
            this.dispLblWebsiteName.Location = new System.Drawing.Point(7, 34);
            this.dispLblWebsiteName.Name = "dispLblWebsiteName";
            this.dispLblWebsiteName.Size = new System.Drawing.Size(344, 15);
            this.dispLblWebsiteName.TabIndex = 4;
            this.dispLblWebsiteName.Text = "shade.ga";
            // 
            // dispLblWebsiteTitle
            // 
            this.dispLblWebsiteTitle.AutoSize = false;
            this.dispLblWebsiteTitle.BackColor = System.Drawing.Color.Transparent;
            this.dispLblWebsiteTitle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispLblWebsiteTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.dispLblWebsiteTitle.Location = new System.Drawing.Point(7, 12);
            this.dispLblWebsiteTitle.Name = "dispLblWebsiteTitle";
            this.dispLblWebsiteTitle.Size = new System.Drawing.Size(252, 16);
            this.dispLblWebsiteTitle.TabIndex = 3;
            this.dispLblWebsiteTitle.Text = "Website";
            // 
            // dispPasswordPanel
            // 
            this.dispPasswordPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dispPasswordPanel.BorderRadius = 4;
            this.dispPasswordPanel.Controls.Add(this.dispTxtPassword);
            this.dispPasswordPanel.Controls.Add(this.dispBtnPasswordView);
            this.dispPasswordPanel.Controls.Add(this.dispBtnPasswordCopy);
            this.dispPasswordPanel.Controls.Add(this.dispLblPasswordTitle);
            this.dispPasswordPanel.Location = new System.Drawing.Point(45, 252);
            this.dispPasswordPanel.Name = "dispPasswordPanel";
            this.dispPasswordPanel.Size = new System.Drawing.Size(422, 60);
            this.dispPasswordPanel.TabIndex = 2;
            // 
            // dispTxtPassword
            // 
            this.dispTxtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dispTxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dispTxtPassword.DefaultText = "password";
            this.dispTxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dispTxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dispTxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dispTxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dispTxtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dispTxtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dispTxtPassword.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
            this.dispTxtPassword.ForeColor = System.Drawing.Color.White;
            this.dispTxtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dispTxtPassword.Location = new System.Drawing.Point(0, 33);
            this.dispTxtPassword.Name = "dispTxtPassword";
            this.dispTxtPassword.PasswordChar = '●';
            this.dispTxtPassword.PlaceholderText = "";
            this.dispTxtPassword.SelectedText = "";
            this.dispTxtPassword.Size = new System.Drawing.Size(343, 16);
            this.dispTxtPassword.TabIndex = 7;
            this.dispTxtPassword.UseSystemPasswordChar = true;
            // 
            // dispLblPasswordTitle
            // 
            this.dispLblPasswordTitle.AutoSize = false;
            this.dispLblPasswordTitle.BackColor = System.Drawing.Color.Transparent;
            this.dispLblPasswordTitle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispLblPasswordTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.dispLblPasswordTitle.Location = new System.Drawing.Point(7, 12);
            this.dispLblPasswordTitle.Name = "dispLblPasswordTitle";
            this.dispLblPasswordTitle.Size = new System.Drawing.Size(252, 16);
            this.dispLblPasswordTitle.TabIndex = 3;
            this.dispLblPasswordTitle.Text = "Password";
            // 
            // dispUsernamePanel
            // 
            this.dispUsernamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dispUsernamePanel.BorderRadius = 4;
            this.dispUsernamePanel.Controls.Add(this.dispBtnUsernameCopy);
            this.dispUsernamePanel.Controls.Add(this.dispLblUsername);
            this.dispUsernamePanel.Controls.Add(this.dispLblUsernameTitle);
            this.dispUsernamePanel.Location = new System.Drawing.Point(45, 186);
            this.dispUsernamePanel.Name = "dispUsernamePanel";
            this.dispUsernamePanel.Size = new System.Drawing.Size(422, 60);
            this.dispUsernamePanel.TabIndex = 1;
            // 
            // dispLblUsername
            // 
            this.dispLblUsername.AutoSize = false;
            this.dispLblUsername.BackColor = System.Drawing.Color.Transparent;
            this.dispLblUsername.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispLblUsername.ForeColor = System.Drawing.Color.White;
            this.dispLblUsername.Location = new System.Drawing.Point(7, 34);
            this.dispLblUsername.Name = "dispLblUsername";
            this.dispLblUsername.Size = new System.Drawing.Size(344, 15);
            this.dispLblUsername.TabIndex = 4;
            this.dispLblUsername.Text = "shade@shade.ga";
            // 
            // dispLblUsernameTitle
            // 
            this.dispLblUsernameTitle.AutoSize = false;
            this.dispLblUsernameTitle.BackColor = System.Drawing.Color.Transparent;
            this.dispLblUsernameTitle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispLblUsernameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.dispLblUsernameTitle.Location = new System.Drawing.Point(7, 12);
            this.dispLblUsernameTitle.Name = "dispLblUsernameTitle";
            this.dispLblUsernameTitle.Size = new System.Drawing.Size(252, 16);
            this.dispLblUsernameTitle.TabIndex = 3;
            this.dispLblUsernameTitle.Text = "Username";
            // 
            // displayPanel
            // 
            this.displayPanel.BackColor = System.Drawing.Color.Transparent;
            this.displayPanel.Controls.Add(this.Seperator1);
            this.displayPanel.Controls.Add(this.starPicBox);
            this.displayPanel.Controls.Add(this.lblDisplayUserName);
            this.displayPanel.Controls.Add(this.lblDisplayWebsiteName);
            this.displayPanel.Controls.Add(this.displayPicBox);
            this.displayPanel.Location = new System.Drawing.Point(45, 80);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(422, 80);
            this.displayPanel.TabIndex = 0;
            // 
            // Seperator1
            // 
            this.Seperator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Seperator1.Location = new System.Drawing.Point(0, 72);
            this.Seperator1.Name = "Seperator1";
            this.Seperator1.Size = new System.Drawing.Size(422, 10);
            this.Seperator1.TabIndex = 1;
            // 
            // lblDisplayUserName
            // 
            this.lblDisplayUserName.AutoSize = false;
            this.lblDisplayUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayUserName.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblDisplayUserName.Location = new System.Drawing.Point(83, 36);
            this.lblDisplayUserName.Name = "lblDisplayUserName";
            this.lblDisplayUserName.Size = new System.Drawing.Size(252, 16);
            this.lblDisplayUserName.TabIndex = 2;
            this.lblDisplayUserName.Text = "Login";
            // 
            // lblDisplayWebsiteName
            // 
            this.lblDisplayWebsiteName.AutoSize = false;
            this.lblDisplayWebsiteName.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayWebsiteName.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayWebsiteName.ForeColor = System.Drawing.Color.White;
            this.lblDisplayWebsiteName.Location = new System.Drawing.Point(83, 4);
            this.lblDisplayWebsiteName.Name = "lblDisplayWebsiteName";
            this.lblDisplayWebsiteName.Size = new System.Drawing.Size(252, 27);
            this.lblDisplayWebsiteName.TabIndex = 1;
            this.lblDisplayWebsiteName.Text = "Adobe";
            // 
            // flpMainDrag
            // 
            this.flpMainDrag.DockIndicatorTransparencyValue = 0.6D;
            this.flpMainDrag.TargetControl = this.flpMain;
            this.flpMainDrag.UseTransparentDrag = true;
            // 
            // gunaToolTip
            // 
            this.gunaToolTip.AllowLinksHandling = true;
            this.gunaToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.gunaToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.gunaToolTip.ToolTipTitle = "Expiry Date";
            // 
            // editBtn
            // 
            this.editBtn.BorderRadius = 2;
            this.editBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.editBtn.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.editBtn.Image = global::PassWraith.Properties.Resources.icons8_edit_24px;
            this.editBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.editBtn.Location = new System.Drawing.Point(45, 30);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(68, 24);
            this.editBtn.TabIndex = 7;
            this.editBtn.Text = "Edit";
            // 
            // dispBtnWebsiteCopy
            // 
            this.dispBtnWebsiteCopy.BackColor = System.Drawing.Color.Transparent;
            this.dispBtnWebsiteCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dispBtnWebsiteCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dispBtnWebsiteCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dispBtnWebsiteCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dispBtnWebsiteCopy.FillColor = System.Drawing.Color.Transparent;
            this.dispBtnWebsiteCopy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dispBtnWebsiteCopy.ForeColor = System.Drawing.Color.White;
            this.dispBtnWebsiteCopy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dispBtnWebsiteCopy.Image = global::PassWraith.Properties.Resources.icons8_clone_figure_24px;
            this.dispBtnWebsiteCopy.ImageSize = new System.Drawing.Size(18, 18);
            this.dispBtnWebsiteCopy.Location = new System.Drawing.Point(387, 20);
            this.dispBtnWebsiteCopy.Name = "dispBtnWebsiteCopy";
            this.dispBtnWebsiteCopy.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dispBtnWebsiteCopy.Size = new System.Drawing.Size(20, 20);
            this.dispBtnWebsiteCopy.TabIndex = 5;
            this.dispBtnWebsiteCopy.Tag = "Copy";
            this.dispBtnWebsiteCopy.Visible = false;
            // 
            // dispBtnPasswordView
            // 
            this.dispBtnPasswordView.BackColor = System.Drawing.Color.Transparent;
            this.dispBtnPasswordView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dispBtnPasswordView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dispBtnPasswordView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dispBtnPasswordView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dispBtnPasswordView.FillColor = System.Drawing.Color.Transparent;
            this.dispBtnPasswordView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dispBtnPasswordView.ForeColor = System.Drawing.Color.White;
            this.dispBtnPasswordView.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dispBtnPasswordView.Image = global::PassWraith.Properties.Resources.icons8_eye_24px;
            this.dispBtnPasswordView.ImageSize = new System.Drawing.Size(18, 18);
            this.dispBtnPasswordView.Location = new System.Drawing.Point(358, 22);
            this.dispBtnPasswordView.Name = "dispBtnPasswordView";
            this.dispBtnPasswordView.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dispBtnPasswordView.Size = new System.Drawing.Size(20, 20);
            this.dispBtnPasswordView.TabIndex = 6;
            this.dispBtnPasswordView.Tag = "View";
            this.dispBtnPasswordView.Visible = false;
            // 
            // dispBtnPasswordCopy
            // 
            this.dispBtnPasswordCopy.BackColor = System.Drawing.Color.Transparent;
            this.dispBtnPasswordCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dispBtnPasswordCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dispBtnPasswordCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dispBtnPasswordCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dispBtnPasswordCopy.FillColor = System.Drawing.Color.Transparent;
            this.dispBtnPasswordCopy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dispBtnPasswordCopy.ForeColor = System.Drawing.Color.White;
            this.dispBtnPasswordCopy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dispBtnPasswordCopy.Image = global::PassWraith.Properties.Resources.icons8_clone_figure_24px;
            this.dispBtnPasswordCopy.ImageSize = new System.Drawing.Size(18, 18);
            this.dispBtnPasswordCopy.Location = new System.Drawing.Point(387, 22);
            this.dispBtnPasswordCopy.Name = "dispBtnPasswordCopy";
            this.dispBtnPasswordCopy.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dispBtnPasswordCopy.Size = new System.Drawing.Size(20, 20);
            this.dispBtnPasswordCopy.TabIndex = 5;
            this.dispBtnPasswordCopy.Tag = "Copy";
            this.dispBtnPasswordCopy.Visible = false;
            // 
            // dispBtnUsernameCopy
            // 
            this.dispBtnUsernameCopy.BackColor = System.Drawing.Color.Transparent;
            this.dispBtnUsernameCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dispBtnUsernameCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dispBtnUsernameCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dispBtnUsernameCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dispBtnUsernameCopy.FillColor = System.Drawing.Color.Transparent;
            this.dispBtnUsernameCopy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dispBtnUsernameCopy.ForeColor = System.Drawing.Color.White;
            this.dispBtnUsernameCopy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dispBtnUsernameCopy.Image = global::PassWraith.Properties.Resources.icons8_clone_figure_24px;
            this.dispBtnUsernameCopy.ImageSize = new System.Drawing.Size(18, 18);
            this.dispBtnUsernameCopy.Location = new System.Drawing.Point(387, 20);
            this.dispBtnUsernameCopy.Name = "dispBtnUsernameCopy";
            this.dispBtnUsernameCopy.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dispBtnUsernameCopy.Size = new System.Drawing.Size(20, 20);
            this.dispBtnUsernameCopy.TabIndex = 5;
            this.dispBtnUsernameCopy.Tag = "Copy";
            this.dispBtnUsernameCopy.Visible = false;
            // 
            // starPicBox
            // 
            this.starPicBox.FillColor = System.Drawing.Color.Transparent;
            this.starPicBox.Image = global::PassWraith.Properties.Resources.icons8_star_60px;
            this.starPicBox.ImageRotate = 0F;
            this.starPicBox.Location = new System.Drawing.Point(376, 15);
            this.starPicBox.Name = "starPicBox";
            this.starPicBox.Size = new System.Drawing.Size(25, 25);
            this.starPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.starPicBox.TabIndex = 3;
            this.starPicBox.TabStop = false;
            // 
            // displayPicBox
            // 
            this.displayPicBox.BorderRadius = 2;
            this.displayPicBox.FillColor = System.Drawing.Color.Transparent;
            this.displayPicBox.Image = global::PassWraith.Properties.Resources.icons8_adobe_photoshop_96px;
            this.displayPicBox.ImageRotate = 0F;
            this.displayPicBox.Location = new System.Drawing.Point(7, 0);
            this.displayPicBox.Name = "displayPicBox";
            this.displayPicBox.Size = new System.Drawing.Size(60, 60);
            this.displayPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.displayPicBox.TabIndex = 0;
            this.displayPicBox.TabStop = false;
            // 
            // addBtn
            // 
            this.addBtn.BorderRadius = 2;
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(93)))), ((int)(((byte)(220)))));
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Image = global::PassWraith.Properties.Resources.icons8_plus_math_30px;
            this.addBtn.ImageSize = new System.Drawing.Size(18, 18);
            this.addBtn.Location = new System.Drawing.Point(324, 22);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(33, 32);
            this.addBtn.TabIndex = 2;
            this.addBtn.Tag = "AddButton";
            // 
            // searchBox
            // 
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBox.BorderRadius = 4;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.IconLeft = global::PassWraith.Properties.Resources.icons8_search_24px;
            this.searchBox.Location = new System.Drawing.Point(15, 22);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.searchBox.PlaceholderText = "Search Vault";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(292, 32);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnTrash
            // 
            this.btnTrash.Animated = true;
            this.btnTrash.BackColor = System.Drawing.Color.Transparent;
            this.btnTrash.BorderRadius = 4;
            this.btnTrash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrash.FillColor = System.Drawing.Color.Transparent;
            this.btnTrash.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTrash.ForeColor = System.Drawing.Color.White;
            this.btnTrash.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(93)))), ((int)(((byte)(220)))));
            this.btnTrash.Image = global::PassWraith.Properties.Resources.icons8_Bin_Windows_48px;
            this.btnTrash.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrash.Location = new System.Drawing.Point(14, 146);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(225, 35);
            this.btnTrash.TabIndex = 2;
            this.btnTrash.Text = "Trash";
            this.btnTrash.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnFavourites
            // 
            this.btnFavourites.Animated = true;
            this.btnFavourites.BackColor = System.Drawing.Color.Transparent;
            this.btnFavourites.BorderRadius = 4;
            this.btnFavourites.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFavourites.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFavourites.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFavourites.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFavourites.FillColor = System.Drawing.Color.Transparent;
            this.btnFavourites.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFavourites.ForeColor = System.Drawing.Color.White;
            this.btnFavourites.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(93)))), ((int)(((byte)(220)))));
            this.btnFavourites.Image = global::PassWraith.Properties.Resources.icons8_star_480px;
            this.btnFavourites.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFavourites.Location = new System.Drawing.Point(13, 105);
            this.btnFavourites.Name = "btnFavourites";
            this.btnFavourites.Size = new System.Drawing.Size(225, 35);
            this.btnFavourites.TabIndex = 1;
            this.btnFavourites.Text = "Favourites";
            this.btnFavourites.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // allItemsBtn
            // 
            this.allItemsBtn.Animated = true;
            this.allItemsBtn.BackColor = System.Drawing.Color.Transparent;
            this.allItemsBtn.BorderRadius = 4;
            this.allItemsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.allItemsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.allItemsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.allItemsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.allItemsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(93)))), ((int)(((byte)(220)))));
            this.allItemsBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.allItemsBtn.ForeColor = System.Drawing.Color.White;
            this.allItemsBtn.Image = global::PassWraith.Properties.Resources.icons8_Security_Shield_Green_512px;
            this.allItemsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.allItemsBtn.Location = new System.Drawing.Point(14, 64);
            this.allItemsBtn.Name = "allItemsBtn";
            this.allItemsBtn.Size = new System.Drawing.Size(225, 35);
            this.allItemsBtn.TabIndex = 0;
            this.allItemsBtn.Text = "All Items";
            this.allItemsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PassWraith
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1140, 625);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PassWraith";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassWraith";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.PassWraith_Load);
            this.leftPanel.ResumeLayout(false);
            this.midPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.dispWebsitePanel.ResumeLayout(false);
            this.dispPasswordPanel.ResumeLayout(false);
            this.dispUsernamePanel.ResumeLayout(false);
            this.displayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.starPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayPicBox)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        public  Guna.UI2.WinForms.Guna2Panel leftPanel;
        public Guna.UI2.WinForms.Guna2Panel midPanel;
        public Guna.UI2.WinForms.Guna2Panel rightPanel;
        public Guna.UI2.WinForms.Guna2BorderlessForm mainFormBorderLess;
        public Guna.UI2.WinForms.Guna2DragControl leftDrag;
        public Guna.UI2.WinForms.Guna2DragControl midDrag;
        public Guna.UI2.WinForms.Guna2DragControl rightDrag;
        public System.Windows.Forms.FlowLayoutPanel flpMain;
        public Guna.UI2.WinForms.Guna2Button allItemsBtn;
        public Guna.UI2.WinForms.Guna2Button btnFavourites;
        public Guna.UI2.WinForms.Guna2Button btnTrash;
        public Guna.UI2.WinForms.Guna2DragControl flpMainDrag;
        public Guna.UI2.WinForms.Guna2TextBox searchBox;
        public Guna.UI2.WinForms.Guna2Button addBtn;
        public Guna.UI2.WinForms.Guna2Panel displayPanel;
        public Guna.UI2.WinForms.Guna2PictureBox displayPicBox;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblDisplayUserName;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblDisplayWebsiteName;
        public Guna.UI2.WinForms.Guna2PictureBox starPicBox;
        public Guna.UI2.WinForms.Guna2Separator Seperator1;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblNotes;
        public Guna.UI2.WinForms.Guna2Separator Separator2;
        public Guna.UI2.WinForms.Guna2TextBox txtNotes;
        public Guna.UI2.WinForms.Guna2Panel dispUsernamePanel;
        public Guna.UI2.WinForms.Guna2HtmlLabel dispLblUsername;
        public Guna.UI2.WinForms.Guna2HtmlLabel dispLblUsernameTitle;
        public Guna.UI2.WinForms.Guna2Button dispBtnUsernameCopy;
        public Guna.UI2.WinForms.Guna2Panel dispPasswordPanel;
        public Guna.UI2.WinForms.Guna2Button dispBtnPasswordCopy;
        public Guna.UI2.WinForms.Guna2HtmlLabel dispLblPasswordTitle;
        public Guna.UI2.WinForms.Guna2Button dispBtnPasswordView;
        public Guna.UI2.WinForms.Guna2TextBox dispTxtPassword;
        public Guna.UI2.WinForms.Guna2Panel dispWebsitePanel;
        public Guna.UI2.WinForms.Guna2Button dispBtnWebsiteCopy;
        public Guna.UI2.WinForms.Guna2HtmlLabel dispLblWebsiteName;
        public Guna.UI2.WinForms.Guna2HtmlLabel dispLblWebsiteTitle;
        public Guna.UI2.WinForms.Guna2HtmlToolTip gunaToolTip;
        public Guna.UI2.WinForms.Guna2Button editBtn;

        public PasswraithDependencies BuildDependencides()
        {
            return new PasswraithDependencies
            {
                DispUsernamePanel = this.dispUsernamePanel,
                DispPasswordPanel = this.dispPasswordPanel,
                DispWebsitePanel = this.dispWebsitePanel,
                DispBtnUsernameCopy = this.dispBtnUsernameCopy,
                DispBtnPasswordView = this.dispBtnPasswordView,
                DispBtnPasswordCopy = this.dispBtnPasswordCopy,
                DispBtnWebsiteCopy = this.dispBtnWebsiteCopy,
                DispTxtPassword = this.dispTxtPassword,
                DispLblUsername = this.dispLblUsername,
                DispLblWebsiteName = this.dispLblWebsiteName,
                FlpMain = this.flpMain,
                LblDisplayUserName = this.lblDisplayUserName,
                LblDisplayWebsiteName = this.lblDisplayWebsiteName,
                DisplayPicBox = this.displayPicBox,
                AddBtn = this.addBtn,
                EditBtn = this.editBtn,
                DispLblUsernameTitle = this.dispLblUsernameTitle,
                DispLblPasswordTitle = this.dispLblPasswordTitle,
                DispLblWebsiteTitle = this.dispLblWebsiteTitle,
                TxtNotes = this.txtNotes,
                GunaToolTip = this.gunaToolTip,
                StarPicBox = this.starPicBox,
                LeftPanel = this.leftPanel,
                MidPanel = this.midPanel,
                RightPanel = this.rightPanel,
                MainFormBorderLess = this.mainFormBorderLess,
                LeftDrag = this.leftDrag,
                MidDrag = this.midDrag,
                RightDrag = this.rightDrag,
                FlpMainDrag = this.flpMainDrag,
                SearchBox = this.searchBox,
                DisplayPanel = this.displayPanel,
                Separator1 = this.Seperator1,
                Guna2Panel1 = this.guna2Panel1,
                LblNotes = this.lblNotes,
                Separator2 = this.Separator2
            };
        }
    }
}

