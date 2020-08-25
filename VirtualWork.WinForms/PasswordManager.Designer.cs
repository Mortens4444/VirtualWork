namespace VirtualWork.WinForms
{
	partial class PasswordManager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordManager));
			this.ch_0_DisplayedName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_1_Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_2_Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_3_Link = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_4_LoginLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_5_Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_6_ExtraInformation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.p_Main = new System.Windows.Forms.Panel();
			this.cbGroup = new System.Windows.Forms.ComboBox();
			this.lvCredentials = new System.Windows.Forms.ListView();
			this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chAlternativeLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chExtraInformation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cms_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiCopyUsername = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCopyPassword = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCopyExtraInformation = new System.Windows.Forms.ToolStripMenuItem();
			this.tss_Separator_2 = new System.Windows.Forms.ToolStripSeparator();
			this.tss_Separator_3 = new System.Windows.Forms.ToolStripSeparator();
			this.tb_Search = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.tsmiShowPassword = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiVisitLink = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiVisitAlternativeLink = new System.Windows.Forms.ToolStripMenuItem();
			this.p_Main.SuspendLayout();
			this.cms_Menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// ch_0_DisplayedName
			// 
			this.ch_0_DisplayedName.Text = "Displayed name";
			this.ch_0_DisplayedName.Width = 126;
			// 
			// ch_1_Username
			// 
			this.ch_1_Username.Text = "Username";
			this.ch_1_Username.Width = 178;
			// 
			// ch_2_Password
			// 
			this.ch_2_Password.Text = "Password";
			this.ch_2_Password.Width = 105;
			// 
			// ch_3_Link
			// 
			this.ch_3_Link.Text = "Link";
			this.ch_3_Link.Width = 267;
			// 
			// ch_4_LoginLink
			// 
			this.ch_4_LoginLink.Text = "Login link";
			this.ch_4_LoginLink.Width = 265;
			// 
			// ch_5_Group
			// 
			this.ch_5_Group.Text = "Group";
			this.ch_5_Group.Width = 127;
			// 
			// ch_6_ExtraInformation
			// 
			this.ch_6_ExtraInformation.Text = "Extra information";
			this.ch_6_ExtraInformation.Width = 281;
			// 
			// p_Main
			// 
			this.p_Main.Controls.Add(this.btnAdd);
			this.p_Main.Controls.Add(this.cbGroup);
			this.p_Main.Controls.Add(this.lvCredentials);
			this.p_Main.Controls.Add(this.tb_Search);
			this.p_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Main.Location = new System.Drawing.Point(0, 0);
			this.p_Main.Name = "p_Main";
			this.p_Main.Size = new System.Drawing.Size(1090, 450);
			this.p_Main.TabIndex = 2;
			// 
			// cbGroup
			// 
			this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGroup.FormattingEnabled = true;
			this.cbGroup.Location = new System.Drawing.Point(185, 5);
			this.cbGroup.Name = "cbGroup";
			this.cbGroup.Size = new System.Drawing.Size(149, 21);
			this.cbGroup.TabIndex = 1;
			this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.GetPasswords);
			// 
			// lvCredentials
			// 
			this.lvCredentials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chGroup,
            this.chUsername,
            this.chPassword,
            this.chLink,
            this.chAlternativeLink,
            this.chExtraInformation});
			this.lvCredentials.ContextMenuStrip = this.cms_Menu;
			this.lvCredentials.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lvCredentials.FullRowSelect = true;
			this.lvCredentials.HideSelection = false;
			this.lvCredentials.Location = new System.Drawing.Point(0, 32);
			this.lvCredentials.Name = "lvCredentials";
			this.lvCredentials.Size = new System.Drawing.Size(1090, 418);
			this.lvCredentials.TabIndex = 2;
			this.lvCredentials.UseCompatibleStateImageBehavior = false;
			this.lvCredentials.View = System.Windows.Forms.View.Details;
			// 
			// chName
			// 
			this.chName.Text = "Name";
			this.chName.Width = 178;
			// 
			// chGroup
			// 
			this.chGroup.Text = "Group";
			this.chGroup.Width = 158;
			// 
			// chUsername
			// 
			this.chUsername.Text = "Username";
			this.chUsername.Width = 137;
			// 
			// chPassword
			// 
			this.chPassword.Text = "Password";
			this.chPassword.Width = 128;
			// 
			// chLink
			// 
			this.chLink.Text = "Link";
			this.chLink.Width = 167;
			// 
			// chAlternativeLink
			// 
			this.chAlternativeLink.Text = "Alternative link";
			this.chAlternativeLink.Width = 179;
			// 
			// chExtraInformation
			// 
			this.chExtraInformation.Text = "Extra information";
			this.chExtraInformation.Width = 170;
			// 
			// cms_Menu
			// 
			this.cms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopyUsername,
            this.tsmiCopyPassword,
            this.tsmiCopyExtraInformation,
            this.tsmiShowPassword,
            this.tss_Separator_2,
            this.tsmiEdit,
            this.tsmiDelete,
            this.tss_Separator_3,
            this.tsmiVisitLink,
            this.tsmiVisitAlternativeLink});
			this.cms_Menu.Name = "cms_Menu";
			this.cms_Menu.Size = new System.Drawing.Size(198, 192);
			this.cms_Menu.Opening += new System.ComponentModel.CancelEventHandler(this.Cms_Menu_Opening);
			// 
			// tsmiCopyUsername
			// 
			this.tsmiCopyUsername.Image = global::VirtualWork.WinForms.Properties.Resources.copy;
			this.tsmiCopyUsername.Name = "tsmiCopyUsername";
			this.tsmiCopyUsername.Size = new System.Drawing.Size(197, 22);
			this.tsmiCopyUsername.Text = "Copy username";
			this.tsmiCopyUsername.Click += new System.EventHandler(this.Tsmi_CopyUsername_Click);
			// 
			// tsmiCopyPassword
			// 
			this.tsmiCopyPassword.Image = global::VirtualWork.WinForms.Properties.Resources.copy;
			this.tsmiCopyPassword.Name = "tsmiCopyPassword";
			this.tsmiCopyPassword.Size = new System.Drawing.Size(197, 22);
			this.tsmiCopyPassword.Text = "Copy password";
			this.tsmiCopyPassword.Click += new System.EventHandler(this.Tsmi_CopyPassword_Click);
			// 
			// tsmiCopyExtraInformation
			// 
			this.tsmiCopyExtraInformation.Image = global::VirtualWork.WinForms.Properties.Resources.copy;
			this.tsmiCopyExtraInformation.Name = "tsmiCopyExtraInformation";
			this.tsmiCopyExtraInformation.Size = new System.Drawing.Size(197, 22);
			this.tsmiCopyExtraInformation.Text = "Copy extra information";
			this.tsmiCopyExtraInformation.Click += new System.EventHandler(this.Tsmi_CopyExtraInformation_Click);
			// 
			// tss_Separator_2
			// 
			this.tss_Separator_2.Name = "tss_Separator_2";
			this.tss_Separator_2.Size = new System.Drawing.Size(194, 6);
			// 
			// tss_Separator_3
			// 
			this.tss_Separator_3.Name = "tss_Separator_3";
			this.tss_Separator_3.Size = new System.Drawing.Size(194, 6);
			// 
			// tb_Search
			// 
			this.tb_Search.Location = new System.Drawing.Point(29, 6);
			this.tb_Search.Name = "tb_Search";
			this.tb_Search.Size = new System.Drawing.Size(150, 20);
			this.tb_Search.TabIndex = 0;
			this.tb_Search.TextChanged += new System.EventHandler(this.GetPasswords);
			// 
			// btnAdd
			// 
			this.btnAdd.Image = global::VirtualWork.WinForms.Properties.Resources.add;
			this.btnAdd.Location = new System.Drawing.Point(3, 5);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(23, 23);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// tsmiShowPassword
			// 
			this.tsmiShowPassword.Image = global::VirtualWork.WinForms.Properties.Resources.eye;
			this.tsmiShowPassword.Name = "tsmiShowPassword";
			this.tsmiShowPassword.Size = new System.Drawing.Size(197, 22);
			this.tsmiShowPassword.Text = "Show password";
			this.tsmiShowPassword.Click += new System.EventHandler(this.Tsmi_ShowPassword_Click);
			// 
			// tsmiEdit
			// 
			this.tsmiEdit.Image = global::VirtualWork.WinForms.Properties.Resources.key_modify;
			this.tsmiEdit.Name = "tsmiEdit";
			this.tsmiEdit.Size = new System.Drawing.Size(197, 22);
			this.tsmiEdit.Text = "Edit";
			this.tsmiEdit.Click += new System.EventHandler(this.Tsmi_Edit_Click);
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Image = global::VirtualWork.WinForms.Properties.Resources.key_delete;
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.Size = new System.Drawing.Size(197, 22);
			this.tsmiDelete.Text = "Delete";
			this.tsmiDelete.Click += new System.EventHandler(this.Tsmi_Delete_Click);
			// 
			// tsmiVisitLink
			// 
			this.tsmiVisitLink.Image = global::VirtualWork.WinForms.Properties.Resources.link;
			this.tsmiVisitLink.Name = "tsmiVisitLink";
			this.tsmiVisitLink.Size = new System.Drawing.Size(197, 22);
			this.tsmiVisitLink.Text = "Visit link";
			this.tsmiVisitLink.Click += new System.EventHandler(this.Tsmi_VisitLink_Click);
			// 
			// tsmiVisitAlternativeLink
			// 
			this.tsmiVisitAlternativeLink.Image = global::VirtualWork.WinForms.Properties.Resources.link__2_;
			this.tsmiVisitAlternativeLink.Name = "tsmiVisitAlternativeLink";
			this.tsmiVisitAlternativeLink.Size = new System.Drawing.Size(197, 22);
			this.tsmiVisitAlternativeLink.Text = "Visit alternative link";
			this.tsmiVisitAlternativeLink.Click += new System.EventHandler(this.Tsmi_VisitLoginLink_Click);
			// 
			// PasswordManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1090, 450);
			this.Controls.Add(this.p_Main);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PasswordManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Password manager";
			this.Shown += new System.EventHandler(this.PasswordManager_Shown);
			this.p_Main.ResumeLayout(false);
			this.p_Main.PerformLayout();
			this.cms_Menu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ColumnHeader ch_0_DisplayedName;
		private System.Windows.Forms.ColumnHeader ch_1_Username;
		private System.Windows.Forms.ColumnHeader ch_2_Password;
		private System.Windows.Forms.ColumnHeader ch_3_Link;
		private System.Windows.Forms.ColumnHeader ch_4_LoginLink;
		private System.Windows.Forms.ColumnHeader ch_5_Group;
		private System.Windows.Forms.ColumnHeader ch_6_ExtraInformation;
		private System.Windows.Forms.Panel p_Main;
		private System.Windows.Forms.ListView lvCredentials;
		private System.Windows.Forms.TextBox tb_Search;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ColumnHeader chUsername;
		private System.Windows.Forms.ColumnHeader chPassword;
		private System.Windows.Forms.ColumnHeader chLink;
		private System.Windows.Forms.ColumnHeader chAlternativeLink;
		private System.Windows.Forms.ColumnHeader chGroup;
		private System.Windows.Forms.ColumnHeader chExtraInformation;
		private System.Windows.Forms.ContextMenuStrip cms_Menu;
		private System.Windows.Forms.ToolStripMenuItem tsmiCopyUsername;
		private System.Windows.Forms.ToolStripMenuItem tsmiCopyPassword;
		private System.Windows.Forms.ToolStripMenuItem tsmiCopyExtraInformation;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowPassword;
		private System.Windows.Forms.ToolStripSeparator tss_Separator_2;
		private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
		private System.Windows.Forms.ToolStripSeparator tss_Separator_3;
		private System.Windows.Forms.ToolStripMenuItem tsmiVisitLink;
		private System.Windows.Forms.ToolStripMenuItem tsmiVisitAlternativeLink;
		private System.Windows.Forms.ComboBox cbGroup;
		private System.Windows.Forms.Button btnAdd;
	}
}