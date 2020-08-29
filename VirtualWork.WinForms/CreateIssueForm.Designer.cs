namespace VirtualWork.WinForms
{
	partial class CreateIssueForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateIssueForm));
			this.pMain = new System.Windows.Forms.Panel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tpGeneral = new System.Windows.Forms.TabPage();
			this.gbMain = new System.Windows.Forms.GroupBox();
			this.gbRecurring = new System.Windows.Forms.GroupBox();
			this.lblRepetition = new System.Windows.Forms.Label();
			this.chkExpire = new System.Windows.Forms.CheckBox();
			this.cbRepetitionType = new System.Windows.Forms.ComboBox();
			this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
			this.lblExpirationDate = new System.Windows.Forms.Label();
			this.nudRepetitionValue = new System.Windows.Forms.NumericUpDown();
			this.cbParent = new System.Windows.Forms.ComboBox();
			this.lblParent = new System.Windows.Forms.Label();
			this.cbIssuePriority = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbIssueType = new System.Windows.Forms.ComboBox();
			this.lblIssueType = new System.Windows.Forms.Label();
			this.cbOwnedBy = new System.Windows.Forms.ComboBox();
			this.lblOwnedBy = new System.Windows.Forms.Label();
			this.tbBlocking = new System.Windows.Forms.TextBox();
			this.lblBlocking = new System.Windows.Forms.Label();
			this.tbBlockedBy = new System.Windows.Forms.TextBox();
			this.lblBlockedBy = new System.Windows.Forms.Label();
			this.dtpDueTo = new System.Windows.Forms.DateTimePicker();
			this.lblDueTo = new System.Windows.Forms.Label();
			this.rtbDescription = new System.Windows.Forms.RichTextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.tbTitle = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.tpHistory = new System.Windows.Forms.TabPage();
			this.lvHistory = new System.Windows.Forms.ListView();
			this.chOperation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chOriginator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chOperationTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.pMain.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tpGeneral.SuspendLayout();
			this.gbMain.SuspendLayout();
			this.gbRecurring.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRepetitionValue)).BeginInit();
			this.tpHistory.SuspendLayout();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.tabControl);
			this.pMain.Controls.Add(this.btnCancel);
			this.pMain.Controls.Add(this.btnCreate);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(828, 488);
			this.pMain.TabIndex = 0;
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tpGeneral);
			this.tabControl.Controls.Add(this.tpHistory);
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(828, 452);
			this.tabControl.TabIndex = 0;
			// 
			// tpGeneral
			// 
			this.tpGeneral.Controls.Add(this.gbMain);
			this.tpGeneral.Location = new System.Drawing.Point(4, 22);
			this.tpGeneral.Name = "tpGeneral";
			this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tpGeneral.Size = new System.Drawing.Size(820, 426);
			this.tpGeneral.TabIndex = 0;
			this.tpGeneral.Text = "General";
			this.tpGeneral.UseVisualStyleBackColor = true;
			// 
			// gbMain
			// 
			this.gbMain.Controls.Add(this.gbRecurring);
			this.gbMain.Controls.Add(this.cbParent);
			this.gbMain.Controls.Add(this.lblParent);
			this.gbMain.Controls.Add(this.cbIssuePriority);
			this.gbMain.Controls.Add(this.label1);
			this.gbMain.Controls.Add(this.cbIssueType);
			this.gbMain.Controls.Add(this.lblIssueType);
			this.gbMain.Controls.Add(this.cbOwnedBy);
			this.gbMain.Controls.Add(this.lblOwnedBy);
			this.gbMain.Controls.Add(this.tbBlocking);
			this.gbMain.Controls.Add(this.lblBlocking);
			this.gbMain.Controls.Add(this.tbBlockedBy);
			this.gbMain.Controls.Add(this.lblBlockedBy);
			this.gbMain.Controls.Add(this.dtpDueTo);
			this.gbMain.Controls.Add(this.lblDueTo);
			this.gbMain.Controls.Add(this.rtbDescription);
			this.gbMain.Controls.Add(this.lblDescription);
			this.gbMain.Controls.Add(this.tbTitle);
			this.gbMain.Controls.Add(this.lblTitle);
			this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbMain.Location = new System.Drawing.Point(3, 3);
			this.gbMain.Name = "gbMain";
			this.gbMain.Size = new System.Drawing.Size(814, 420);
			this.gbMain.TabIndex = 0;
			this.gbMain.TabStop = false;
			// 
			// gbRecurring
			// 
			this.gbRecurring.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbRecurring.Controls.Add(this.lblRepetition);
			this.gbRecurring.Controls.Add(this.chkExpire);
			this.gbRecurring.Controls.Add(this.cbRepetitionType);
			this.gbRecurring.Controls.Add(this.dtpExpirationDate);
			this.gbRecurring.Controls.Add(this.lblExpirationDate);
			this.gbRecurring.Controls.Add(this.nudRepetitionValue);
			this.gbRecurring.Location = new System.Drawing.Point(9, 340);
			this.gbRecurring.Name = "gbRecurring";
			this.gbRecurring.Size = new System.Drawing.Size(799, 77);
			this.gbRecurring.TabIndex = 29;
			this.gbRecurring.TabStop = false;
			// 
			// lblRepetition
			// 
			this.lblRepetition.AutoSize = true;
			this.lblRepetition.Location = new System.Drawing.Point(3, 20);
			this.lblRepetition.Name = "lblRepetition";
			this.lblRepetition.Size = new System.Drawing.Size(55, 13);
			this.lblRepetition.TabIndex = 19;
			this.lblRepetition.Text = "Repetition";
			// 
			// chkExpire
			// 
			this.chkExpire.AutoSize = true;
			this.chkExpire.Location = new System.Drawing.Point(289, 19);
			this.chkExpire.Name = "chkExpire";
			this.chkExpire.Size = new System.Drawing.Size(55, 17);
			this.chkExpire.TabIndex = 22;
			this.chkExpire.Text = "Expire";
			this.chkExpire.UseVisualStyleBackColor = true;
			// 
			// cbRepetitionType
			// 
			this.cbRepetitionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRepetitionType.FormattingEnabled = true;
			this.cbRepetitionType.Location = new System.Drawing.Point(53, 40);
			this.cbRepetitionType.Name = "cbRepetitionType";
			this.cbRepetitionType.Size = new System.Drawing.Size(227, 21);
			this.cbRepetitionType.TabIndex = 21;
			this.cbRepetitionType.SelectedIndexChanged += new System.EventHandler(this.CbRepetitionType_SelectedIndexChanged);
			// 
			// dtpExpirationDate
			// 
			this.dtpExpirationDate.CustomFormat = "yyyy.MM.dd. HH:mm";
			this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpExpirationDate.Location = new System.Drawing.Point(403, 40);
			this.dtpExpirationDate.Name = "dtpExpirationDate";
			this.dtpExpirationDate.Size = new System.Drawing.Size(144, 20);
			this.dtpExpirationDate.TabIndex = 24;
			// 
			// lblExpirationDate
			// 
			this.lblExpirationDate.AutoSize = true;
			this.lblExpirationDate.Location = new System.Drawing.Point(286, 46);
			this.lblExpirationDate.Name = "lblExpirationDate";
			this.lblExpirationDate.Size = new System.Drawing.Size(77, 13);
			this.lblExpirationDate.TabIndex = 23;
			this.lblExpirationDate.Text = "Expiration date";
			// 
			// nudRepetitionValue
			// 
			this.nudRepetitionValue.Location = new System.Drawing.Point(6, 42);
			this.nudRepetitionValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudRepetitionValue.Name = "nudRepetitionValue";
			this.nudRepetitionValue.Size = new System.Drawing.Size(41, 20);
			this.nudRepetitionValue.TabIndex = 20;
			this.nudRepetitionValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// cbParent
			// 
			this.cbParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbParent.FormattingEnabled = true;
			this.cbParent.Location = new System.Drawing.Point(101, 300);
			this.cbParent.Name = "cbParent";
			this.cbParent.Size = new System.Drawing.Size(318, 21);
			this.cbParent.TabIndex = 18;
			this.cbParent.SelectedIndexChanged += new System.EventHandler(this.CbEpic_SelectedIndexChanged);
			this.cbParent.SelectionChangeCommitted += new System.EventHandler(this.CbEpic_SelectionChangeCommitted);
			this.cbParent.TextChanged += new System.EventHandler(this.CbEpic_TextChanged);
			// 
			// lblParent
			// 
			this.lblParent.AutoSize = true;
			this.lblParent.Location = new System.Drawing.Point(6, 303);
			this.lblParent.Name = "lblParent";
			this.lblParent.Size = new System.Drawing.Size(38, 13);
			this.lblParent.TabIndex = 17;
			this.lblParent.Text = "Parent";
			// 
			// cbIssuePriority
			// 
			this.cbIssuePriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbIssuePriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbIssuePriority.FormattingEnabled = true;
			this.cbIssuePriority.Location = new System.Drawing.Point(101, 273);
			this.cbIssuePriority.Name = "cbIssuePriority";
			this.cbIssuePriority.Size = new System.Drawing.Size(318, 21);
			this.cbIssuePriority.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 276);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Issue priority";
			// 
			// cbIssueType
			// 
			this.cbIssueType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbIssueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbIssueType.FormattingEnabled = true;
			this.cbIssueType.Location = new System.Drawing.Point(101, 246);
			this.cbIssueType.Name = "cbIssueType";
			this.cbIssueType.Size = new System.Drawing.Size(318, 21);
			this.cbIssueType.TabIndex = 14;
			// 
			// lblIssueType
			// 
			this.lblIssueType.AutoSize = true;
			this.lblIssueType.Location = new System.Drawing.Point(6, 249);
			this.lblIssueType.Name = "lblIssueType";
			this.lblIssueType.Size = new System.Drawing.Size(55, 13);
			this.lblIssueType.TabIndex = 13;
			this.lblIssueType.Text = "Issue type";
			// 
			// cbOwnedBy
			// 
			this.cbOwnedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbOwnedBy.FormattingEnabled = true;
			this.cbOwnedBy.Location = new System.Drawing.Point(101, 219);
			this.cbOwnedBy.Name = "cbOwnedBy";
			this.cbOwnedBy.Size = new System.Drawing.Size(707, 21);
			this.cbOwnedBy.TabIndex = 12;
			this.cbOwnedBy.SelectedIndexChanged += new System.EventHandler(this.CbOwnedBy_SelectedIndexChanged);
			this.cbOwnedBy.SelectionChangeCommitted += new System.EventHandler(this.CbOwnedBy_SelectionChangeCommitted);
			this.cbOwnedBy.TextChanged += new System.EventHandler(this.CbOwnedBy_TextChanged);
			// 
			// lblOwnedBy
			// 
			this.lblOwnedBy.AutoSize = true;
			this.lblOwnedBy.Location = new System.Drawing.Point(6, 222);
			this.lblOwnedBy.Name = "lblOwnedBy";
			this.lblOwnedBy.Size = new System.Drawing.Size(55, 13);
			this.lblOwnedBy.TabIndex = 11;
			this.lblOwnedBy.Text = "Owned by";
			// 
			// tbBlocking
			// 
			this.tbBlocking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbBlocking.Location = new System.Drawing.Point(101, 193);
			this.tbBlocking.Name = "tbBlocking";
			this.tbBlocking.Size = new System.Drawing.Size(707, 20);
			this.tbBlocking.TabIndex = 10;
			// 
			// lblBlocking
			// 
			this.lblBlocking.AutoSize = true;
			this.lblBlocking.Location = new System.Drawing.Point(6, 196);
			this.lblBlocking.Name = "lblBlocking";
			this.lblBlocking.Size = new System.Drawing.Size(48, 13);
			this.lblBlocking.TabIndex = 9;
			this.lblBlocking.Text = "Blocking";
			// 
			// tbBlockedBy
			// 
			this.tbBlockedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbBlockedBy.Location = new System.Drawing.Point(101, 167);
			this.tbBlockedBy.Name = "tbBlockedBy";
			this.tbBlockedBy.Size = new System.Drawing.Size(707, 20);
			this.tbBlockedBy.TabIndex = 8;
			// 
			// lblBlockedBy
			// 
			this.lblBlockedBy.AutoSize = true;
			this.lblBlockedBy.Location = new System.Drawing.Point(6, 170);
			this.lblBlockedBy.Name = "lblBlockedBy";
			this.lblBlockedBy.Size = new System.Drawing.Size(60, 13);
			this.lblBlockedBy.TabIndex = 7;
			this.lblBlockedBy.Text = "Blocked by";
			// 
			// dtpDueTo
			// 
			this.dtpDueTo.CustomFormat = "yyyy.MM.dd. HH:mm";
			this.dtpDueTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDueTo.Location = new System.Drawing.Point(101, 141);
			this.dtpDueTo.Name = "dtpDueTo";
			this.dtpDueTo.Size = new System.Drawing.Size(150, 20);
			this.dtpDueTo.TabIndex = 6;
			// 
			// lblDueTo
			// 
			this.lblDueTo.AutoSize = true;
			this.lblDueTo.Location = new System.Drawing.Point(6, 147);
			this.lblDueTo.Name = "lblDueTo";
			this.lblDueTo.Size = new System.Drawing.Size(39, 13);
			this.lblDueTo.TabIndex = 5;
			this.lblDueTo.Text = "Due to";
			// 
			// rtbDescription
			// 
			this.rtbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbDescription.Location = new System.Drawing.Point(6, 48);
			this.rtbDescription.Name = "rtbDescription";
			this.rtbDescription.Size = new System.Drawing.Size(802, 85);
			this.rtbDescription.TabIndex = 4;
			this.rtbDescription.Text = "";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(6, 32);
			this.lblDescription.MaximumSize = new System.Drawing.Size(117, 13);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.TabIndex = 3;
			this.lblDescription.Text = "Description";
			// 
			// tbTitle
			// 
			this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTitle.Location = new System.Drawing.Point(101, 7);
			this.tbTitle.MaxLength = 100;
			this.tbTitle.Name = "tbTitle";
			this.tbTitle.Size = new System.Drawing.Size(707, 20);
			this.tbTitle.TabIndex = 2;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(6, 10);
			this.lblTitle.MaximumSize = new System.Drawing.Size(117, 13);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(27, 13);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Title";
			// 
			// tpHistory
			// 
			this.tpHistory.Controls.Add(this.lvHistory);
			this.tpHistory.Location = new System.Drawing.Point(4, 22);
			this.tpHistory.Name = "tpHistory";
			this.tpHistory.Padding = new System.Windows.Forms.Padding(3);
			this.tpHistory.Size = new System.Drawing.Size(820, 426);
			this.tpHistory.TabIndex = 1;
			this.tpHistory.Text = "History";
			this.tpHistory.UseVisualStyleBackColor = true;
			// 
			// lvHistory
			// 
			this.lvHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chOperation,
            this.chOriginator,
            this.chOperationTime});
			this.lvHistory.HideSelection = false;
			this.lvHistory.Location = new System.Drawing.Point(8, 6);
			this.lvHistory.Name = "lvHistory";
			this.lvHistory.Size = new System.Drawing.Size(776, 276);
			this.lvHistory.TabIndex = 27;
			this.lvHistory.UseCompatibleStateImageBehavior = false;
			this.lvHistory.View = System.Windows.Forms.View.Details;
			// 
			// chOperation
			// 
			this.chOperation.Text = "Operation";
			this.chOperation.Width = 489;
			// 
			// chOriginator
			// 
			this.chOriginator.Text = "Originator";
			this.chOriginator.Width = 177;
			// 
			// chOperationTime
			// 
			this.chOperationTime.Text = "Operation time";
			this.chOperationTime.Width = 101;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(749, 458);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 26;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnCreate
			// 
			this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnCreate.Location = new System.Drawing.Point(668, 458);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 25;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
			// 
			// CreateIssueForm
			// 
			this.AcceptButton = this.btnCreate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(828, 488);
			this.Controls.Add(this.pMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(844, 527);
			this.Name = "CreateIssueForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create issue";
			this.Shown += new System.EventHandler(this.CreateIssueForm_Shown);
			this.pMain.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.tpGeneral.ResumeLayout(false);
			this.gbMain.ResumeLayout(false);
			this.gbMain.PerformLayout();
			this.gbRecurring.ResumeLayout(false);
			this.gbRecurring.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRepetitionValue)).EndInit();
			this.tpHistory.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tpGeneral;
		private System.Windows.Forms.GroupBox gbMain;
		private System.Windows.Forms.TextBox tbBlockedBy;
		private System.Windows.Forms.Label lblBlockedBy;
		private System.Windows.Forms.DateTimePicker dtpDueTo;
		private System.Windows.Forms.Label lblDueTo;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.RichTextBox rtbDescription;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox tbTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TabPage tpHistory;
		private System.Windows.Forms.TextBox tbBlocking;
		private System.Windows.Forms.Label lblBlocking;
		private System.Windows.Forms.ListView lvHistory;
		private System.Windows.Forms.ComboBox cbOwnedBy;
		private System.Windows.Forms.Label lblOwnedBy;
		private System.Windows.Forms.ColumnHeader chOperation;
		private System.Windows.Forms.ColumnHeader chOriginator;
		private System.Windows.Forms.ColumnHeader chOperationTime;
		private System.Windows.Forms.ComboBox cbIssueType;
		private System.Windows.Forms.Label lblIssueType;
		private System.Windows.Forms.ComboBox cbIssuePriority;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbParent;
		private System.Windows.Forms.Label lblParent;
		private System.Windows.Forms.GroupBox gbRecurring;
		private System.Windows.Forms.CheckBox chkExpire;
		private System.Windows.Forms.ComboBox cbRepetitionType;
		private System.Windows.Forms.DateTimePicker dtpExpirationDate;
		private System.Windows.Forms.Label lblExpirationDate;
		private System.Windows.Forms.NumericUpDown nudRepetitionValue;
		private System.Windows.Forms.Label lblRepetition;
	}
}