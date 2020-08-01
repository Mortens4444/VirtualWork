namespace VirtualWork.WinForms.Controls
{
	partial class IssueView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmiBlocked = new System.Windows.Forms.ToolStripMenuItem();
			this.cmiVerified = new System.Windows.Forms.ToolStripMenuItem();
			this.cmiCancel = new System.Windows.Forms.ToolStripMenuItem();
			this.tslTitle = new System.Windows.Forms.ToolStripLabel();
			this.rtbDescription = new System.Windows.Forms.RichTextBox();
			this.toolStrip.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.BackColor = System.Drawing.Color.DimGray;
			this.toolStrip.ContextMenuStrip = this.contextMenuStrip;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTitle});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(146, 25);
			this.toolStrip.TabIndex = 2;
			this.toolStrip.Text = "toolStrip1";
			this.toolStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStrip_MouseDown);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiBlocked,
            this.cmiVerified,
            this.cmiCancel});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(181, 92);
			// 
			// cmiBlocked
			// 
			this.cmiBlocked.CheckOnClick = true;
			this.cmiBlocked.Name = "cmiBlocked";
			this.cmiBlocked.Size = new System.Drawing.Size(180, 22);
			this.cmiBlocked.Text = "Blocked";
			this.cmiBlocked.CheckedChanged += new System.EventHandler(this.CmiBlocked_CheckedChanged);
			// 
			// cmiVerified
			// 
			this.cmiVerified.CheckOnClick = true;
			this.cmiVerified.Name = "cmiVerified";
			this.cmiVerified.Size = new System.Drawing.Size(180, 22);
			this.cmiVerified.Text = "Verified";
			this.cmiVerified.Click += new System.EventHandler(this.CmiVerified_Click);
			// 
			// cmiCancel
			// 
			this.cmiCancel.Name = "cmiCancel";
			this.cmiCancel.Size = new System.Drawing.Size(180, 22);
			this.cmiCancel.Text = "Cancel issue";
			this.cmiCancel.Click += new System.EventHandler(this.CmiCancel_Click);
			// 
			// tslTitle
			// 
			this.tslTitle.Name = "tslTitle";
			this.tslTitle.Size = new System.Drawing.Size(50, 22);
			this.tslTitle.Text = "Id - Title";
			this.tslTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStrip_MouseDown);
			this.tslTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TslTitle_MouseUp);
			// 
			// rtbDescription
			// 
			this.rtbDescription.BackColor = System.Drawing.Color.DarkGray;
			this.rtbDescription.ContextMenuStrip = this.contextMenuStrip;
			this.rtbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbDescription.Location = new System.Drawing.Point(0, 25);
			this.rtbDescription.Name = "rtbDescription";
			this.rtbDescription.Size = new System.Drawing.Size(146, 121);
			this.rtbDescription.TabIndex = 3;
			this.rtbDescription.Text = "";
			// 
			// IssueView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Controls.Add(this.rtbDescription);
			this.Controls.Add(this.toolStrip);
			this.Name = "IssueView";
			this.Size = new System.Drawing.Size(146, 146);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripLabel tslTitle;
		private System.Windows.Forms.RichTextBox rtbDescription;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem cmiBlocked;
		private System.Windows.Forms.ToolStripMenuItem cmiVerified;
		private System.Windows.Forms.ToolStripMenuItem cmiCancel;
	}
}
