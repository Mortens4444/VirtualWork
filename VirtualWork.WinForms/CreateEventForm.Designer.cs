namespace VirtualWork.WinForms
{
	partial class CreateEventForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEventForm));
			this.pMain = new System.Windows.Forms.Panel();
			this.btnTest = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpGeneral = new System.Windows.Forms.TabPage();
			this.gbMain = new System.Windows.Forms.GroupBox();
			this.dtpEventEndDate = new System.Windows.Forms.DateTimePicker();
			this.lblEventEndTime = new System.Windows.Forms.Label();
			this.tbEventLocation = new System.Windows.Forms.TextBox();
			this.lblEventLocation = new System.Windows.Forms.Label();
			this.gbStartInfo = new System.Windows.Forms.GroupBox();
			this.rtbStartApplication = new System.Windows.Forms.RichTextBox();
			this.gbRecurring = new System.Windows.Forms.GroupBox();
			this.lblRepetition = new System.Windows.Forms.Label();
			this.chkExpire = new System.Windows.Forms.CheckBox();
			this.cbRepetitionType = new System.Windows.Forms.ComboBox();
			this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
			this.lblExpirationDate = new System.Windows.Forms.Label();
			this.nudRepetitionValue = new System.Windows.Forms.NumericUpDown();
			this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
			this.lblEventTime = new System.Windows.Forms.Label();
			this.rtbDescription = new System.Windows.Forms.RichTextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.tbTitle = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.tpHistory = new System.Windows.Forms.TabPage();
			this.lvHistory = new System.Windows.Forms.ListView();
			this.chOperation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chOriginator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chOperationTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pMain.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tpGeneral.SuspendLayout();
			this.gbMain.SuspendLayout();
			this.gbStartInfo.SuspendLayout();
			this.gbRecurring.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRepetitionValue)).BeginInit();
			this.tpHistory.SuspendLayout();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.btnTest);
			this.pMain.Controls.Add(this.btnCancel);
			this.pMain.Controls.Add(this.btnCreate);
			this.pMain.Controls.Add(this.tabControl1);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.MinimumSize = new System.Drawing.Size(800, 405);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(800, 431);
			this.pMain.TabIndex = 0;
			// 
			// btnTest
			// 
			this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnTest.Location = new System.Drawing.Point(13, 398);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(75, 23);
			this.btnTest.TabIndex = 18;
			this.btnTest.Text = "Test";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(712, 400);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 20;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnCreate
			// 
			this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnCreate.Location = new System.Drawing.Point(631, 400);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 19;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tpGeneral);
			this.tabControl1.Controls.Add(this.tpHistory);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 396);
			this.tabControl1.TabIndex = 0;
			// 
			// tpGeneral
			// 
			this.tpGeneral.Controls.Add(this.gbMain);
			this.tpGeneral.Location = new System.Drawing.Point(4, 22);
			this.tpGeneral.Name = "tpGeneral";
			this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tpGeneral.Size = new System.Drawing.Size(792, 370);
			this.tpGeneral.TabIndex = 0;
			this.tpGeneral.Text = "General";
			this.tpGeneral.UseVisualStyleBackColor = true;
			// 
			// gbMain
			// 
			this.gbMain.Controls.Add(this.dtpEventEndDate);
			this.gbMain.Controls.Add(this.lblEventEndTime);
			this.gbMain.Controls.Add(this.tbEventLocation);
			this.gbMain.Controls.Add(this.lblEventLocation);
			this.gbMain.Controls.Add(this.gbStartInfo);
			this.gbMain.Controls.Add(this.gbRecurring);
			this.gbMain.Controls.Add(this.dtpEventDate);
			this.gbMain.Controls.Add(this.lblEventTime);
			this.gbMain.Controls.Add(this.rtbDescription);
			this.gbMain.Controls.Add(this.lblDescription);
			this.gbMain.Controls.Add(this.tbTitle);
			this.gbMain.Controls.Add(this.lblTitle);
			this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbMain.Location = new System.Drawing.Point(3, 3);
			this.gbMain.Name = "gbMain";
			this.gbMain.Size = new System.Drawing.Size(786, 364);
			this.gbMain.TabIndex = 3;
			this.gbMain.TabStop = false;
			// 
			// dtpEventEndDate
			// 
			this.dtpEventEndDate.CustomFormat = "yyyy.MM.dd. HH:mm";
			this.dtpEventEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEventEndDate.Location = new System.Drawing.Point(481, 141);
			this.dtpEventEndDate.Name = "dtpEventEndDate";
			this.dtpEventEndDate.Size = new System.Drawing.Size(156, 20);
			this.dtpEventEndDate.TabIndex = 18;
			// 
			// lblEventEndTime
			// 
			this.lblEventEndTime.AutoSize = true;
			this.lblEventEndTime.Location = new System.Drawing.Point(292, 147);
			this.lblEventEndTime.Name = "lblEventEndTime";
			this.lblEventEndTime.Size = new System.Drawing.Size(78, 13);
			this.lblEventEndTime.TabIndex = 17;
			this.lblEventEndTime.Text = "Event end time";
			// 
			// tbEventLocation
			// 
			this.tbEventLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbEventLocation.Location = new System.Drawing.Point(101, 171);
			this.tbEventLocation.Name = "tbEventLocation";
			this.tbEventLocation.Size = new System.Drawing.Size(679, 20);
			this.tbEventLocation.TabIndex = 8;
			// 
			// lblEventLocation
			// 
			this.lblEventLocation.AutoSize = true;
			this.lblEventLocation.Location = new System.Drawing.Point(6, 174);
			this.lblEventLocation.Name = "lblEventLocation";
			this.lblEventLocation.Size = new System.Drawing.Size(75, 13);
			this.lblEventLocation.TabIndex = 7;
			this.lblEventLocation.Text = "Event location";
			// 
			// gbStartInfo
			// 
			this.gbStartInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbStartInfo.Controls.Add(this.rtbStartApplication);
			this.gbStartInfo.Location = new System.Drawing.Point(6, 273);
			this.gbStartInfo.MinimumSize = new System.Drawing.Size(774, 48);
			this.gbStartInfo.Name = "gbStartInfo";
			this.gbStartInfo.Size = new System.Drawing.Size(774, 88);
			this.gbStartInfo.TabIndex = 16;
			this.gbStartInfo.TabStop = false;
			this.gbStartInfo.Text = "Start application";
			// 
			// rtbStartApplication
			// 
			this.rtbStartApplication.AcceptsTab = true;
			this.rtbStartApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbStartApplication.Location = new System.Drawing.Point(3, 19);
			this.rtbStartApplication.Name = "rtbStartApplication";
			this.rtbStartApplication.Size = new System.Drawing.Size(765, 63);
			this.rtbStartApplication.TabIndex = 17;
			this.rtbStartApplication.Text = "";
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
			this.gbRecurring.Location = new System.Drawing.Point(6, 190);
			this.gbRecurring.Name = "gbRecurring";
			this.gbRecurring.Size = new System.Drawing.Size(774, 77);
			this.gbRecurring.TabIndex = 9;
			this.gbRecurring.TabStop = false;
			// 
			// lblRepetition
			// 
			this.lblRepetition.AutoSize = true;
			this.lblRepetition.Location = new System.Drawing.Point(6, 19);
			this.lblRepetition.Name = "lblRepetition";
			this.lblRepetition.Size = new System.Drawing.Size(55, 13);
			this.lblRepetition.TabIndex = 10;
			this.lblRepetition.Text = "Repetition";
			// 
			// chkExpire
			// 
			this.chkExpire.AutoSize = true;
			this.chkExpire.Location = new System.Drawing.Point(289, 19);
			this.chkExpire.Name = "chkExpire";
			this.chkExpire.Size = new System.Drawing.Size(55, 17);
			this.chkExpire.TabIndex = 13;
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
			this.cbRepetitionType.TabIndex = 12;
			this.cbRepetitionType.SelectedIndexChanged += new System.EventHandler(this.CbRepetitionType_SelectedIndexChanged);
			// 
			// dtpExpirationDate
			// 
			this.dtpExpirationDate.CustomFormat = "yyyy.MM.dd. HH:mm";
			this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpExpirationDate.Location = new System.Drawing.Point(475, 40);
			this.dtpExpirationDate.Name = "dtpExpirationDate";
			this.dtpExpirationDate.Size = new System.Drawing.Size(152, 20);
			this.dtpExpirationDate.TabIndex = 15;
			// 
			// lblExpirationDate
			// 
			this.lblExpirationDate.AutoSize = true;
			this.lblExpirationDate.Location = new System.Drawing.Point(286, 46);
			this.lblExpirationDate.Name = "lblExpirationDate";
			this.lblExpirationDate.Size = new System.Drawing.Size(77, 13);
			this.lblExpirationDate.TabIndex = 14;
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
			this.nudRepetitionValue.TabIndex = 11;
			this.nudRepetitionValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// dtpEventDate
			// 
			this.dtpEventDate.CustomFormat = "yyyy.MM.dd. HH:mm";
			this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEventDate.Location = new System.Drawing.Point(101, 141);
			this.dtpEventDate.Name = "dtpEventDate";
			this.dtpEventDate.Size = new System.Drawing.Size(156, 20);
			this.dtpEventDate.TabIndex = 6;
			// 
			// lblEventTime
			// 
			this.lblEventTime.AutoSize = true;
			this.lblEventTime.Location = new System.Drawing.Point(6, 147);
			this.lblEventTime.Name = "lblEventTime";
			this.lblEventTime.Size = new System.Drawing.Size(57, 13);
			this.lblEventTime.TabIndex = 5;
			this.lblEventTime.Text = "Event time";
			// 
			// rtbDescription
			// 
			this.rtbDescription.AcceptsTab = true;
			this.rtbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbDescription.Location = new System.Drawing.Point(6, 48);
			this.rtbDescription.Name = "rtbDescription";
			this.rtbDescription.Size = new System.Drawing.Size(774, 85);
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
			this.tbTitle.Size = new System.Drawing.Size(679, 20);
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
			this.tpHistory.Size = new System.Drawing.Size(792, 370);
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
			this.lvHistory.Location = new System.Drawing.Point(8, 31);
			this.lvHistory.Name = "lvHistory";
			this.lvHistory.Size = new System.Drawing.Size(776, 276);
			this.lvHistory.TabIndex = 21;
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
			// CreateEventForm
			// 
			this.AcceptButton = this.btnCreate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(800, 431);
			this.Controls.Add(this.pMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CreateEventForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create event";
			this.Shown += new System.EventHandler(this.CreateEventForm_Shown);
			this.pMain.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tpGeneral.ResumeLayout(false);
			this.gbMain.ResumeLayout(false);
			this.gbMain.PerformLayout();
			this.gbStartInfo.ResumeLayout(false);
			this.gbRecurring.ResumeLayout(false);
			this.gbRecurring.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRepetitionValue)).EndInit();
			this.tpHistory.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpGeneral;
		private System.Windows.Forms.GroupBox gbMain;
		private System.Windows.Forms.GroupBox gbRecurring;
		private System.Windows.Forms.NumericUpDown nudRepetitionValue;
		private System.Windows.Forms.DateTimePicker dtpEventDate;
		private System.Windows.Forms.Label lblEventTime;
		private System.Windows.Forms.RichTextBox rtbDescription;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox tbTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TabPage tpHistory;
		private System.Windows.Forms.DateTimePicker dtpExpirationDate;
		private System.Windows.Forms.Label lblExpirationDate;
		private System.Windows.Forms.GroupBox gbStartInfo;
		private System.Windows.Forms.RichTextBox rtbStartApplication;
		private System.Windows.Forms.ComboBox cbRepetitionType;
		private System.Windows.Forms.CheckBox chkExpire;
		private System.Windows.Forms.ListView lvHistory;
		private System.Windows.Forms.ColumnHeader chOperation;
		private System.Windows.Forms.ColumnHeader chOriginator;
		private System.Windows.Forms.ColumnHeader chOperationTime;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Label lblRepetition;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.TextBox tbEventLocation;
		private System.Windows.Forms.Label lblEventLocation;
		private System.Windows.Forms.DateTimePicker dtpEventEndDate;
		private System.Windows.Forms.Label lblEventEndTime;
	}
}