namespace VirtualWork.WinForms
{
	partial class UserProfileForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileForm));
			this.pMain = new System.Windows.Forms.Panel();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.gb_Picture = new System.Windows.Forms.GroupBox();
			this.lbl_SizeMode = new System.Windows.Forms.Label();
			this.cb_SizeMode = new System.Windows.Forms.ComboBox();
			this.btn_SelectPicture = new System.Windows.Forms.Button();
			this.gb_PersonalDetails = new System.Windows.Forms.GroupBox();
			this.tb_LicensePlate = new System.Windows.Forms.TextBox();
			this.lbl_LicensePlate = new System.Windows.Forms.Label();
			this.lbl_OtherInformations = new System.Windows.Forms.Label();
			this.tb_OtherInformations = new System.Windows.Forms.TextBox();
			this.tb_TelephoneNumber = new System.Windows.Forms.TextBox();
			this.lbl_TelephoneNumber = new System.Windows.Forms.Label();
			this.tb_EmailAddress = new System.Windows.Forms.TextBox();
			this.lbl_EmailAddress = new System.Windows.Forms.Label();
			this.tb_Address = new System.Windows.Forms.TextBox();
			this.lbl_Address = new System.Windows.Forms.Label();
			this.tb_FullName = new System.Windows.Forms.TextBox();
			this.lbl_FullName = new System.Windows.Forms.Label();
			this.gb_Credentials = new System.Windows.Forms.GroupBox();
			this.tb_CurrentPassword = new System.Windows.Forms.TextBox();
			this.lbl_CurrentPassword = new System.Windows.Forms.Label();
			this.tb_ConfirmNewPassword = new System.Windows.Forms.TextBox();
			this.lbl_ConfirmNewPassword = new System.Windows.Forms.Label();
			this.tb_NewPassword = new System.Windows.Forms.TextBox();
			this.lbl_NewPassword = new System.Windows.Forms.Label();
			this.tb_Username = new System.Windows.Forms.TextBox();
			this.lbl_Username = new System.Windows.Forms.Label();
			this.pb_Picture = new System.Windows.Forms.PictureBox();
			this.pMain.SuspendLayout();
			this.gb_Picture.SuspendLayout();
			this.gb_PersonalDetails.SuspendLayout();
			this.gb_Credentials.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Picture)).BeginInit();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.btn_Cancel);
			this.pMain.Controls.Add(this.btn_Save);
			this.pMain.Controls.Add(this.gb_Picture);
			this.pMain.Controls.Add(this.gb_PersonalDetails);
			this.pMain.Controls.Add(this.gb_Credentials);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(778, 454);
			this.pMain.TabIndex = 0;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.Location = new System.Drawing.Point(696, 425);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 26;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Save.Location = new System.Drawing.Point(615, 425);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(75, 23);
			this.btn_Save.TabIndex = 25;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
			// 
			// gb_Picture
			// 
			this.gb_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_Picture.Controls.Add(this.pb_Picture);
			this.gb_Picture.Controls.Add(this.lbl_SizeMode);
			this.gb_Picture.Controls.Add(this.cb_SizeMode);
			this.gb_Picture.Controls.Add(this.btn_SelectPicture);
			this.gb_Picture.Location = new System.Drawing.Point(335, 1);
			this.gb_Picture.Name = "gb_Picture";
			this.gb_Picture.Size = new System.Drawing.Size(440, 421);
			this.gb_Picture.TabIndex = 22;
			this.gb_Picture.TabStop = false;
			this.gb_Picture.Text = "Picture";
			// 
			// lbl_SizeMode
			// 
			this.lbl_SizeMode.AutoSize = true;
			this.lbl_SizeMode.Location = new System.Drawing.Point(6, 16);
			this.lbl_SizeMode.Name = "lbl_SizeMode";
			this.lbl_SizeMode.Size = new System.Drawing.Size(56, 13);
			this.lbl_SizeMode.TabIndex = 23;
			this.lbl_SizeMode.Text = "Size mode";
			// 
			// cb_SizeMode
			// 
			this.cb_SizeMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_SizeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_SizeMode.FormattingEnabled = true;
			this.cb_SizeMode.Location = new System.Drawing.Point(6, 36);
			this.cb_SizeMode.Name = "cb_SizeMode";
			this.cb_SizeMode.Size = new System.Drawing.Size(428, 21);
			this.cb_SizeMode.TabIndex = 23;
			// 
			// btn_SelectPicture
			// 
			this.btn_SelectPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_SelectPicture.Location = new System.Drawing.Point(340, 11);
			this.btn_SelectPicture.Name = "btn_SelectPicture";
			this.btn_SelectPicture.Size = new System.Drawing.Size(94, 23);
			this.btn_SelectPicture.TabIndex = 24;
			this.btn_SelectPicture.Text = "Select picture";
			this.btn_SelectPicture.UseVisualStyleBackColor = true;
			// 
			// gb_PersonalDetails
			// 
			this.gb_PersonalDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gb_PersonalDetails.Controls.Add(this.tb_LicensePlate);
			this.gb_PersonalDetails.Controls.Add(this.lbl_LicensePlate);
			this.gb_PersonalDetails.Controls.Add(this.lbl_OtherInformations);
			this.gb_PersonalDetails.Controls.Add(this.tb_OtherInformations);
			this.gb_PersonalDetails.Controls.Add(this.tb_TelephoneNumber);
			this.gb_PersonalDetails.Controls.Add(this.lbl_TelephoneNumber);
			this.gb_PersonalDetails.Controls.Add(this.tb_EmailAddress);
			this.gb_PersonalDetails.Controls.Add(this.lbl_EmailAddress);
			this.gb_PersonalDetails.Controls.Add(this.tb_Address);
			this.gb_PersonalDetails.Controls.Add(this.lbl_Address);
			this.gb_PersonalDetails.Controls.Add(this.tb_FullName);
			this.gb_PersonalDetails.Controls.Add(this.lbl_FullName);
			this.gb_PersonalDetails.Location = new System.Drawing.Point(3, 115);
			this.gb_PersonalDetails.Name = "gb_PersonalDetails";
			this.gb_PersonalDetails.Size = new System.Drawing.Size(326, 307);
			this.gb_PersonalDetails.TabIndex = 9;
			this.gb_PersonalDetails.TabStop = false;
			this.gb_PersonalDetails.Text = "Personal details";
			// 
			// tb_LicensePlate
			// 
			this.tb_LicensePlate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_LicensePlate.Location = new System.Drawing.Point(169, 108);
			this.tb_LicensePlate.MaxLength = 50;
			this.tb_LicensePlate.Name = "tb_LicensePlate";
			this.tb_LicensePlate.Size = new System.Drawing.Size(151, 20);
			this.tb_LicensePlate.TabIndex = 19;
			// 
			// lbl_LicensePlate
			// 
			this.lbl_LicensePlate.AutoSize = true;
			this.lbl_LicensePlate.Location = new System.Drawing.Point(9, 111);
			this.lbl_LicensePlate.MaximumSize = new System.Drawing.Size(151, 13);
			this.lbl_LicensePlate.Name = "lbl_LicensePlate";
			this.lbl_LicensePlate.Size = new System.Drawing.Size(70, 13);
			this.lbl_LicensePlate.TabIndex = 18;
			this.lbl_LicensePlate.Text = "License-plate";
			// 
			// lbl_OtherInformations
			// 
			this.lbl_OtherInformations.AutoSize = true;
			this.lbl_OtherInformations.Location = new System.Drawing.Point(9, 134);
			this.lbl_OtherInformations.Name = "lbl_OtherInformations";
			this.lbl_OtherInformations.Size = new System.Drawing.Size(87, 13);
			this.lbl_OtherInformations.TabIndex = 20;
			this.lbl_OtherInformations.Text = "Other information";
			// 
			// tb_OtherInformations
			// 
			this.tb_OtherInformations.AcceptsTab = true;
			this.tb_OtherInformations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_OtherInformations.Location = new System.Drawing.Point(6, 150);
			this.tb_OtherInformations.MaxLength = 1000;
			this.tb_OtherInformations.Multiline = true;
			this.tb_OtherInformations.Name = "tb_OtherInformations";
			this.tb_OtherInformations.Size = new System.Drawing.Size(314, 151);
			this.tb_OtherInformations.TabIndex = 21;
			// 
			// tb_TelephoneNumber
			// 
			this.tb_TelephoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_TelephoneNumber.Location = new System.Drawing.Point(169, 85);
			this.tb_TelephoneNumber.MaxLength = 50;
			this.tb_TelephoneNumber.Name = "tb_TelephoneNumber";
			this.tb_TelephoneNumber.Size = new System.Drawing.Size(151, 20);
			this.tb_TelephoneNumber.TabIndex = 17;
			// 
			// lbl_TelephoneNumber
			// 
			this.lbl_TelephoneNumber.AutoSize = true;
			this.lbl_TelephoneNumber.Location = new System.Drawing.Point(9, 88);
			this.lbl_TelephoneNumber.MaximumSize = new System.Drawing.Size(151, 13);
			this.lbl_TelephoneNumber.Name = "lbl_TelephoneNumber";
			this.lbl_TelephoneNumber.Size = new System.Drawing.Size(96, 13);
			this.lbl_TelephoneNumber.TabIndex = 16;
			this.lbl_TelephoneNumber.Text = "Telephone number";
			// 
			// tb_EmailAddress
			// 
			this.tb_EmailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_EmailAddress.Location = new System.Drawing.Point(169, 62);
			this.tb_EmailAddress.MaxLength = 200;
			this.tb_EmailAddress.Name = "tb_EmailAddress";
			this.tb_EmailAddress.Size = new System.Drawing.Size(151, 20);
			this.tb_EmailAddress.TabIndex = 15;
			// 
			// lbl_EmailAddress
			// 
			this.lbl_EmailAddress.AutoSize = true;
			this.lbl_EmailAddress.Location = new System.Drawing.Point(9, 65);
			this.lbl_EmailAddress.MaximumSize = new System.Drawing.Size(151, 13);
			this.lbl_EmailAddress.Name = "lbl_EmailAddress";
			this.lbl_EmailAddress.Size = new System.Drawing.Size(75, 13);
			this.lbl_EmailAddress.TabIndex = 14;
			this.lbl_EmailAddress.Text = "E-mail address";
			// 
			// tb_Address
			// 
			this.tb_Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Address.Location = new System.Drawing.Point(169, 39);
			this.tb_Address.MaxLength = 1000;
			this.tb_Address.Name = "tb_Address";
			this.tb_Address.Size = new System.Drawing.Size(151, 20);
			this.tb_Address.TabIndex = 13;
			// 
			// lbl_Address
			// 
			this.lbl_Address.AutoSize = true;
			this.lbl_Address.Location = new System.Drawing.Point(9, 42);
			this.lbl_Address.MaximumSize = new System.Drawing.Size(151, 13);
			this.lbl_Address.Name = "lbl_Address";
			this.lbl_Address.Size = new System.Drawing.Size(45, 13);
			this.lbl_Address.TabIndex = 12;
			this.lbl_Address.Text = "Address";
			// 
			// tb_FullName
			// 
			this.tb_FullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_FullName.Location = new System.Drawing.Point(169, 16);
			this.tb_FullName.MaxLength = 100;
			this.tb_FullName.Name = "tb_FullName";
			this.tb_FullName.Size = new System.Drawing.Size(151, 20);
			this.tb_FullName.TabIndex = 11;
			// 
			// lbl_FullName
			// 
			this.lbl_FullName.AutoSize = true;
			this.lbl_FullName.Location = new System.Drawing.Point(9, 19);
			this.lbl_FullName.MaximumSize = new System.Drawing.Size(151, 13);
			this.lbl_FullName.Name = "lbl_FullName";
			this.lbl_FullName.Size = new System.Drawing.Size(52, 13);
			this.lbl_FullName.TabIndex = 10;
			this.lbl_FullName.Text = "Full name";
			// 
			// gb_Credentials
			// 
			this.gb_Credentials.Controls.Add(this.tb_CurrentPassword);
			this.gb_Credentials.Controls.Add(this.lbl_CurrentPassword);
			this.gb_Credentials.Controls.Add(this.tb_ConfirmNewPassword);
			this.gb_Credentials.Controls.Add(this.lbl_ConfirmNewPassword);
			this.gb_Credentials.Controls.Add(this.tb_NewPassword);
			this.gb_Credentials.Controls.Add(this.lbl_NewPassword);
			this.gb_Credentials.Controls.Add(this.tb_Username);
			this.gb_Credentials.Controls.Add(this.lbl_Username);
			this.gb_Credentials.Location = new System.Drawing.Point(3, 1);
			this.gb_Credentials.Name = "gb_Credentials";
			this.gb_Credentials.Size = new System.Drawing.Size(326, 108);
			this.gb_Credentials.TabIndex = 0;
			this.gb_Credentials.TabStop = false;
			this.gb_Credentials.Text = "Credentials";
			// 
			// tb_CurrentPassword
			// 
			this.tb_CurrentPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_CurrentPassword.Location = new System.Drawing.Point(169, 36);
			this.tb_CurrentPassword.MaxLength = 100;
			this.tb_CurrentPassword.Name = "tb_CurrentPassword";
			this.tb_CurrentPassword.PasswordChar = '*';
			this.tb_CurrentPassword.Size = new System.Drawing.Size(151, 20);
			this.tb_CurrentPassword.TabIndex = 4;
			// 
			// lbl_CurrentPassword
			// 
			this.lbl_CurrentPassword.AutoSize = true;
			this.lbl_CurrentPassword.Location = new System.Drawing.Point(9, 39);
			this.lbl_CurrentPassword.MaximumSize = new System.Drawing.Size(151, 13);
			this.lbl_CurrentPassword.Name = "lbl_CurrentPassword";
			this.lbl_CurrentPassword.Size = new System.Drawing.Size(89, 13);
			this.lbl_CurrentPassword.TabIndex = 3;
			this.lbl_CurrentPassword.Text = "Current password";
			// 
			// tb_ConfirmNewPassword
			// 
			this.tb_ConfirmNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_ConfirmNewPassword.Location = new System.Drawing.Point(169, 82);
			this.tb_ConfirmNewPassword.MaxLength = 100;
			this.tb_ConfirmNewPassword.Name = "tb_ConfirmNewPassword";
			this.tb_ConfirmNewPassword.PasswordChar = '*';
			this.tb_ConfirmNewPassword.Size = new System.Drawing.Size(151, 20);
			this.tb_ConfirmNewPassword.TabIndex = 8;
			// 
			// lbl_ConfirmNewPassword
			// 
			this.lbl_ConfirmNewPassword.AutoSize = true;
			this.lbl_ConfirmNewPassword.Location = new System.Drawing.Point(9, 85);
			this.lbl_ConfirmNewPassword.MaximumSize = new System.Drawing.Size(151, 13);
			this.lbl_ConfirmNewPassword.Name = "lbl_ConfirmNewPassword";
			this.lbl_ConfirmNewPassword.Size = new System.Drawing.Size(113, 13);
			this.lbl_ConfirmNewPassword.TabIndex = 7;
			this.lbl_ConfirmNewPassword.Text = "Confirm new password";
			// 
			// tb_NewPassword
			// 
			this.tb_NewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_NewPassword.Location = new System.Drawing.Point(169, 59);
			this.tb_NewPassword.MaxLength = 100;
			this.tb_NewPassword.Name = "tb_NewPassword";
			this.tb_NewPassword.PasswordChar = '*';
			this.tb_NewPassword.Size = new System.Drawing.Size(151, 20);
			this.tb_NewPassword.TabIndex = 6;
			// 
			// lbl_NewPassword
			// 
			this.lbl_NewPassword.AutoSize = true;
			this.lbl_NewPassword.Location = new System.Drawing.Point(9, 62);
			this.lbl_NewPassword.MaximumSize = new System.Drawing.Size(151, 13);
			this.lbl_NewPassword.Name = "lbl_NewPassword";
			this.lbl_NewPassword.Size = new System.Drawing.Size(77, 13);
			this.lbl_NewPassword.TabIndex = 5;
			this.lbl_NewPassword.Text = "New password";
			// 
			// tb_Username
			// 
			this.tb_Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Username.Location = new System.Drawing.Point(169, 13);
			this.tb_Username.MaxLength = 100;
			this.tb_Username.Name = "tb_Username";
			this.tb_Username.ReadOnly = true;
			this.tb_Username.Size = new System.Drawing.Size(151, 20);
			this.tb_Username.TabIndex = 2;
			this.tb_Username.TabStop = false;
			// 
			// lbl_Username
			// 
			this.lbl_Username.AutoSize = true;
			this.lbl_Username.Location = new System.Drawing.Point(9, 16);
			this.lbl_Username.MaximumSize = new System.Drawing.Size(151, 13);
			this.lbl_Username.Name = "lbl_Username";
			this.lbl_Username.Size = new System.Drawing.Size(55, 13);
			this.lbl_Username.TabIndex = 1;
			this.lbl_Username.Text = "Username";
			// 
			// pb_Picture
			// 
			this.pb_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pb_Picture.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.pb_Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pb_Picture.Location = new System.Drawing.Point(6, 59);
			this.pb_Picture.Name = "pb_Picture";
			this.pb_Picture.Size = new System.Drawing.Size(428, 356);
			this.pb_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_Picture.TabIndex = 5;
			this.pb_Picture.TabStop = false;
			// 
			// UserProfileForm
			// 
			this.AcceptButton = this.btn_Save;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_Cancel;
			this.ClientSize = new System.Drawing.Size(778, 454);
			this.Controls.Add(this.pMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UserProfileForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User profile";
			this.Shown += new System.EventHandler(this.UserProfileForm_Shown);
			this.pMain.ResumeLayout(false);
			this.gb_Picture.ResumeLayout(false);
			this.gb_Picture.PerformLayout();
			this.gb_PersonalDetails.ResumeLayout(false);
			this.gb_PersonalDetails.PerformLayout();
			this.gb_Credentials.ResumeLayout(false);
			this.gb_Credentials.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Picture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.GroupBox gb_Picture;
		private System.Windows.Forms.PictureBox pb_Picture;
		private System.Windows.Forms.Label lbl_SizeMode;
		private System.Windows.Forms.ComboBox cb_SizeMode;
		private System.Windows.Forms.Button btn_SelectPicture;
		private System.Windows.Forms.GroupBox gb_PersonalDetails;
		private System.Windows.Forms.TextBox tb_LicensePlate;
		private System.Windows.Forms.Label lbl_LicensePlate;
		private System.Windows.Forms.Label lbl_OtherInformations;
		private System.Windows.Forms.TextBox tb_OtherInformations;
		private System.Windows.Forms.TextBox tb_TelephoneNumber;
		private System.Windows.Forms.Label lbl_TelephoneNumber;
		private System.Windows.Forms.TextBox tb_EmailAddress;
		private System.Windows.Forms.Label lbl_EmailAddress;
		private System.Windows.Forms.TextBox tb_Address;
		private System.Windows.Forms.Label lbl_Address;
		private System.Windows.Forms.TextBox tb_FullName;
		private System.Windows.Forms.Label lbl_FullName;
		private System.Windows.Forms.GroupBox gb_Credentials;
		private System.Windows.Forms.TextBox tb_CurrentPassword;
		private System.Windows.Forms.Label lbl_CurrentPassword;
		private System.Windows.Forms.TextBox tb_ConfirmNewPassword;
		private System.Windows.Forms.Label lbl_ConfirmNewPassword;
		private System.Windows.Forms.TextBox tb_NewPassword;
		private System.Windows.Forms.Label lbl_NewPassword;
		private System.Windows.Forms.TextBox tb_Username;
		private System.Windows.Forms.Label lbl_Username;
	}
}