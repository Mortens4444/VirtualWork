namespace VirtualWork.WinForms
{
	partial class UserManagementForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
			this.pMain = new System.Windows.Forms.Panel();
			this.gbUsersAndGroups = new System.Windows.Forms.GroupBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.chkIsActive = new System.Windows.Forms.CheckBox();
			this.rtbDescription = new System.Windows.Forms.RichTextBox();
			this.tvUsersAndGroups = new System.Windows.Forms.TreeView();
			this.images = new System.Windows.Forms.ImageList(this.components);
			this.btn_Close = new System.Windows.Forms.Button();
			this.btnCreateNewGroup = new System.Windows.Forms.Button();
			this.btnModifyUserOrGroup = new System.Windows.Forms.Button();
			this.btnRemoveUserOrGroup = new System.Windows.Forms.Button();
			this.btnCreateNewUser = new System.Windows.Forms.Button();
			this.pMain.SuspendLayout();
			this.gbUsersAndGroups.SuspendLayout();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.gbUsersAndGroups);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(800, 450);
			this.pMain.TabIndex = 4;
			// 
			// gbUsersAndGroups
			// 
			this.gbUsersAndGroups.Controls.Add(this.lblDescription);
			this.gbUsersAndGroups.Controls.Add(this.chkIsActive);
			this.gbUsersAndGroups.Controls.Add(this.rtbDescription);
			this.gbUsersAndGroups.Controls.Add(this.tvUsersAndGroups);
			this.gbUsersAndGroups.Controls.Add(this.btn_Close);
			this.gbUsersAndGroups.Controls.Add(this.btnCreateNewGroup);
			this.gbUsersAndGroups.Controls.Add(this.btnModifyUserOrGroup);
			this.gbUsersAndGroups.Controls.Add(this.btnRemoveUserOrGroup);
			this.gbUsersAndGroups.Controls.Add(this.btnCreateNewUser);
			this.gbUsersAndGroups.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbUsersAndGroups.Location = new System.Drawing.Point(0, 0);
			this.gbUsersAndGroups.Name = "gbUsersAndGroups";
			this.gbUsersAndGroups.Size = new System.Drawing.Size(800, 450);
			this.gbUsersAndGroups.TabIndex = 0;
			this.gbUsersAndGroups.TabStop = false;
			this.gbUsersAndGroups.Text = "Groups and users";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(467, 53);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.TabIndex = 3;
			this.lblDescription.Text = "Description";
			// 
			// chkIsActive
			// 
			this.chkIsActive.AutoSize = true;
			this.chkIsActive.Location = new System.Drawing.Point(467, 19);
			this.chkIsActive.Name = "chkIsActive";
			this.chkIsActive.Size = new System.Drawing.Size(66, 17);
			this.chkIsActive.TabIndex = 2;
			this.chkIsActive.Text = "Is active";
			this.chkIsActive.UseVisualStyleBackColor = true;
			// 
			// rtbDescription
			// 
			this.rtbDescription.Location = new System.Drawing.Point(467, 69);
			this.rtbDescription.Name = "rtbDescription";
			this.rtbDescription.ReadOnly = true;
			this.rtbDescription.Size = new System.Drawing.Size(321, 336);
			this.rtbDescription.TabIndex = 4;
			this.rtbDescription.Text = "";
			// 
			// tvUsersAndGroups
			// 
			this.tvUsersAndGroups.ImageIndex = 0;
			this.tvUsersAndGroups.ImageList = this.images;
			this.tvUsersAndGroups.Location = new System.Drawing.Point(6, 17);
			this.tvUsersAndGroups.Name = "tvUsersAndGroups";
			this.tvUsersAndGroups.SelectedImageIndex = 0;
			this.tvUsersAndGroups.Size = new System.Drawing.Size(455, 388);
			this.tvUsersAndGroups.TabIndex = 1;
			this.tvUsersAndGroups.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvUsersAndGroups_AfterSelect);
			// 
			// images
			// 
			this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
			this.images.TransparentColor = System.Drawing.Color.Transparent;
			this.images.Images.SetKeyName(0, "group.ico");
			this.images.Images.SetKeyName(1, "user.ico");
			// 
			// btn_Close
			// 
			this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Close.Location = new System.Drawing.Point(669, 421);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(125, 23);
			this.btn_Close.TabIndex = 9;
			this.btn_Close.Text = "Close";
			this.btn_Close.UseVisualStyleBackColor = true;
			this.btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
			// 
			// btnCreateNewGroup
			// 
			this.btnCreateNewGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreateNewGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNewGroup.Image")));
			this.btnCreateNewGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCreateNewGroup.Location = new System.Drawing.Point(6, 421);
			this.btnCreateNewGroup.Name = "btnCreateNewGroup";
			this.btnCreateNewGroup.Size = new System.Drawing.Size(125, 23);
			this.btnCreateNewGroup.TabIndex = 5;
			this.btnCreateNewGroup.Text = "New group";
			this.btnCreateNewGroup.UseVisualStyleBackColor = true;
			this.btnCreateNewGroup.Click += new System.EventHandler(this.BtnCreateNewGroup_Click);
			// 
			// btnModifyUserOrGroup
			// 
			this.btnModifyUserOrGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnModifyUserOrGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyUserOrGroup.Image")));
			this.btnModifyUserOrGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModifyUserOrGroup.Location = new System.Drawing.Point(268, 421);
			this.btnModifyUserOrGroup.Name = "btnModifyUserOrGroup";
			this.btnModifyUserOrGroup.Size = new System.Drawing.Size(125, 23);
			this.btnModifyUserOrGroup.TabIndex = 7;
			this.btnModifyUserOrGroup.Text = "Modify";
			this.btnModifyUserOrGroup.UseVisualStyleBackColor = true;
			// 
			// btnRemoveUserOrGroup
			// 
			this.btnRemoveUserOrGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemoveUserOrGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveUserOrGroup.Image")));
			this.btnRemoveUserOrGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemoveUserOrGroup.Location = new System.Drawing.Point(399, 421);
			this.btnRemoveUserOrGroup.Name = "btnRemoveUserOrGroup";
			this.btnRemoveUserOrGroup.Size = new System.Drawing.Size(125, 23);
			this.btnRemoveUserOrGroup.TabIndex = 8;
			this.btnRemoveUserOrGroup.Text = "Remove";
			this.btnRemoveUserOrGroup.UseVisualStyleBackColor = true;
			// 
			// btnCreateNewUser
			// 
			this.btnCreateNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreateNewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNewUser.Image")));
			this.btnCreateNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCreateNewUser.Location = new System.Drawing.Point(137, 421);
			this.btnCreateNewUser.Name = "btnCreateNewUser";
			this.btnCreateNewUser.Size = new System.Drawing.Size(125, 23);
			this.btnCreateNewUser.TabIndex = 6;
			this.btnCreateNewUser.Text = "New user";
			this.btnCreateNewUser.UseVisualStyleBackColor = true;
			this.btnCreateNewUser.Click += new System.EventHandler(this.BtnCreateNewUser_Click);
			// 
			// UserManagementForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UserManagementForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User management";
			this.Shown += new System.EventHandler(this.UserManagementForm_Shown);
			this.pMain.ResumeLayout(false);
			this.gbUsersAndGroups.ResumeLayout(false);
			this.gbUsersAndGroups.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.GroupBox gbUsersAndGroups;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Button btnCreateNewGroup;
		private System.Windows.Forms.Button btnModifyUserOrGroup;
		private System.Windows.Forms.Button btnRemoveUserOrGroup;
		private System.Windows.Forms.Button btnCreateNewUser;
		private System.Windows.Forms.RichTextBox rtbDescription;
		private System.Windows.Forms.TreeView tvUsersAndGroups;
		private System.Windows.Forms.CheckBox chkIsActive;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.ImageList images;
	}
}