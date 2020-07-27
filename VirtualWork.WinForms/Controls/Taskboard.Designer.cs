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
			this.lblDone = new System.Windows.Forms.Label();
			this.lblVerification = new System.Windows.Forms.Label();
			this.lblReview = new System.Windows.Forms.Label();
			this.lblInProgress = new System.Windows.Forms.Label();
			this.lblToDo = new System.Windows.Forms.Label();
			this.tcToDo = new VirtualWork.WinForms.Controls.TaskboardColumn();
			this.tcInProgress = new VirtualWork.WinForms.Controls.TaskboardColumn();
			this.tcReview = new VirtualWork.WinForms.Controls.TaskboardColumn();
			this.tcVerification = new VirtualWork.WinForms.Controls.TaskboardColumn();
			this.tcDone = new VirtualWork.WinForms.Controls.TaskboardColumn();
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
			this.tableLayoutPanel.Controls.Add(this.lblDone, 4, 0);
			this.tableLayoutPanel.Controls.Add(this.lblVerification, 3, 0);
			this.tableLayoutPanel.Controls.Add(this.lblReview, 2, 0);
			this.tableLayoutPanel.Controls.Add(this.lblInProgress, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.lblToDo, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.tcToDo, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.tcInProgress, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.tcReview, 2, 1);
			this.tableLayoutPanel.Controls.Add(this.tcVerification, 3, 1);
			this.tableLayoutPanel.Controls.Add(this.tcDone, 4, 1);
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
			// tcToDo
			// 
			this.tcToDo.ColumnStates = new VirtualWork.Interfaces.Enums.IssueState[] {
        VirtualWork.Interfaces.Enums.IssueState.ToDo};
			this.tcToDo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcToDo.Location = new System.Drawing.Point(6, 39);
			this.tcToDo.Name = "tcToDo";
			this.tcToDo.Size = new System.Drawing.Size(151, 254);
			this.tcToDo.TabIndex = 5;
			// 
			// tcInProgress
			// 
			this.tcInProgress.ColumnStates = new VirtualWork.Interfaces.Enums.IssueState[] {
        VirtualWork.Interfaces.Enums.IssueState.InProgress};
			this.tcInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcInProgress.Location = new System.Drawing.Point(166, 39);
			this.tcInProgress.Name = "tcInProgress";
			this.tcInProgress.Size = new System.Drawing.Size(151, 254);
			this.tcInProgress.TabIndex = 6;
			// 
			// tcReview
			// 
			this.tcReview.ColumnStates = new VirtualWork.Interfaces.Enums.IssueState[] {
        VirtualWork.Interfaces.Enums.IssueState.UnderReview};
			this.tcReview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcReview.Location = new System.Drawing.Point(326, 39);
			this.tcReview.Name = "tcReview";
			this.tcReview.Size = new System.Drawing.Size(151, 254);
			this.tcReview.TabIndex = 7;
			// 
			// tcVerification
			// 
			this.tcVerification.ColumnStates = new VirtualWork.Interfaces.Enums.IssueState[] {
        VirtualWork.Interfaces.Enums.IssueState.UnderVerification};
			this.tcVerification.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcVerification.Location = new System.Drawing.Point(486, 39);
			this.tcVerification.Name = "tcVerification";
			this.tcVerification.Size = new System.Drawing.Size(151, 254);
			this.tcVerification.TabIndex = 8;
			// 
			// tcDone
			// 
			this.tcDone.ColumnStates = new VirtualWork.Interfaces.Enums.IssueState[] {
        VirtualWork.Interfaces.Enums.IssueState.Done,
        VirtualWork.Interfaces.Enums.IssueState.Cancelled};
			this.tcDone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcDone.Location = new System.Drawing.Point(646, 39);
			this.tcDone.Name = "tcDone";
			this.tcDone.Size = new System.Drawing.Size(152, 254);
			this.tcDone.TabIndex = 9;
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
		private TaskboardColumn tcToDo;
		private TaskboardColumn tcInProgress;
		private TaskboardColumn tcReview;
		private TaskboardColumn tcVerification;
		private TaskboardColumn tcDone;
	}
}
