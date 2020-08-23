namespace VirtualWork.WinForms
{
	partial class CreateMeetingForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateMeetingForm));
			this.pMain = new System.Windows.Forms.Panel();
			this.cbMeetingPoint = new System.Windows.Forms.ComboBox();
			this.lblMeetingPoint = new System.Windows.Forms.Label();
			this.rtbDescription = new System.Windows.Forms.RichTextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.tbTitle = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.dtpMeetingDate = new System.Windows.Forms.DateTimePicker();
			this.gbRecurring = new System.Windows.Forms.GroupBox();
			this.lblRepetition = new System.Windows.Forms.Label();
			this.chkExpire = new System.Windows.Forms.CheckBox();
			this.cbRepetitionType = new System.Windows.Forms.ComboBox();
			this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
			this.lblExpirationDate = new System.Windows.Forms.Label();
			this.nudRepetitionValue = new System.Windows.Forms.NumericUpDown();
			this.lblMeetingDate = new System.Windows.Forms.Label();
			this.lblPartner = new System.Windows.Forms.Label();
			this.cbPartner = new System.Windows.Forms.ComboBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.pMain.SuspendLayout();
			this.gbRecurring.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRepetitionValue)).BeginInit();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.cbMeetingPoint);
			this.pMain.Controls.Add(this.lblMeetingPoint);
			this.pMain.Controls.Add(this.rtbDescription);
			this.pMain.Controls.Add(this.lblDescription);
			this.pMain.Controls.Add(this.tbTitle);
			this.pMain.Controls.Add(this.lblTitle);
			this.pMain.Controls.Add(this.dtpMeetingDate);
			this.pMain.Controls.Add(this.gbRecurring);
			this.pMain.Controls.Add(this.lblMeetingDate);
			this.pMain.Controls.Add(this.lblPartner);
			this.pMain.Controls.Add(this.cbPartner);
			this.pMain.Controls.Add(this.btnCancel);
			this.pMain.Controls.Add(this.btnCreate);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(609, 383);
			this.pMain.TabIndex = 0;
			// 
			// cbMeetingPoint
			// 
			this.cbMeetingPoint.FormattingEnabled = true;
			this.cbMeetingPoint.Location = new System.Drawing.Point(110, 221);
			this.cbMeetingPoint.Name = "cbMeetingPoint";
			this.cbMeetingPoint.Size = new System.Drawing.Size(487, 21);
			this.cbMeetingPoint.TabIndex = 9;
			// 
			// lblMeetingPoint
			// 
			this.lblMeetingPoint.AutoSize = true;
			this.lblMeetingPoint.Location = new System.Drawing.Point(15, 224);
			this.lblMeetingPoint.Name = "lblMeetingPoint";
			this.lblMeetingPoint.Size = new System.Drawing.Size(71, 13);
			this.lblMeetingPoint.TabIndex = 8;
			this.lblMeetingPoint.Text = "Meeting point";
			// 
			// rtbDescription
			// 
			this.rtbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbDescription.Location = new System.Drawing.Point(18, 83);
			this.rtbDescription.Name = "rtbDescription";
			this.rtbDescription.Size = new System.Drawing.Size(579, 50);
			this.rtbDescription.TabIndex = 3;
			this.rtbDescription.Text = "";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(15, 67);
			this.lblDescription.MaximumSize = new System.Drawing.Size(117, 13);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.TabIndex = 2;
			this.lblDescription.Text = "Description";
			// 
			// tbTitle
			// 
			this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTitle.Location = new System.Drawing.Point(18, 35);
			this.tbTitle.MaxLength = 100;
			this.tbTitle.Name = "tbTitle";
			this.tbTitle.Size = new System.Drawing.Size(579, 20);
			this.tbTitle.TabIndex = 1;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(15, 19);
			this.lblTitle.MaximumSize = new System.Drawing.Size(117, 13);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(27, 13);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Title";
			// 
			// dtpMeetingDate
			// 
			this.dtpMeetingDate.CustomFormat = "yyyy.MM.dd. HH:mm";
			this.dtpMeetingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMeetingDate.Location = new System.Drawing.Point(110, 193);
			this.dtpMeetingDate.Name = "dtpMeetingDate";
			this.dtpMeetingDate.Size = new System.Drawing.Size(156, 20);
			this.dtpMeetingDate.TabIndex = 7;
			// 
			// gbRecurring
			// 
			this.gbRecurring.Controls.Add(this.lblRepetition);
			this.gbRecurring.Controls.Add(this.chkExpire);
			this.gbRecurring.Controls.Add(this.cbRepetitionType);
			this.gbRecurring.Controls.Add(this.dtpExpirationDate);
			this.gbRecurring.Controls.Add(this.lblExpirationDate);
			this.gbRecurring.Controls.Add(this.nudRepetitionValue);
			this.gbRecurring.Location = new System.Drawing.Point(12, 264);
			this.gbRecurring.Name = "gbRecurring";
			this.gbRecurring.Size = new System.Drawing.Size(585, 78);
			this.gbRecurring.TabIndex = 30;
			this.gbRecurring.TabStop = false;
			// 
			// lblRepetition
			// 
			this.lblRepetition.AutoSize = true;
			this.lblRepetition.Location = new System.Drawing.Point(3, 20);
			this.lblRepetition.Name = "lblRepetition";
			this.lblRepetition.Size = new System.Drawing.Size(55, 13);
			this.lblRepetition.TabIndex = 10;
			this.lblRepetition.Text = "Repetition";
			// 
			// chkExpire
			// 
			this.chkExpire.AutoSize = true;
			this.chkExpire.Location = new System.Drawing.Point(263, 19);
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
			this.cbRepetitionType.Size = new System.Drawing.Size(201, 21);
			this.cbRepetitionType.TabIndex = 12;
			this.cbRepetitionType.SelectedIndexChanged += new System.EventHandler(this.CbRepetitionType_SelectedIndexChanged);
			// 
			// dtpExpirationDate
			// 
			this.dtpExpirationDate.CustomFormat = "yyyy.MM.dd. HH:mm";
			this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpExpirationDate.Location = new System.Drawing.Point(362, 40);
			this.dtpExpirationDate.Name = "dtpExpirationDate";
			this.dtpExpirationDate.Size = new System.Drawing.Size(156, 20);
			this.dtpExpirationDate.TabIndex = 15;
			// 
			// lblExpirationDate
			// 
			this.lblExpirationDate.AutoSize = true;
			this.lblExpirationDate.Location = new System.Drawing.Point(260, 45);
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
			// lblMeetingDate
			// 
			this.lblMeetingDate.AutoSize = true;
			this.lblMeetingDate.Location = new System.Drawing.Point(15, 195);
			this.lblMeetingDate.Name = "lblMeetingDate";
			this.lblMeetingDate.Size = new System.Drawing.Size(69, 13);
			this.lblMeetingDate.TabIndex = 6;
			this.lblMeetingDate.Text = "Meeting date";
			// 
			// lblPartner
			// 
			this.lblPartner.AutoSize = true;
			this.lblPartner.Location = new System.Drawing.Point(15, 145);
			this.lblPartner.Name = "lblPartner";
			this.lblPartner.Size = new System.Drawing.Size(41, 13);
			this.lblPartner.TabIndex = 4;
			this.lblPartner.Text = "Partner";
			// 
			// cbPartner
			// 
			this.cbPartner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbPartner.FormattingEnabled = true;
			this.cbPartner.Location = new System.Drawing.Point(18, 161);
			this.cbPartner.Name = "cbPartner";
			this.cbPartner.Size = new System.Drawing.Size(579, 21);
			this.cbPartner.TabIndex = 5;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(522, 348);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 17;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnCreate
			// 
			this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnCreate.Location = new System.Drawing.Point(441, 348);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 16;
			this.btnCreate.Text = "OK";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
			// 
			// CreateMeetingForm
			// 
			this.AcceptButton = this.btnCreate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(609, 383);
			this.Controls.Add(this.pMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CreateMeetingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create meeting";
			this.Shown += new System.EventHandler(this.CreateMeetingForm_Shown);
			this.pMain.ResumeLayout(false);
			this.pMain.PerformLayout();
			this.gbRecurring.ResumeLayout(false);
			this.gbRecurring.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRepetitionValue)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Label lblPartner;
		private System.Windows.Forms.ComboBox cbPartner;
		private System.Windows.Forms.DateTimePicker dtpMeetingDate;
		private System.Windows.Forms.Label lblMeetingDate;
		private System.Windows.Forms.GroupBox gbRecurring;
		private System.Windows.Forms.RichTextBox rtbDescription;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox tbTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.CheckBox chkExpire;
		private System.Windows.Forms.ComboBox cbRepetitionType;
		private System.Windows.Forms.DateTimePicker dtpExpirationDate;
		private System.Windows.Forms.Label lblExpirationDate;
		private System.Windows.Forms.NumericUpDown nudRepetitionValue;
		private System.Windows.Forms.ComboBox cbMeetingPoint;
		private System.Windows.Forms.Label lblMeetingPoint;
		private System.Windows.Forms.Label lblRepetition;
	}
}