namespace VirtualWork.WinForms.Controls
{
	partial class Taskboard
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblToDo = new System.Windows.Forms.Label();
			this.lblInProgress = new System.Windows.Forms.Label();
			this.lblReview = new System.Windows.Forms.Label();
			this.lblVerification = new System.Windows.Forms.Label();
			this.lblDone = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.99999F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.00001F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.lblDone, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblVerification, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblReview, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblInProgress, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblToDo, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 403);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lblToDo
			// 
			this.lblToDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblToDo.AutoSize = true;
			this.lblToDo.Location = new System.Drawing.Point(6, 11);
			this.lblToDo.Name = "lblToDo";
			this.lblToDo.Size = new System.Drawing.Size(151, 13);
			this.lblToDo.TabIndex = 0;
			this.lblToDo.Text = "To do";
			// 
			// lblInProgress
			// 
			this.lblInProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblInProgress.AutoSize = true;
			this.lblInProgress.Location = new System.Drawing.Point(166, 11);
			this.lblInProgress.Name = "lblInProgress";
			this.lblInProgress.Size = new System.Drawing.Size(151, 13);
			this.lblInProgress.TabIndex = 1;
			this.lblInProgress.Text = "In progress";
			// 
			// lblReview
			// 
			this.lblReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblReview.AutoSize = true;
			this.lblReview.Location = new System.Drawing.Point(326, 11);
			this.lblReview.Name = "lblReview";
			this.lblReview.Size = new System.Drawing.Size(151, 13);
			this.lblReview.TabIndex = 2;
			this.lblReview.Text = "Review";
			// 
			// lblVerification
			// 
			this.lblVerification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblVerification.AutoSize = true;
			this.lblVerification.Location = new System.Drawing.Point(486, 11);
			this.lblVerification.Name = "lblVerification";
			this.lblVerification.Size = new System.Drawing.Size(151, 13);
			this.lblVerification.TabIndex = 3;
			this.lblVerification.Text = "Verification";
			// 
			// lblDone
			// 
			this.lblDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDone.AutoSize = true;
			this.lblDone.Location = new System.Drawing.Point(646, 11);
			this.lblDone.Name = "lblDone";
			this.lblDone.Size = new System.Drawing.Size(152, 13);
			this.lblDone.TabIndex = 4;
			this.lblDone.Text = "Done";
			// 
			// Taskboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Taskboard";
			this.Size = new System.Drawing.Size(804, 403);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblToDo;
		private System.Windows.Forms.Label lblDone;
		private System.Windows.Forms.Label lblVerification;
		private System.Windows.Forms.Label lblReview;
		private System.Windows.Forms.Label lblInProgress;
	}
}
