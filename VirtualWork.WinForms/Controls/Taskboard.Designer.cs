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
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.pToDo = new System.Windows.Forms.Panel();
			this.pDone = new System.Windows.Forms.Panel();
			this.lblDone = new System.Windows.Forms.Label();
			this.pVerification = new System.Windows.Forms.Panel();
			this.pReview = new System.Windows.Forms.Panel();
			this.lblVerification = new System.Windows.Forms.Label();
			this.lblReview = new System.Windows.Forms.Label();
			this.pInProgress = new System.Windows.Forms.Panel();
			this.lblInProgress = new System.Windows.Forms.Label();
			this.lblToDo = new System.Windows.Forms.Label();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
			this.tableLayoutPanel.ColumnCount = 5;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.99999F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.00001F));
			this.tableLayoutPanel.Controls.Add(this.pToDo, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.pDone, 4, 1);
			this.tableLayoutPanel.Controls.Add(this.lblDone, 4, 0);
			this.tableLayoutPanel.Controls.Add(this.pVerification, 3, 1);
			this.tableLayoutPanel.Controls.Add(this.pReview, 2, 1);
			this.tableLayoutPanel.Controls.Add(this.lblVerification, 3, 0);
			this.tableLayoutPanel.Controls.Add(this.lblReview, 2, 0);
			this.tableLayoutPanel.Controls.Add(this.pInProgress, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.lblInProgress, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.lblToDo, 0, 0);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 2;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(804, 293);
			this.tableLayoutPanel.TabIndex = 0;
			this.tableLayoutPanel.SizeChanged += new System.EventHandler(this.TableLayoutPanel_SizeChanged);
			// 
			// pToDo
			// 
			this.pToDo.AllowDrop = true;
			this.pToDo.AutoScroll = true;
			this.pToDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pToDo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pToDo.Location = new System.Drawing.Point(6, 39);
			this.pToDo.Name = "pToDo";
			this.pToDo.Size = new System.Drawing.Size(151, 254);
			this.pToDo.TabIndex = 2;
			this.pToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
			this.pToDo.DragOver += new System.Windows.Forms.DragEventHandler(this.Panel_DragOver);
			// 
			// pDone
			// 
			this.pDone.AllowDrop = true;
			this.pDone.AutoScroll = true;
			this.pDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pDone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pDone.Location = new System.Drawing.Point(646, 39);
			this.pDone.Name = "pDone";
			this.pDone.Size = new System.Drawing.Size(152, 254);
			this.pDone.TabIndex = 3;
			this.pDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
			this.pDone.DragOver += new System.Windows.Forms.DragEventHandler(this.Panel_DragOver);
			// 
			// lblDone
			// 
			this.lblDone.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDone.AutoSize = true;
			this.lblDone.Location = new System.Drawing.Point(646, 11);
			this.lblDone.Name = "lblDone";
			this.lblDone.Size = new System.Drawing.Size(33, 13);
			this.lblDone.TabIndex = 4;
			this.lblDone.Text = "Done";
			// 
			// pVerification
			// 
			this.pVerification.AllowDrop = true;
			this.pVerification.AutoScroll = true;
			this.pVerification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pVerification.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pVerification.Location = new System.Drawing.Point(486, 39);
			this.pVerification.Name = "pVerification";
			this.pVerification.Size = new System.Drawing.Size(151, 254);
			this.pVerification.TabIndex = 2;
			this.pVerification.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
			this.pVerification.DragOver += new System.Windows.Forms.DragEventHandler(this.Panel_DragOver);
			// 
			// pReview
			// 
			this.pReview.AllowDrop = true;
			this.pReview.AutoScroll = true;
			this.pReview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pReview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pReview.Location = new System.Drawing.Point(326, 39);
			this.pReview.Name = "pReview";
			this.pReview.Size = new System.Drawing.Size(151, 254);
			this.pReview.TabIndex = 2;
			this.pReview.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
			this.pReview.DragOver += new System.Windows.Forms.DragEventHandler(this.Panel_DragOver);
			// 
			// lblVerification
			// 
			this.lblVerification.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblVerification.AutoSize = true;
			this.lblVerification.Location = new System.Drawing.Point(486, 11);
			this.lblVerification.Name = "lblVerification";
			this.lblVerification.Size = new System.Drawing.Size(59, 13);
			this.lblVerification.TabIndex = 3;
			this.lblVerification.Text = "Verification";
			// 
			// lblReview
			// 
			this.lblReview.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblReview.AutoSize = true;
			this.lblReview.Location = new System.Drawing.Point(326, 11);
			this.lblReview.Name = "lblReview";
			this.lblReview.Size = new System.Drawing.Size(43, 13);
			this.lblReview.TabIndex = 2;
			this.lblReview.Text = "Review";
			// 
			// pInProgress
			// 
			this.pInProgress.AllowDrop = true;
			this.pInProgress.AutoScroll = true;
			this.pInProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pInProgress.Location = new System.Drawing.Point(166, 39);
			this.pInProgress.Name = "pInProgress";
			this.pInProgress.Size = new System.Drawing.Size(151, 254);
			this.pInProgress.TabIndex = 2;
			this.pInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
			this.pInProgress.DragOver += new System.Windows.Forms.DragEventHandler(this.Panel_DragOver);
			// 
			// lblInProgress
			// 
			this.lblInProgress.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblInProgress.AutoSize = true;
			this.lblInProgress.Location = new System.Drawing.Point(166, 11);
			this.lblInProgress.Name = "lblInProgress";
			this.lblInProgress.Size = new System.Drawing.Size(59, 13);
			this.lblInProgress.TabIndex = 1;
			this.lblInProgress.Text = "In progress";
			// 
			// lblToDo
			// 
			this.lblToDo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblToDo.AutoSize = true;
			this.lblToDo.Location = new System.Drawing.Point(6, 11);
			this.lblToDo.Name = "lblToDo";
			this.lblToDo.Size = new System.Drawing.Size(35, 13);
			this.lblToDo.TabIndex = 0;
			this.lblToDo.Text = "To do";
			// 
			// Taskboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.tableLayoutPanel);
			this.Name = "Taskboard";
			this.Size = new System.Drawing.Size(804, 293);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label lblToDo;
		private System.Windows.Forms.Label lblDone;
		private System.Windows.Forms.Label lblVerification;
		private System.Windows.Forms.Label lblReview;
		private System.Windows.Forms.Label lblInProgress;
		private System.Windows.Forms.Panel pInProgress;
		private System.Windows.Forms.Panel pReview;
		private System.Windows.Forms.Panel pVerification;
		private System.Windows.Forms.Panel pDone;
		private System.Windows.Forms.Panel pToDo;
	}
}
