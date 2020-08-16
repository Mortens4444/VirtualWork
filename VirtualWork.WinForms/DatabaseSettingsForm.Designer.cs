namespace VirtualWork.WinForms
{
	partial class DatabaseSettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseSettingsForm));
			this.pMain = new System.Windows.Forms.Panel();
			this.gbDatabaseOptions = new System.Windows.Forms.GroupBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblSqlServerConnectionString = new System.Windows.Forms.Label();
			this.tbSqlServerConnectionString = new System.Windows.Forms.TextBox();
			this.pMain.SuspendLayout();
			this.gbDatabaseOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.gbDatabaseOptions);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(694, 106);
			this.pMain.TabIndex = 0;
			// 
			// gbDatabaseOptions
			// 
			this.gbDatabaseOptions.BackColor = System.Drawing.Color.Transparent;
			this.gbDatabaseOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.gbDatabaseOptions.Controls.Add(this.btnClose);
			this.gbDatabaseOptions.Controls.Add(this.btnSave);
			this.gbDatabaseOptions.Controls.Add(this.lblSqlServerConnectionString);
			this.gbDatabaseOptions.Controls.Add(this.tbSqlServerConnectionString);
			this.gbDatabaseOptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbDatabaseOptions.Location = new System.Drawing.Point(0, 0);
			this.gbDatabaseOptions.Name = "gbDatabaseOptions";
			this.gbDatabaseOptions.Size = new System.Drawing.Size(694, 106);
			this.gbDatabaseOptions.TabIndex = 0;
			this.gbDatabaseOptions.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(607, 71);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Abort;
			this.btnSave.Location = new System.Drawing.Point(523, 71);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// lblSqlServerConnectionString
			// 
			this.lblSqlServerConnectionString.AutoSize = true;
			this.lblSqlServerConnectionString.BackColor = System.Drawing.Color.Transparent;
			this.lblSqlServerConnectionString.Location = new System.Drawing.Point(11, 22);
			this.lblSqlServerConnectionString.Name = "lblSqlServerConnectionString";
			this.lblSqlServerConnectionString.Size = new System.Drawing.Size(144, 13);
			this.lblSqlServerConnectionString.TabIndex = 1;
			this.lblSqlServerConnectionString.Text = "SQL server connection string";
			// 
			// tbSqlServerConnectionString
			// 
			this.tbSqlServerConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSqlServerConnectionString.Location = new System.Drawing.Point(14, 41);
			this.tbSqlServerConnectionString.Name = "tbSqlServerConnectionString";
			this.tbSqlServerConnectionString.Size = new System.Drawing.Size(668, 20);
			this.tbSqlServerConnectionString.TabIndex = 2;
			this.tbSqlServerConnectionString.Text = "Data Source=.\\SQLEXPRESS;Database=VirtualWorkDb;Integrated Security=true;;Multipl" +
    "eActiveResultSets=True;App=EntityFramework";
			// 
			// DatabaseSettingsForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(694, 106);
			this.Controls.Add(this.pMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(710, 145);
			this.Name = "DatabaseSettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Database settings";
			this.pMain.ResumeLayout(false);
			this.gbDatabaseOptions.ResumeLayout(false);
			this.gbDatabaseOptions.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.GroupBox gbDatabaseOptions;
		private System.Windows.Forms.Label lblSqlServerConnectionString;
		private System.Windows.Forms.TextBox tbSqlServerConnectionString;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
	}
}