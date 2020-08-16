namespace VirtualWork.WinForms
{
	partial class EmailSettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailSettingsForm));
			this.pMain = new System.Windows.Forms.Panel();
			this.btnTest = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblSmtpAuthentication = new System.Windows.Forms.Label();
			this.cbSmtpAuthentication = new System.Windows.Forms.ComboBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.tbUsername = new System.Windows.Forms.TextBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.chkSslEncryption = new System.Windows.Forms.CheckBox();
			this.nudPort = new System.Windows.Forms.NumericUpDown();
			this.lblPort = new System.Windows.Forms.Label();
			this.tbSmtpServer = new System.Windows.Forms.TextBox();
			this.lblSmtpServer = new System.Windows.Forms.Label();
			this.cbConfigurationSchema = new System.Windows.Forms.ComboBox();
			this.lblConfigurationSchema = new System.Windows.Forms.Label();
			this.pMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.btnTest);
			this.pMain.Controls.Add(this.btnClose);
			this.pMain.Controls.Add(this.btnSave);
			this.pMain.Controls.Add(this.lblSmtpAuthentication);
			this.pMain.Controls.Add(this.cbSmtpAuthentication);
			this.pMain.Controls.Add(this.tbPassword);
			this.pMain.Controls.Add(this.lblPassword);
			this.pMain.Controls.Add(this.tbUsername);
			this.pMain.Controls.Add(this.lblUsername);
			this.pMain.Controls.Add(this.chkSslEncryption);
			this.pMain.Controls.Add(this.nudPort);
			this.pMain.Controls.Add(this.lblPort);
			this.pMain.Controls.Add(this.tbSmtpServer);
			this.pMain.Controls.Add(this.lblSmtpServer);
			this.pMain.Controls.Add(this.cbConfigurationSchema);
			this.pMain.Controls.Add(this.lblConfigurationSchema);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(384, 251);
			this.pMain.TabIndex = 0;
			// 
			// btnTest
			// 
			this.btnTest.Location = new System.Drawing.Point(15, 217);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(75, 23);
			this.btnTest.TabIndex = 13;
			this.btnTest.Text = "Test";
			this.btnTest.UseVisualStyleBackColor = true;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(291, 217);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 15;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Location = new System.Drawing.Point(210, 217);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// lblSmtpAuthentication
			// 
			this.lblSmtpAuthentication.AutoSize = true;
			this.lblSmtpAuthentication.Location = new System.Drawing.Point(12, 90);
			this.lblSmtpAuthentication.Name = "lblSmtpAuthentication";
			this.lblSmtpAuthentication.Size = new System.Drawing.Size(107, 13);
			this.lblSmtpAuthentication.TabIndex = 6;
			this.lblSmtpAuthentication.Text = "SMTP authentication";
			// 
			// cbSmtpAuthentication
			// 
			this.cbSmtpAuthentication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbSmtpAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSmtpAuthentication.FormattingEnabled = true;
			this.cbSmtpAuthentication.Items.AddRange(new object[] {
            "Automatic",
            "Negotiate",
            "Ntlm",
            "Digest",
            "Login"});
			this.cbSmtpAuthentication.Location = new System.Drawing.Point(15, 106);
			this.cbSmtpAuthentication.Name = "cbSmtpAuthentication";
			this.cbSmtpAuthentication.Size = new System.Drawing.Size(235, 21);
			this.cbSmtpAuthentication.TabIndex = 7;
			// 
			// tbPassword
			// 
			this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPassword.Location = new System.Drawing.Point(15, 189);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(351, 20);
			this.tbPassword.TabIndex = 12;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(12, 173);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(53, 13);
			this.lblPassword.TabIndex = 11;
			this.lblPassword.Text = "Password";
			// 
			// tbUsername
			// 
			this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbUsername.Location = new System.Drawing.Point(15, 147);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.Size = new System.Drawing.Size(351, 20);
			this.tbUsername.TabIndex = 10;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(12, 131);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(55, 13);
			this.lblUsername.TabIndex = 9;
			this.lblUsername.Text = "Username";
			// 
			// chkSslEncryption
			// 
			this.chkSslEncryption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkSslEncryption.AutoSize = true;
			this.chkSslEncryption.Location = new System.Drawing.Point(256, 108);
			this.chkSslEncryption.Name = "chkSslEncryption";
			this.chkSslEncryption.Size = new System.Drawing.Size(98, 17);
			this.chkSslEncryption.TabIndex = 8;
			this.chkSslEncryption.Text = "SSL encryption";
			this.chkSslEncryption.UseVisualStyleBackColor = true;
			// 
			// nudPort
			// 
			this.nudPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nudPort.Location = new System.Drawing.Point(256, 66);
			this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudPort.Name = "nudPort";
			this.nudPort.Size = new System.Drawing.Size(98, 20);
			this.nudPort.TabIndex = 5;
			this.nudPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
			// 
			// lblPort
			// 
			this.lblPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(253, 50);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(26, 13);
			this.lblPort.TabIndex = 4;
			this.lblPort.Text = "Port";
			// 
			// tbSmtpServer
			// 
			this.tbSmtpServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSmtpServer.Location = new System.Drawing.Point(15, 66);
			this.tbSmtpServer.Name = "tbSmtpServer";
			this.tbSmtpServer.Size = new System.Drawing.Size(235, 20);
			this.tbSmtpServer.TabIndex = 3;
			// 
			// lblSmtpServer
			// 
			this.lblSmtpServer.AutoSize = true;
			this.lblSmtpServer.Location = new System.Drawing.Point(12, 50);
			this.lblSmtpServer.Name = "lblSmtpServer";
			this.lblSmtpServer.Size = new System.Drawing.Size(69, 13);
			this.lblSmtpServer.TabIndex = 2;
			this.lblSmtpServer.Text = "SMTP server";
			// 
			// cbConfigurationSchema
			// 
			this.cbConfigurationSchema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbConfigurationSchema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbConfigurationSchema.FormattingEnabled = true;
			this.cbConfigurationSchema.Items.AddRange(new object[] {
            "Custom",
            "mail.digikabel.hu",
            "smtp.gmail.com (TLS)",
            "smtp.gmail.com (SSL)"});
			this.cbConfigurationSchema.Location = new System.Drawing.Point(15, 25);
			this.cbConfigurationSchema.Name = "cbConfigurationSchema";
			this.cbConfigurationSchema.Size = new System.Drawing.Size(351, 21);
			this.cbConfigurationSchema.TabIndex = 1;
			this.cbConfigurationSchema.SelectedIndexChanged += new System.EventHandler(this.CbConfigurationSchema_SelectedIndexChanged);
			// 
			// lblConfigurationSchema
			// 
			this.lblConfigurationSchema.AutoSize = true;
			this.lblConfigurationSchema.Location = new System.Drawing.Point(12, 9);
			this.lblConfigurationSchema.Name = "lblConfigurationSchema";
			this.lblConfigurationSchema.Size = new System.Drawing.Size(109, 13);
			this.lblConfigurationSchema.TabIndex = 0;
			this.lblConfigurationSchema.Text = "Configuration schema";
			// 
			// EmailSettingsForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(384, 251);
			this.Controls.Add(this.pMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(400, 290);
			this.Name = "EmailSettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "E-mail settings";
			this.Shown += new System.EventHandler(this.EmailSettingsForm_Shown);
			this.pMain.ResumeLayout(false);
			this.pMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.NumericUpDown nudPort;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.TextBox tbSmtpServer;
		private System.Windows.Forms.Label lblSmtpServer;
		private System.Windows.Forms.ComboBox cbConfigurationSchema;
		private System.Windows.Forms.Label lblConfigurationSchema;
		private System.Windows.Forms.CheckBox chkSslEncryption;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox tbUsername;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblSmtpAuthentication;
		private System.Windows.Forms.ComboBox cbSmtpAuthentication;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnTest;
	}
}