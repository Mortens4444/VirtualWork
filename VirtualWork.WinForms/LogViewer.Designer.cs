namespace VirtualWork.WinForms
{
	partial class LogViewer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogViewer));
			this.pMain = new System.Windows.Forms.Panel();
			this.pHeader = new System.Windows.Forms.Panel();
			this.pBody = new System.Windows.Forms.Panel();
			this.lvLogs = new System.Windows.Forms.ListView();
			this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chLogLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pMain.SuspendLayout();
			this.pBody.SuspendLayout();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.pBody);
			this.pMain.Controls.Add(this.pHeader);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(800, 450);
			this.pMain.TabIndex = 0;
			// 
			// pHeader
			// 
			this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pHeader.Location = new System.Drawing.Point(0, 0);
			this.pHeader.Name = "pHeader";
			this.pHeader.Size = new System.Drawing.Size(800, 72);
			this.pHeader.TabIndex = 0;
			this.pHeader.Visible = false;
			// 
			// pBody
			// 
			this.pBody.Controls.Add(this.lvLogs);
			this.pBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pBody.Location = new System.Drawing.Point(0, 72);
			this.pBody.Name = "pBody";
			this.pBody.Size = new System.Drawing.Size(800, 378);
			this.pBody.TabIndex = 1;
			// 
			// lvLogs
			// 
			this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chUser,
            this.chLogLevel,
            this.chMessage});
			this.lvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvLogs.FullRowSelect = true;
			this.lvLogs.HideSelection = false;
			this.lvLogs.Location = new System.Drawing.Point(0, 0);
			this.lvLogs.Name = "lvLogs";
			this.lvLogs.Size = new System.Drawing.Size(800, 378);
			this.lvLogs.TabIndex = 0;
			this.lvLogs.UseCompatibleStateImageBehavior = false;
			this.lvLogs.View = System.Windows.Forms.View.Details;
			// 
			// chId
			// 
			this.chId.Text = "Id";
			// 
			// chUser
			// 
			this.chUser.Text = "User";
			// 
			// chLogLevel
			// 
			this.chLogLevel.Text = "Log level";
			// 
			// chMessage
			// 
			this.chMessage.Text = "Message";
			this.chMessage.Width = 613;
			// 
			// LogViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LogViewer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Log viewer";
			this.Shown += new System.EventHandler(this.LogViewer_Shown);
			this.pMain.ResumeLayout(false);
			this.pBody.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Panel pBody;
		private System.Windows.Forms.Panel pHeader;
		private System.Windows.Forms.ListView lvLogs;
		private System.Windows.Forms.ColumnHeader chId;
		private System.Windows.Forms.ColumnHeader chUser;
		private System.Windows.Forms.ColumnHeader chLogLevel;
		private System.Windows.Forms.ColumnHeader chMessage;
	}
}