namespace PassWraith.Forms
{
    partial class AddCredential
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCredential));
            this.borderLessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.saveProgress = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblPasswordType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbPasswordType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNotes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtExpiryDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblExpiryDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPin = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCardNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCreditCardNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Seperator = new Guna.UI2.WinForms.Guna2Separator();
            this.txtWebsiteIconUrl = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtWebsiteUrl = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtWebsiteName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFormTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblWebsite = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblConfirmPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblWebsiteUrl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblWebsiteIconUrl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.mainPanelDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderLessForm
            // 
            this.borderLessForm.ContainerControl = this;
            this.borderLessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderLessForm.TransparentWhileDrag = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.saveProgress);
            this.mainPanel.Controls.Add(this.closeBtn);
            this.mainPanel.Controls.Add(this.lblId);
            this.mainPanel.Controls.Add(this.btnSave);
            this.mainPanel.Controls.Add(this.lblPasswordType);
            this.mainPanel.Controls.Add(this.cmbPasswordType);
            this.mainPanel.Controls.Add(this.txtNotes);
            this.mainPanel.Controls.Add(this.lblNotes);
            this.mainPanel.Controls.Add(this.Separator2);
            this.mainPanel.Controls.Add(this.txtExpiryDate);
            this.mainPanel.Controls.Add(this.lblExpiryDate);
            this.mainPanel.Controls.Add(this.txtPin);
            this.mainPanel.Controls.Add(this.lblPin);
            this.mainPanel.Controls.Add(this.txtCardNumber);
            this.mainPanel.Controls.Add(this.lblCreditCardNumber);
            this.mainPanel.Controls.Add(this.Seperator);
            this.mainPanel.Controls.Add(this.txtWebsiteIconUrl);
            this.mainPanel.Controls.Add(this.txtWebsiteUrl);
            this.mainPanel.Controls.Add(this.txtConfirmPassword);
            this.mainPanel.Controls.Add(this.txtPassword);
            this.mainPanel.Controls.Add(this.txtUsername);
            this.mainPanel.Controls.Add(this.txtWebsiteName);
            this.mainPanel.Controls.Add(this.lblFormTitle);
            this.mainPanel.Controls.Add(this.lblUsername);
            this.mainPanel.Controls.Add(this.lblWebsite);
            this.mainPanel.Controls.Add(this.lblPassword);
            this.mainPanel.Controls.Add(this.lblConfirmPassword);
            this.mainPanel.Controls.Add(this.lblWebsiteUrl);
            this.mainPanel.Controls.Add(this.lblWebsiteIconUrl);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1140, 625);
            this.mainPanel.TabIndex = 0;
            // 
            // saveProgress
            // 
            this.saveProgress.BackColor = System.Drawing.Color.Transparent;
            this.saveProgress.Location = new System.Drawing.Point(914, 497);
            this.saveProgress.Name = "saveProgress";
            this.saveProgress.ProgressColor = System.Drawing.Color.White;
            this.saveProgress.Size = new System.Drawing.Size(103, 99);
            this.saveProgress.TabIndex = 35;
            this.saveProgress.UseTransparentBackground = true;
            this.saveProgress.Visible = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FillColor = System.Drawing.Color.Transparent;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1095, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(45, 29);
            this.closeBtn.TabIndex = 34;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(848, 476);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(3, 2);
            this.lblId.TabIndex = 33;
            this.lblId.Text = null;
            this.lblId.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 2;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(93)))), ((int)(((byte)(220)))));
            this.btnSave.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(848, 497);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(229, 99);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblPasswordType
            // 
            this.lblPasswordType.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordType.Font = new System.Drawing.Font("Roboto Bk", 9F);
            this.lblPasswordType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.lblPasswordType.Location = new System.Drawing.Point(606, 251);
            this.lblPasswordType.Name = "lblPasswordType";
            this.lblPasswordType.Size = new System.Drawing.Size(86, 16);
            this.lblPasswordType.TabIndex = 31;
            this.lblPasswordType.Text = "Credential Type";
            // 
            // cmbPasswordType
            // 
            this.cmbPasswordType.BackColor = System.Drawing.Color.Transparent;
            this.cmbPasswordType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbPasswordType.BorderRadius = 2;
            this.cmbPasswordType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPasswordType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPasswordType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbPasswordType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPasswordType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPasswordType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPasswordType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbPasswordType.IntegralHeight = false;
            this.cmbPasswordType.ItemHeight = 28;
            this.cmbPasswordType.Location = new System.Drawing.Point(606, 271);
            this.cmbPasswordType.Name = "cmbPasswordType";
            this.cmbPasswordType.Size = new System.Drawing.Size(471, 34);
            this.cmbPasswordType.TabIndex = 30;
            // 
            // txtNotes
            // 
            this.txtNotes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNotes.BorderRadius = 2;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.ForeColor = System.Drawing.Color.White;
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Location = new System.Drawing.Point(60, 497);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(775, 99);
            this.txtNotes.TabIndex = 29;
            // 
            // lblNotes
            // 
            this.lblNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblNotes.Font = new System.Drawing.Font("Roboto Bk", 9F);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.lblNotes.Location = new System.Drawing.Point(60, 475);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(34, 16);
            this.lblNotes.TabIndex = 28;
            this.lblNotes.Text = "Notes";
            // 
            // Separator2
            // 
            this.Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Separator2.Location = new System.Drawing.Point(60, 450);
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(1017, 10);
            this.Separator2.TabIndex = 27;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExpiryDate.BorderRadius = 2;
            this.txtExpiryDate.BorderThickness = 1;
            this.txtExpiryDate.Checked = true;
            this.txtExpiryDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExpiryDate.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpiryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtExpiryDate.Location = new System.Drawing.Point(848, 387);
            this.txtExpiryDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtExpiryDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(229, 34);
            this.txtExpiryDate.TabIndex = 26;
            this.txtExpiryDate.Value = new System.DateTime(2023, 6, 23, 17, 44, 12, 10);
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.BackColor = System.Drawing.Color.Transparent;
            this.lblExpiryDate.Font = new System.Drawing.Font("Roboto Bk", 9F);
            this.lblExpiryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.lblExpiryDate.Location = new System.Drawing.Point(877, 365);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(63, 16);
            this.lblExpiryDate.TabIndex = 25;
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // txtPin
            // 
            this.txtPin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPin.BorderRadius = 2;
            this.txtPin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPin.DefaultText = "";
            this.txtPin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPin.ForeColor = System.Drawing.Color.White;
            this.txtPin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPin.Location = new System.Drawing.Point(606, 387);
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '●';
            this.txtPin.PlaceholderText = "";
            this.txtPin.SelectedText = "";
            this.txtPin.Size = new System.Drawing.Size(229, 34);
            this.txtPin.TabIndex = 24;
            this.txtPin.UseSystemPasswordChar = true;
            // 
            // lblPin
            // 
            this.lblPin.BackColor = System.Drawing.Color.Transparent;
            this.lblPin.Font = new System.Drawing.Font("Roboto Bk", 9F);
            this.lblPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.lblPin.Location = new System.Drawing.Point(606, 365);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(23, 16);
            this.lblPin.TabIndex = 23;
            this.lblPin.Text = "PIN";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCardNumber.BorderRadius = 2;
            this.txtCardNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCardNumber.DefaultText = "";
            this.txtCardNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCardNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCardNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCardNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCardNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCardNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCardNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCardNumber.ForeColor = System.Drawing.Color.White;
            this.txtCardNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCardNumber.Location = new System.Drawing.Point(60, 387);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.PasswordChar = '\0';
            this.txtCardNumber.PlaceholderText = "";
            this.txtCardNumber.SelectedText = "";
            this.txtCardNumber.Size = new System.Drawing.Size(471, 34);
            this.txtCardNumber.TabIndex = 22;
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblCreditCardNumber.Font = new System.Drawing.Font("Roboto Bk", 9F);
            this.lblCreditCardNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.lblCreditCardNumber.Location = new System.Drawing.Point(60, 365);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(73, 16);
            this.lblCreditCardNumber.TabIndex = 21;
            this.lblCreditCardNumber.Text = "Card Number";
            // 
            // Seperator
            // 
            this.Seperator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Seperator.Location = new System.Drawing.Point(60, 337);
            this.Seperator.Name = "Seperator";
            this.Seperator.Size = new System.Drawing.Size(1017, 10);
            this.Seperator.TabIndex = 20;
            // 
            // txtWebsiteIconUrl
            // 
            this.txtWebsiteIconUrl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWebsiteIconUrl.BorderRadius = 2;
            this.txtWebsiteIconUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWebsiteIconUrl.DefaultText = "";
            this.txtWebsiteIconUrl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWebsiteIconUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWebsiteIconUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWebsiteIconUrl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWebsiteIconUrl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWebsiteIconUrl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWebsiteIconUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWebsiteIconUrl.ForeColor = System.Drawing.Color.White;
            this.txtWebsiteIconUrl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWebsiteIconUrl.Location = new System.Drawing.Point(302, 273);
            this.txtWebsiteIconUrl.Name = "txtWebsiteIconUrl";
            this.txtWebsiteIconUrl.PasswordChar = '\0';
            this.txtWebsiteIconUrl.PlaceholderText = "";
            this.txtWebsiteIconUrl.SelectedText = "";
            this.txtWebsiteIconUrl.Size = new System.Drawing.Size(229, 34);
            this.txtWebsiteIconUrl.TabIndex = 19;
            // 
            // txtWebsiteUrl
            // 
            this.txtWebsiteUrl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWebsiteUrl.BorderRadius = 2;
            this.txtWebsiteUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWebsiteUrl.DefaultText = "";
            this.txtWebsiteUrl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWebsiteUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWebsiteUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWebsiteUrl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWebsiteUrl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWebsiteUrl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWebsiteUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWebsiteUrl.ForeColor = System.Drawing.Color.White;
            this.txtWebsiteUrl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWebsiteUrl.Location = new System.Drawing.Point(60, 273);
            this.txtWebsiteUrl.Name = "txtWebsiteUrl";
            this.txtWebsiteUrl.PasswordChar = '\0';
            this.txtWebsiteUrl.PlaceholderText = "";
            this.txtWebsiteUrl.SelectedText = "";
            this.txtWebsiteUrl.Size = new System.Drawing.Size(229, 34);
            this.txtWebsiteUrl.TabIndex = 18;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.BorderRadius = 2;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(606, 188);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(471, 34);
            this.txtConfirmPassword.TabIndex = 17;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderRadius = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(60, 188);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(471, 34);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.BorderRadius = 2;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(60, 103);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(471, 34);
            this.txtUsername.TabIndex = 15;
            // 
            // txtWebsiteName
            // 
            this.txtWebsiteName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWebsiteName.BorderRadius = 2;
            this.txtWebsiteName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWebsiteName.DefaultText = "";
            this.txtWebsiteName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWebsiteName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWebsiteName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWebsiteName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWebsiteName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWebsiteName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWebsiteName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWebsiteName.ForeColor = System.Drawing.Color.White;
            this.txtWebsiteName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWebsiteName.Location = new System.Drawing.Point(606, 103);
            this.txtWebsiteName.Name = "txtWebsiteName";
            this.txtWebsiteName.PasswordChar = '\0';
            this.txtWebsiteName.PlaceholderText = "";
            this.txtWebsiteName.SelectedText = "";
            this.txtWebsiteName.Size = new System.Drawing.Size(471, 34);
            this.txtWebsiteName.TabIndex = 14;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFormTitle.Location = new System.Drawing.Point(60, 25);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(194, 31);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "ADD CREDENTIAL";
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Roboto Bk", 9F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.lblUsername.Location = new System.Drawing.Point(60, 81);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(56, 16);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblWebsite
            // 
            this.lblWebsite.BackColor = System.Drawing.Color.Transparent;
            this.lblWebsite.Font = new System.Drawing.Font("Roboto Bk", 9F);
            this.lblWebsite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.lblWebsite.Location = new System.Drawing.Point(606, 81);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(46, 16);
            this.lblWebsite.TabIndex = 4;
            this.lblWebsite.Text = "Website";
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Roboto Bk", 9F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.lblPassword.Location = new System.Drawing.Point(60, 166);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 16);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Roboto Bk", 9F);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(606, 166);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(102, 16);
            this.lblConfirmPassword.TabIndex = 8;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblWebsiteUrl
            // 
            this.lblWebsiteUrl.BackColor = System.Drawing.Color.Transparent;
            this.lblWebsiteUrl.Font = new System.Drawing.Font("Roboto Bk", 9F);
            this.lblWebsiteUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.lblWebsiteUrl.Location = new System.Drawing.Point(60, 251);
            this.lblWebsiteUrl.Name = "lblWebsiteUrl";
            this.lblWebsiteUrl.Size = new System.Drawing.Size(72, 16);
            this.lblWebsiteUrl.TabIndex = 10;
            this.lblWebsiteUrl.Text = "Website URL";
            // 
            // lblWebsiteIconUrl
            // 
            this.lblWebsiteIconUrl.BackColor = System.Drawing.Color.Transparent;
            this.lblWebsiteIconUrl.Font = new System.Drawing.Font("Roboto Bk", 9F);
            this.lblWebsiteIconUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.lblWebsiteIconUrl.Location = new System.Drawing.Point(302, 251);
            this.lblWebsiteIconUrl.Name = "lblWebsiteIconUrl";
            this.lblWebsiteIconUrl.Size = new System.Drawing.Size(99, 16);
            this.lblWebsiteIconUrl.TabIndex = 12;
            this.lblWebsiteIconUrl.Text = "Website Icon URL";
            // 
            // mainPanelDrag
            // 
            this.mainPanelDrag.DockIndicatorTransparencyValue = 0.6D;
            this.mainPanelDrag.TargetControl = this.mainPanel;
            this.mainPanelDrag.UseTransparentDrag = true;
            // 
            // AddCredential
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1140, 625);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCredential";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCredential";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borderLessForm;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFormTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWebsite;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblConfirmPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWebsiteUrl;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWebsiteIconUrl;
        private Guna.UI2.WinForms.Guna2DragControl mainPanelDrag;
        private Guna.UI2.WinForms.Guna2TextBox txtWebsiteIconUrl;
        private Guna.UI2.WinForms.Guna2TextBox txtWebsiteUrl;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtWebsiteName;
        private Guna.UI2.WinForms.Guna2Separator Seperator;
        private Guna.UI2.WinForms.Guna2TextBox txtCardNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCreditCardNumber;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtExpiryDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblExpiryDate;
        private Guna.UI2.WinForms.Guna2TextBox txtPin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPin;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNotes;
        private Guna.UI2.WinForms.Guna2Separator Separator2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPasswordType;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPasswordType;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblId;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator saveProgress;
    }
}