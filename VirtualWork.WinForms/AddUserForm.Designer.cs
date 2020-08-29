namespace VirtualWork.WinForms
{
	partial class AddUserForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
			this.pMain = new System.Windows.Forms.Panel();
			this.gbMain = new System.Windows.Forms.GroupBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.tbConfirmPassword = new System.Windows.Forms.TextBox();
			this.lblConfirmPassword = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.pMain.SuspendLayout();
			this.gbMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.gbMain);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(319, 171);
			this.pMain.TabIndex = 0;
			// 
			// gbMain
			// 
			this.gbMain.Controls.Add(this.btnCancel);
			this.gbMain.Controls.Add(this.btnAdd);
			this.gbMain.Controls.Add(this.tbConfirmPassword);
			this.gbMain.Controls.Add(this.lblConfirmPassword);
			this.gbMain.Controls.Add(this.tbPassword);
			this.gbMain.Controls.Add(this.lblPassword);
			this.gbMain.Controls.Add(this.tbName);
			this.gbMain.Controls.Add(this.lblName);
			this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbMain.Location = new System.Drawing.Point(0, 0);
			this.gbMain.Name = "gbMain";
			this.gbMain.Size = new System.Drawing.Size(319, 171);
			this.gbMain.TabIndex = 0;
			this.gbMain.TabStop = false;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(234, 139);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAdd.Enabled = false;
			this.btnAdd.Location = new System.Drawing.Point(153, 139);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// tbConfirmPassword
			// 
			this.tbConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbConfirmPassword.Location = new System.Drawing.Point(9, 110);
			this.tbConfirmPassword.Name = "tbConfirmPassword";
			this.tbConfirmPassword.PasswordChar = '*';
			this.tbConfirmPassword.Size = new System.Drawing.Size(300, 20);
			this.tbConfirmPassword.TabIndex = 5;
			this.tbConfirmPassword.TextChanged += new System.EventHandler(this.CredentialsChanged);
			// 
			// lblConfirmPassword
			// 
			this.lblConfirmPassword.AutoSize = true;
			this.lblConfirmPassword.Location = new System.Drawing.Point(6, 94);
			this.lblConfirmPassword.Name = "lblConfirmPassword";
			this.lblConfirmPassword.Size = new System.Drawing.Size(90, 13);
			this.lblConfirmPassword.TabIndex = 4;
			this.lblConfirmPassword.Text = "Confirm password";
			// 
			// tbPassword
			// 
			this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPassword.Location = new System.Drawing.Point(9, 71);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(300, 20);
			this.tbPassword.TabIndex = 3;
			this.tbPassword.TextChanged += new System.EventHandler(this.CredentialsChanged);
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(6, 55);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(53, 13);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Password";
			// 
			// tbName
			// 
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbName.Location = new System.Drawing.Point(9, 32);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(300, 20);
			this.tbName.TabIndex = 1;
			this.tbName.TextChanged += new System.EventHandler(this.CredentialsChanged);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(6, 16);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name";
			// 
			// AddUserForm
			// 
			this.AcceptButton = this.btnAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(319, 171);
			this.Controls.Add(this.pMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(335, 210);
			this.Name = "AddUserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add user";
			this.Shown += new System.EventHandler(this.AddUserForm_Shown);
			this.pMain.ResumeLayout(false);
			this.gbMain.ResumeLayout(false);
			this.gbMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.GroupBox gbMain;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbConfirmPassword;
		private System.Windows.Forms.Label lblConfirmPassword;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnAdd;
	}
}