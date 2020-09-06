namespace VirtualWork.WinForms
{
	partial class AddCameraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCameraForm));
			this.pMain = new System.Windows.Forms.Panel();
			this.cbServer = new System.Windows.Forms.ComboBox();
			this.lblServer = new System.Windows.Forms.Label();
			this.rtbDescription = new System.Windows.Forms.RichTextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnRemoteConnection = new System.Windows.Forms.Button();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.tbUsername = new System.Windows.Forms.TextBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.tbUri = new System.Windows.Forms.TextBox();
			this.lblUri = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.pMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.cbServer);
			this.pMain.Controls.Add(this.lblServer);
			this.pMain.Controls.Add(this.rtbDescription);
			this.pMain.Controls.Add(this.lblDescription);
			this.pMain.Controls.Add(this.btnAdd);
			this.pMain.Controls.Add(this.btnCancel);
			this.pMain.Controls.Add(this.btnRemoteConnection);
			this.pMain.Controls.Add(this.tbPassword);
			this.pMain.Controls.Add(this.lblPassword);
			this.pMain.Controls.Add(this.tbUsername);
			this.pMain.Controls.Add(this.lblUsername);
			this.pMain.Controls.Add(this.tbUri);
			this.pMain.Controls.Add(this.lblUri);
			this.pMain.Controls.Add(this.tbName);
			this.pMain.Controls.Add(this.lblName);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(404, 320);
			this.pMain.TabIndex = 1;
			// 
			// cbServer
			// 
			this.cbServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbServer.FormattingEnabled = true;
			this.cbServer.Location = new System.Drawing.Point(12, 182);
			this.cbServer.Name = "cbServer";
			this.cbServer.Size = new System.Drawing.Size(380, 21);
			this.cbServer.TabIndex = 9;
			// 
			// lblServer
			// 
			this.lblServer.AutoSize = true;
			this.lblServer.Location = new System.Drawing.Point(9, 166);
			this.lblServer.Name = "lblServer";
			this.lblServer.Size = new System.Drawing.Size(38, 13);
			this.lblServer.TabIndex = 8;
			this.lblServer.Text = "Server";
			// 
			// rtbDescription
			// 
			this.rtbDescription.AcceptsTab = true;
			this.rtbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbDescription.Location = new System.Drawing.Point(12, 226);
			this.rtbDescription.Name = "rtbDescription";
			this.rtbDescription.Size = new System.Drawing.Size(380, 53);
			this.rtbDescription.TabIndex = 11;
			this.rtbDescription.Text = "";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(9, 210);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.TabIndex = 10;
			this.lblDescription.Text = "Description";
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAdd.Location = new System.Drawing.Point(236, 285);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 13;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(317, 285);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 14;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnRemoteConnection
			// 
			this.btnRemoteConnection.Location = new System.Drawing.Point(12, 285);
			this.btnRemoteConnection.Name = "btnRemoteConnection";
			this.btnRemoteConnection.Size = new System.Drawing.Size(122, 23);
			this.btnRemoteConnection.TabIndex = 12;
			this.btnRemoteConnection.Text = "Remote connection";
			this.btnRemoteConnection.UseVisualStyleBackColor = true;
			// 
			// tbPassword
			// 
			this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPassword.Location = new System.Drawing.Point(12, 143);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(380, 20);
			this.tbPassword.TabIndex = 7;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(9, 127);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(53, 13);
			this.lblPassword.TabIndex = 6;
			this.lblPassword.Text = "Password";
			// 
			// tbUsername
			// 
			this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbUsername.Location = new System.Drawing.Point(12, 104);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.Size = new System.Drawing.Size(380, 20);
			this.tbUsername.TabIndex = 5;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(9, 88);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(55, 13);
			this.lblUsername.TabIndex = 4;
			this.lblUsername.Text = "Username";
			// 
			// tbUri
			// 
			this.tbUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbUri.Location = new System.Drawing.Point(12, 65);
			this.tbUri.Name = "tbUri";
			this.tbUri.Size = new System.Drawing.Size(380, 20);
			this.tbUri.TabIndex = 3;
			// 
			// lblUri
			// 
			this.lblUri.AutoSize = true;
			this.lblUri.Location = new System.Drawing.Point(9, 49);
			this.lblUri.Name = "lblUri";
			this.lblUri.Size = new System.Drawing.Size(26, 13);
			this.lblUri.TabIndex = 2;
			this.lblUri.Text = "URI";
			// 
			// tbName
			// 
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbName.Location = new System.Drawing.Point(12, 26);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(380, 20);
			this.tbName.TabIndex = 1;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(9, 10);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name";
			// 
			// AddCameraForm
			// 
			this.AcceptButton = this.btnAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(404, 320);
			this.Controls.Add(this.pMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(420, 359);
			this.Name = "AddCameraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create camera";
			this.Shown += new System.EventHandler(this.AddCameraForm_Shown);
			this.pMain.ResumeLayout(false);
			this.pMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Button btnRemoteConnection;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox tbUsername;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.TextBox tbUri;
		private System.Windows.Forms.Label lblUri;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.RichTextBox rtbDescription;
		private System.Windows.Forms.ComboBox cbServer;
		private System.Windows.Forms.Label lblServer;
	}
}