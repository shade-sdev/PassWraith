namespace PassWraith.Forms
{
    partial class Import
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
            this.gblf = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ImportBtn = new Guna.UI2.WinForms.Guna2Button();
            this.checkBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uploadPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.uploadPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainPanelDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.mainPanel.SuspendLayout();
            this.uploadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPic)).BeginInit();
            this.SuspendLayout();
            // 
            // gblf
            // 
            this.gblf.BorderRadius = 2;
            this.gblf.ContainerControl = this;
            this.gblf.DockIndicatorTransparencyValue = 0.6D;
            this.gblf.TransparentWhileDrag = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(230, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 20);
            this.btnClose.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.AllowDrop = true;
            this.mainPanel.Controls.Add(this.ImportBtn);
            this.mainPanel.Controls.Add(this.checkBox);
            this.mainPanel.Controls.Add(this.lblTitle);
            this.mainPanel.Controls.Add(this.uploadPanel);
            this.mainPanel.Controls.Add(this.btnClose);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(261, 332);
            this.mainPanel.TabIndex = 1;
            // 
            // ImportBtn
            // 
            this.ImportBtn.BackColor = System.Drawing.Color.Transparent;
            this.ImportBtn.BorderRadius = 2;
            this.ImportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ImportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ImportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ImportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ImportBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ImportBtn.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportBtn.ForeColor = System.Drawing.Color.White;
            this.ImportBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ImportBtn.Image = global::PassWraith.Properties.Resources.icons8_import_30px;
            this.ImportBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.ImportBtn.Location = new System.Drawing.Point(31, 296);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(200, 24);
            this.ImportBtn.TabIndex = 9;
            this.ImportBtn.Text = "Import";
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.Transparent;
            this.checkBox.Checked = true;
            this.checkBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox.CheckedState.BorderRadius = 0;
            this.checkBox.CheckedState.BorderThickness = 0;
            this.checkBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.ForeColor = System.Drawing.Color.White;
            this.checkBox.Location = new System.Drawing.Point(31, 257);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(65, 17);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "Chrome";
            this.checkBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox.UncheckedState.BorderRadius = 0;
            this.checkBox.UncheckedState.BorderThickness = 0;
            this.checkBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Russo One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(98, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 16);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Import CSV";
            // 
            // uploadPanel
            // 
            this.uploadPanel.AllowDrop = true;
            this.uploadPanel.BackColor = System.Drawing.Color.Transparent;
            this.uploadPanel.BorderColor = System.Drawing.Color.White;
            this.uploadPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.uploadPanel.BorderThickness = 2;
            this.uploadPanel.Controls.Add(this.uploadPic);
            this.uploadPanel.Location = new System.Drawing.Point(31, 61);
            this.uploadPanel.Name = "uploadPanel";
            this.uploadPanel.Size = new System.Drawing.Size(200, 175);
            this.uploadPanel.TabIndex = 1;
            this.uploadPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.UploadPanel_DragEnter);
            // 
            // uploadPic
            // 
            this.uploadPic.BorderRadius = 2;
            this.uploadPic.FillColor = System.Drawing.Color.Transparent;
            this.uploadPic.Image = global::PassWraith.Properties.Resources.icons8_upload_60px;
            this.uploadPic.ImageRotate = 0F;
            this.uploadPic.Location = new System.Drawing.Point(67, 58);
            this.uploadPic.Name = "uploadPic";
            this.uploadPic.Size = new System.Drawing.Size(60, 60);
            this.uploadPic.TabIndex = 0;
            this.uploadPic.TabStop = false;
            // 
            // mainPanelDrag
            // 
            this.mainPanelDrag.DockIndicatorTransparencyValue = 0.6D;
            this.mainPanelDrag.TargetControl = this.mainPanel;
            this.mainPanelDrag.UseTransparentDrag = true;
            // 
            // Import
            // 
            this.AcceptButton = this.ImportBtn;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 332);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Import";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.uploadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uploadPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm gblf;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2DragControl mainPanelDrag;
        private Guna.UI2.WinForms.Guna2Panel uploadPanel;
        private Guna.UI2.WinForms.Guna2PictureBox uploadPic;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox;
        public Guna.UI2.WinForms.Guna2Button ImportBtn;
    }
}