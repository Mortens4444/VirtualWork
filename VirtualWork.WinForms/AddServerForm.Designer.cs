namespace VirtualWork.WinForms
{
	partial class AddServerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServerForm));
			this.pMain = new System.Windows.Forms.Panel();
			this.btnRemoteConnection = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.tbUsername = new System.Windows.Forms.TextBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.tbIpAddress = new System.Windows.Forms.TextBox();
			this.lblIpAddress = new System.Windows.Forms.Label();
			this.tbMacAddress = new System.Windows.Forms.TextBox();
			this.lblMacAddress = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.pMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.tbName);
			this.pMain.Controls.Add(this.lblName);
			this.pMain.Controls.Add(this.btnRemoteConnection);
			this.pMain.Controls.Add(this.btnAdd);
			this.pMain.Controls.Add(this.btnCancel);
			this.pMain.Controls.Add(this.tbPassword);
			this.pMain.Controls.Add(this.lblPassword);
			this.pMain.Controls.Add(this.tbUsername);
			this.pMain.Controls.Add(this.lblUsername);
			this.pMain.Controls.Add(this.tbIpAddress);
			this.pMain.Controls.Add(this.lblIpAddress);
			this.pMain.Controls.Add(this.tbMacAddress);
			this.pMain.Controls.Add(this.lblMacAddress);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(397, 237);
			this.pMain.TabIndex = 0;
			// 
			// btnRemoteConnection
			// 
			this.btnRemoteConnection.Location = new System.Drawing.Point(15, 207);
			this.btnRemoteConnection.Name = "btnRemoteConnection";
			this.btnRemoteConnection.Size = new System.Drawing.Size(122, 23);
			this.btnRemoteConnection.TabIndex = 9;
			this.btnRemoteConnection.Text = "Remote connection";
			this.btnRemoteConnection.UseVisualStyleBackColor = true;
			this.btnRemoteConnection.Click += new System.EventHandler(this.BtnRemoteConnection_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAdd.Location = new System.Drawing.Point(229, 207);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(310, 207);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// tbPassword
			// 
			this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPassword.Location = new System.Drawing.Point(15, 181);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(370, 20);
			this.tbPassword.TabIndex = 8;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(12, 165);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(53, 13);
			this.lblPassword.TabIndex = 7;
			this.lblPassword.Text = "Password";
			// 
			// tbUsername
			// 
			this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbUsername.Location = new System.Drawing.Point(15, 142);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.Size = new System.Drawing.Size(370, 20);
			this.tbUsername.TabIndex = 6;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(12, 126);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(55, 13);
			this.lblUsername.TabIndex = 5;
			this.lblUsername.Text = "Username";
			// 
			// tbIpAddress
			// 
			this.tbIpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbIpAddress.Location = new System.Drawing.Point(15, 25);
			this.tbIpAddress.Name = "tbIpAddress";
			this.tbIpAddress.Size = new System.Drawing.Size(370, 20);
			this.tbIpAddress.TabIndex = 2;
			this.tbIpAddress.Leave += new System.EventHandler(this.TbIpAddress_Leave);
			// 
			// lblIpAddress
			// 
			this.lblIpAddress.AutoSize = true;
			this.lblIpAddress.Location = new System.Drawing.Point(12, 9);
			this.lblIpAddress.Name = "lblIpAddress";
			this.lblIpAddress.Size = new System.Drawing.Size(57, 13);
			this.lblIpAddress.TabIndex = 1;
			this.lblIpAddress.Text = "IP address";
			// 
			// tbMacAddress
			// 
			this.tbMacAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbMacAddress.Location = new System.Drawing.Point(15, 103);
			this.tbMacAddress.Name = "tbMacAddress";
			this.tbMacAddress.Size = new System.Drawing.Size(370, 20);
			this.tbMacAddress.TabIndex = 4;
			// 
			// lblMacAddress
			// 
			this.lblMacAddress.AutoSize = true;
			this.lblMacAddress.Location = new System.Drawing.Point(12, 87);
			this.lblMacAddress.Name = "lblMacAddress";
			this.lblMacAddress.Size = new System.Drawing.Size(70, 13);
			this.lblMacAddress.TabIndex = 3;
			this.lblMacAddress.Text = "MAC address";
			// 
			// tbName
			// 
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbName.Location = new System.Drawing.Point(15, 64);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(370, 20);
			this.tbName.TabIndex = 13;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(12, 48);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 12;
			this.lblName.Text = "Name";
			// 
			// AddServerForm
			// 
			this.AcceptButton = this.btnAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(397, 237);
			this.Controls.Add(this.pMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(413, 276);
			this.Name = "AddServerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create server";
			this.Shown += new System.EventHandler(this.AddServerForm_Shown);
			this.pMain.ResumeLayout(false);
			this.pMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox tbUsername;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.TextBox tbIpAddress;
		private System.Windows.Forms.Label lblIpAddress;
		private System.Windows.Forms.TextBox tbMacAddress;
		private System.Windows.Forms.Label lblMacAddress;
		private System.Windows.Forms.Button btnRemoteConnection;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label lblName;
	}
}