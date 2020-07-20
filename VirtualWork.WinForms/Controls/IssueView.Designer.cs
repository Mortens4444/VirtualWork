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
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.tslTitle = new System.Windows.Forms.ToolStripLabel();
			this.rtbDescription = new System.Windows.Forms.RichTextBox();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.BackColor = System.Drawing.Color.DimGray;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTitle});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(146, 25);
			this.toolStrip.TabIndex = 2;
			this.toolStrip.Text = "toolStrip1";
			// 
			// tslTitle
			// 
			this.tslTitle.Name = "tslTitle";
			this.tslTitle.Size = new System.Drawing.Size(50, 22);
			this.tslTitle.Text = "Id - Title";
			// 
			// rtbDescription
			// 
			this.rtbDescription.BackColor = System.Drawing.Color.DarkGray;
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripLabel tslTitle;
		private System.Windows.Forms.RichTextBox rtbDescription;
	}
}
