namespace VirtualWork.WinForms
{
	partial class AddGroupForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGroupForm));
			this.pMain = new System.Windows.Forms.Panel();
			this.gb_Permissions = new System.Windows.Forms.GroupBox();
			this.lvGrantedPermissions = new System.Windows.Forms.ListView();
			this.chGrantedPermissions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvAvailablePermissions = new System.Windows.Forms.ListView();
			this.chAvailablePermissions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnRemoveSelectedPermissions = new System.Windows.Forms.Button();
			this.btnAddSelectedPermissions = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.gb_GeneralDetails = new System.Windows.Forms.GroupBox();
			this.rtbDescription = new System.Windows.Forms.RichTextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.tbGroupName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.ch_SelectableOperationsAndCameras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_ExecuteableOperationsAndVisibleCameras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pMain.SuspendLayout();
			this.gb_Permissions.SuspendLayout();
			this.gb_GeneralDetails.SuspendLayout();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.gb_Permissions);
			this.pMain.Controls.Add(this.btnCancel);
			this.pMain.Controls.Add(this.btnAdd);
			this.pMain.Controls.Add(this.gb_GeneralDetails);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(800, 428);
			this.pMain.TabIndex = 0;
			// 
			// gb_Permissions
			// 
			this.gb_Permissions.Controls.Add(this.lvGrantedPermissions);
			this.gb_Permissions.Controls.Add(this.lvAvailablePermissions);
			this.gb_Permissions.Controls.Add(this.btnRemoveSelectedPermissions);
			this.gb_Permissions.Controls.Add(this.btnAddSelectedPermissions);
			this.gb_Permissions.Dock = System.Windows.Forms.DockStyle.Top;
			this.gb_Permissions.Location = new System.Drawing.Point(0, 145);
			this.gb_Permissions.Name = "gb_Permissions";
			this.gb_Permissions.Size = new System.Drawing.Size(800, 242);
			this.gb_Permissions.TabIndex = 5;
			this.gb_Permissions.TabStop = false;
			this.gb_Permissions.Text = "Permissions";
			// 
			// lvGrantedPermissions
			// 
			this.lvGrantedPermissions.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lvGrantedPermissions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGrantedPermissions});
			this.lvGrantedPermissions.HideSelection = false;
			this.lvGrantedPermissions.Location = new System.Drawing.Point(435, 19);
			this.lvGrantedPermissions.Name = "lvGrantedPermissions";
			this.lvGrantedPermissions.Size = new System.Drawing.Size(359, 204);
			this.lvGrantedPermissions.TabIndex = 9;
			this.lvGrantedPermissions.UseCompatibleStateImageBehavior = false;
			this.lvGrantedPermissions.View = System.Windows.Forms.View.Details;
			// 
			// chGrantedPermissions
			// 
			this.chGrantedPermissions.Text = "Granted permissions";
			this.chGrantedPermissions.Width = 355;
			// 
			// lvAvailablePermissions
			// 
			this.lvAvailablePermissions.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lvAvailablePermissions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAvailablePermissions});
			this.lvAvailablePermissions.HideSelection = false;
			this.lvAvailablePermissions.Location = new System.Drawing.Point(6, 19);
			this.lvAvailablePermissions.Name = "lvAvailablePermissions";
			this.lvAvailablePermissions.Size = new System.Drawing.Size(359, 204);
			this.lvAvailablePermissions.TabIndex = 6;
			this.lvAvailablePermissions.UseCompatibleStateImageBehavior = false;
			this.lvAvailablePermissions.View = System.Windows.Forms.View.Details;
			// 
			// chAvailablePermissions
			// 
			this.chAvailablePermissions.Text = "Available permissions";
			this.chAvailablePermissions.Width = 355;
			// 
			// btnRemoveSelectedPermissions
			// 
			this.btnRemoveSelectedPermissions.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnRemoveSelectedPermissions.Image = global::VirtualWork.WinForms.Properties.Resources.del;
			this.btnRemoveSelectedPermissions.Location = new System.Drawing.Point(386, 120);
			this.btnRemoveSelectedPermissions.Name = "btnRemoveSelectedPermissions";
			this.btnRemoveSelectedPermissions.Size = new System.Drawing.Size(28, 23);
			this.btnRemoveSelectedPermissions.TabIndex = 8;
			this.btnRemoveSelectedPermissions.UseVisualStyleBackColor = true;
			// 
			// btnAddSelectedPermissions
			// 
			this.btnAddSelectedPermissions.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnAddSelectedPermissions.Image = global::VirtualWork.WinForms.Properties.Resources.add;
			this.btnAddSelectedPermissions.Location = new System.Drawing.Point(386, 91);
			this.btnAddSelectedPermissions.Name = "btnAddSelectedPermissions";
			this.btnAddSelectedPermissions.Size = new System.Drawing.Size(28, 23);
			this.btnAddSelectedPermissions.TabIndex = 7;
			this.btnAddSelectedPermissions.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(719, 393);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAdd.Enabled = false;
			this.btnAdd.Location = new System.Drawing.Point(638, 393);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// gb_GeneralDetails
			// 
			this.gb_GeneralDetails.Controls.Add(this.rtbDescription);
			this.gb_GeneralDetails.Controls.Add(this.lblDescription);
			this.gb_GeneralDetails.Controls.Add(this.tbGroupName);
			this.gb_GeneralDetails.Controls.Add(this.lblName);
			this.gb_GeneralDetails.Dock = System.Windows.Forms.DockStyle.Top;
			this.gb_GeneralDetails.Location = new System.Drawing.Point(0, 0);
			this.gb_GeneralDetails.Name = "gb_GeneralDetails";
			this.gb_GeneralDetails.Size = new System.Drawing.Size(800, 145);
			this.gb_GeneralDetails.TabIndex = 0;
			this.gb_GeneralDetails.TabStop = false;
			this.gb_GeneralDetails.Text = "General details";
			// 
			// rtbDescription
			// 
			this.rtbDescription.AcceptsTab = true;
			this.rtbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbDescription.Location = new System.Drawing.Point(6, 76);
			this.rtbDescription.Name = "rtbDescription";
			this.rtbDescription.Size = new System.Drawing.Size(788, 63);
			this.rtbDescription.TabIndex = 4;
			this.rtbDescription.Text = "";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(6, 60);
			this.lblDescription.MaximumSize = new System.Drawing.Size(117, 13);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.TabIndex = 3;
			this.lblDescription.Text = "Description";
			// 
			// tbGroupName
			// 
			this.tbGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbGroupName.Location = new System.Drawing.Point(6, 32);
			this.tbGroupName.MaxLength = 100;
			this.tbGroupName.Name = "tbGroupName";
			this.tbGroupName.Size = new System.Drawing.Size(788, 20);
			this.tbGroupName.TabIndex = 2;
			this.tbGroupName.TextChanged += new System.EventHandler(this.NameChanged);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(3, 16);
			this.lblName.MaximumSize = new System.Drawing.Size(117, 13);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name";
			// 
			// ch_SelectableOperationsAndCameras
			// 
			this.ch_SelectableOperationsAndCameras.Text = "Selectable operations and cameras";
			this.ch_SelectableOperationsAndCameras.Width = 270;
			// 
			// ch_ExecuteableOperationsAndVisibleCameras
			// 
			this.ch_ExecuteableOperationsAndVisibleCameras.Text = "Executeable operations and visible cameras";
			this.ch_ExecuteableOperationsAndVisibleCameras.Width = 270;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Selectable operations and cameras";
			this.columnHeader1.Width = 270;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Selectable operations and cameras";
			this.columnHeader2.Width = 270;
			// 
			// AddGroupForm
			// 
			this.AcceptButton = this.btnAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(800, 428);
			this.Controls.Add(this.pMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(816, 467);
			this.Name = "AddGroupForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add group";
			this.pMain.ResumeLayout(false);
			this.gb_Permissions.ResumeLayout(false);
			this.gb_GeneralDetails.ResumeLayout(false);
			this.gb_GeneralDetails.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.GroupBox gb_GeneralDetails;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox tbGroupName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.RichTextBox rtbDescription;
		private System.Windows.Forms.GroupBox gb_Permissions;
		private System.Windows.Forms.Button btnRemoveSelectedPermissions;
		private System.Windows.Forms.Button btnAddSelectedPermissions;
		private System.Windows.Forms.ColumnHeader ch_SelectableOperationsAndCameras;
		private System.Windows.Forms.ColumnHeader ch_ExecuteableOperationsAndVisibleCameras;
		private System.Windows.Forms.ListView lvGrantedPermissions;
		private System.Windows.Forms.ColumnHeader chGrantedPermissions;
		private System.Windows.Forms.ListView lvAvailablePermissions;
		private System.Windows.Forms.ColumnHeader chAvailablePermissions;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
	}
}