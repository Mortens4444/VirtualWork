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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogViewer));
			this.pMain = new System.Windows.Forms.Panel();
			this.pBody = new System.Windows.Forms.Panel();
			this.lvLogs = new System.Windows.Forms.ListView();
			this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chLogLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiExceptionViewer = new System.Windows.Forms.ToolStripMenuItem();
			this.pHeader = new System.Windows.Forms.Panel();
			this.lblUser = new System.Windows.Forms.Label();
			this.cbUser = new System.Windows.Forms.ComboBox();
			this.lblLogLevel = new System.Windows.Forms.Label();
			this.cbLogLevel = new System.Windows.Forms.ComboBox();
			this.lblMessage = new System.Windows.Forms.Label();
			this.tbMessage = new System.Windows.Forms.TextBox();
			this.pMain.SuspendLayout();
			this.pBody.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			this.pHeader.SuspendLayout();
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
			// pBody
			// 
			this.pBody.Controls.Add(this.lvLogs);
			this.pBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pBody.Location = new System.Drawing.Point(0, 46);
			this.pBody.Name = "pBody";
			this.pBody.Size = new System.Drawing.Size(800, 404);
			this.pBody.TabIndex = 1;
			// 
			// lvLogs
			// 
			this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chUser,
            this.chLogLevel,
            this.chMessage});
			this.lvLogs.ContextMenuStrip = this.contextMenuStrip;
			this.lvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvLogs.FullRowSelect = true;
			this.lvLogs.HideSelection = false;
			this.lvLogs.Location = new System.Drawing.Point(0, 0);
			this.lvLogs.Name = "lvLogs";
			this.lvLogs.Size = new System.Drawing.Size(800, 404);
			this.lvLogs.TabIndex = 10;
			this.lvLogs.UseCompatibleStateImageBehavior = false;
			this.lvLogs.View = System.Windows.Forms.View.Details;
			this.lvLogs.VirtualMode = true;
			this.lvLogs.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.LvLogs_RetrieveVirtualItem);
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
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExceptionViewer});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(164, 26);
			this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip_Opening);
			// 
			// tsmiExceptionViewer
			// 
			this.tsmiExceptionViewer.Image = global::VirtualWork.WinForms.Properties.Resources.bug;
			this.tsmiExceptionViewer.Name = "tsmiExceptionViewer";
			this.tsmiExceptionViewer.Size = new System.Drawing.Size(163, 22);
			this.tsmiExceptionViewer.Text = "Exception viewer";
			this.tsmiExceptionViewer.Click += new System.EventHandler(this.TsmiExceptionViewer_Click);
			// 
			// pHeader
			// 
			this.pHeader.Controls.Add(this.lblUser);
			this.pHeader.Controls.Add(this.cbUser);
			this.pHeader.Controls.Add(this.lblLogLevel);
			this.pHeader.Controls.Add(this.cbLogLevel);
			this.pHeader.Controls.Add(this.lblMessage);
			this.pHeader.Controls.Add(this.tbMessage);
			this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pHeader.Location = new System.Drawing.Point(0, 0);
			this.pHeader.Name = "pHeader";
			this.pHeader.Size = new System.Drawing.Size(800, 46);
			this.pHeader.TabIndex = 0;
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(56, 5);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(29, 13);
			this.lblUser.TabIndex = 5;
			this.lblUser.Tag = "S";
			this.lblUser.Text = "User";
			// 
			// cbUser
			// 
			this.cbUser.FormattingEnabled = true;
			this.cbUser.Location = new System.Drawing.Point(59, 20);
			this.cbUser.Name = "cbUser";
			this.cbUser.Size = new System.Drawing.Size(60, 21);
			this.cbUser.TabIndex = 4;
			this.cbUser.SelectedIndexChanged += new System.EventHandler(this.FiltersChanged);
			this.cbUser.TextChanged += new System.EventHandler(this.FiltersChanged);
			// 
			// lblLogLevel
			// 
			this.lblLogLevel.AutoSize = true;
			this.lblLogLevel.Location = new System.Drawing.Point(118, 5);
			this.lblLogLevel.Name = "lblLogLevel";
			this.lblLogLevel.Size = new System.Drawing.Size(50, 13);
			this.lblLogLevel.TabIndex = 3;
			this.lblLogLevel.Tag = "S";
			this.lblLogLevel.Text = "Log level";
			// 
			// cbLogLevel
			// 
			this.cbLogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLogLevel.FormattingEnabled = true;
			this.cbLogLevel.Location = new System.Drawing.Point(121, 20);
			this.cbLogLevel.Name = "cbLogLevel";
			this.cbLogLevel.Size = new System.Drawing.Size(60, 21);
			this.cbLogLevel.TabIndex = 2;
			this.cbLogLevel.SelectedIndexChanged += new System.EventHandler(this.FiltersChanged);
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Location = new System.Drawing.Point(180, 5);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(50, 13);
			this.lblMessage.TabIndex = 1;
			this.lblMessage.Tag = "S";
			this.lblMessage.Text = "Message";
			// 
			// tbMessage
			// 
			this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbMessage.Location = new System.Drawing.Point(183, 21);
			this.tbMessage.Name = "tbMessage";
			this.tbMessage.Size = new System.Drawing.Size(614, 20);
			this.tbMessage.TabIndex = 0;
			this.tbMessage.TextChanged += new System.EventHandler(this.FiltersChanged);
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
			this.pMain.ResumeLayout(false);
			this.pBody.ResumeLayout(false);
			this.contextMenuStrip.ResumeLayout(false);
			this.pHeader.ResumeLayout(false);
			this.pHeader.PerformLayout();
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
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem tsmiExceptionViewer;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.TextBox tbMessage;
		private System.Windows.Forms.ComboBox cbLogLevel;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.ComboBox cbUser;
		private System.Windows.Forms.Label lblLogLevel;
	}
}