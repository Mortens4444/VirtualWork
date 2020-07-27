namespace VirtualWork.WinForms.Controls
{
	partial class TaskboardColumn
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
			this.pMain = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.AllowDrop = true;
			this.pMain.AutoScroll = true;
			this.pMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(150, 150);
			this.pMain.TabIndex = 0;
			this.pMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
			this.pMain.DragOver += new System.Windows.Forms.DragEventHandler(this.Panel_DragOver);
			// 
			// TaskboardColumn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pMain);
			this.Name = "TaskboardColumn";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
	}
}
