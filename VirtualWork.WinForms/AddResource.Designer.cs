namespace VirtualWork.WinForms
{
	partial class AddResource
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddResource));
			this.pMain = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.rtbOtherInformation = new System.Windows.Forms.RichTextBox();
			this.lblOtherInformation = new System.Windows.Forms.Label();
			this.rtbKey = new System.Windows.Forms.RichTextBox();
			this.lblKey = new System.Windows.Forms.Label();
			this.cbResourceType = new System.Windows.Forms.ComboBox();
			this.lblResourceType = new System.Windows.Forms.Label();
			this.cbOwner = new System.Windows.Forms.ComboBox();
			this.lblOwner = new System.Windows.Forms.Label();
			this.cbOwnerType = new System.Windows.Forms.ComboBox();
			this.lblOwnerType = new System.Windows.Forms.Label();
			this.pMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.btnCancel);
			this.pMain.Controls.Add(this.btnOk);
			this.pMain.Controls.Add(this.rtbOtherInformation);
			this.pMain.Controls.Add(this.lblOtherInformation);
			this.pMain.Controls.Add(this.rtbKey);
			this.pMain.Controls.Add(this.lblKey);
			this.pMain.Controls.Add(this.cbResourceType);
			this.pMain.Controls.Add(this.lblResourceType);
			this.pMain.Controls.Add(this.cbOwner);
			this.pMain.Controls.Add(this.lblOwner);
			this.pMain.Controls.Add(this.cbOwnerType);
			this.pMain.Controls.Add(this.lblOwnerType);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(597, 268);
			this.pMain.TabIndex = 0;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(512, 237);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(431, 237);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 10;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// rtbOtherInformation
			// 
			this.rtbOtherInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbOtherInformation.Location = new System.Drawing.Point(15, 181);
			this.rtbOtherInformation.Name = "rtbOtherInformation";
			this.rtbOtherInformation.Size = new System.Drawing.Size(572, 50);
			this.rtbOtherInformation.TabIndex = 9;
			this.rtbOtherInformation.Text = "";
			// 
			// lblOtherInformation
			// 
			this.lblOtherInformation.AutoSize = true;
			this.lblOtherInformation.Location = new System.Drawing.Point(12, 165);
			this.lblOtherInformation.Name = "lblOtherInformation";
			this.lblOtherInformation.Size = new System.Drawing.Size(87, 13);
			this.lblOtherInformation.TabIndex = 8;
			this.lblOtherInformation.Text = "Other information";
			// 
			// rtbKey
			// 
			this.rtbKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbKey.Location = new System.Drawing.Point(15, 109);
			this.rtbKey.Name = "rtbKey";
			this.rtbKey.Size = new System.Drawing.Size(572, 50);
			this.rtbKey.TabIndex = 7;
			this.rtbKey.Text = "";
			// 
			// lblKey
			// 
			this.lblKey.AutoSize = true;
			this.lblKey.Location = new System.Drawing.Point(12, 93);
			this.lblKey.Name = "lblKey";
			this.lblKey.Size = new System.Drawing.Size(25, 13);
			this.lblKey.TabIndex = 6;
			this.lblKey.Text = "Key";
			// 
			// cbResourceType
			// 
			this.cbResourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbResourceType.FormattingEnabled = true;
			this.cbResourceType.Location = new System.Drawing.Point(304, 25);
			this.cbResourceType.Name = "cbResourceType";
			this.cbResourceType.Size = new System.Drawing.Size(283, 21);
			this.cbResourceType.TabIndex = 5;
			// 
			// lblResourceType
			// 
			this.lblResourceType.AutoSize = true;
			this.lblResourceType.Location = new System.Drawing.Point(301, 9);
			this.lblResourceType.Name = "lblResourceType";
			this.lblResourceType.Size = new System.Drawing.Size(76, 13);
			this.lblResourceType.TabIndex = 4;
			this.lblResourceType.Text = "Resource type";
			// 
			// cbOwner
			// 
			this.cbOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOwner.FormattingEnabled = true;
			this.cbOwner.Location = new System.Drawing.Point(15, 67);
			this.cbOwner.Name = "cbOwner";
			this.cbOwner.Size = new System.Drawing.Size(283, 21);
			this.cbOwner.TabIndex = 3;
			// 
			// lblOwner
			// 
			this.lblOwner.AutoSize = true;
			this.lblOwner.Location = new System.Drawing.Point(12, 51);
			this.lblOwner.Name = "lblOwner";
			this.lblOwner.Size = new System.Drawing.Size(38, 13);
			this.lblOwner.TabIndex = 2;
			this.lblOwner.Text = "Owner";
			// 
			// cbOwnerType
			// 
			this.cbOwnerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOwnerType.FormattingEnabled = true;
			this.cbOwnerType.Location = new System.Drawing.Point(15, 25);
			this.cbOwnerType.Name = "cbOwnerType";
			this.cbOwnerType.Size = new System.Drawing.Size(283, 21);
			this.cbOwnerType.TabIndex = 1;
			this.cbOwnerType.SelectedIndexChanged += new System.EventHandler(this.CbOwnerType_SelectedIndexChanged);
			// 
			// lblOwnerType
			// 
			this.lblOwnerType.AutoSize = true;
			this.lblOwnerType.Location = new System.Drawing.Point(12, 9);
			this.lblOwnerType.Name = "lblOwnerType";
			this.lblOwnerType.Size = new System.Drawing.Size(61, 13);
			this.lblOwnerType.TabIndex = 0;
			this.lblOwnerType.Text = "Owner type";
			// 
			// AddResource
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(597, 268);
			this.Controls.Add(this.pMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AddResource";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create resource";
			this.Shown += new System.EventHandler(this.AddResource_Shown);
			this.pMain.ResumeLayout(false);
			this.pMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Label lblOwnerType;
		private System.Windows.Forms.ComboBox cbOwner;
		private System.Windows.Forms.Label lblOwner;
		private System.Windows.Forms.ComboBox cbOwnerType;
		private System.Windows.Forms.ComboBox cbResourceType;
		private System.Windows.Forms.Label lblResourceType;
		private System.Windows.Forms.RichTextBox rtbKey;
		private System.Windows.Forms.Label lblKey;
		private System.Windows.Forms.RichTextBox rtbOtherInformation;
		private System.Windows.Forms.Label lblOtherInformation;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
	}
}