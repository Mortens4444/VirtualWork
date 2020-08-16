namespace VirtualWork.WinForms
{
	partial class SendMailForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMailForm));
			this.pMain = new System.Windows.Forms.Panel();
			this.btnSend = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.rtbBody = new System.Windows.Forms.RichTextBox();
			this.tbSubject = new System.Windows.Forms.TextBox();
			this.lblSubject = new System.Windows.Forms.Label();
			this.btnAddBlindCarbonCopy = new System.Windows.Forms.Button();
			this.tbBlindCarbonCopy = new System.Windows.Forms.TextBox();
			this.lblBlindCarbonCopy = new System.Windows.Forms.Label();
			this.btnAddCarbonCopy = new System.Windows.Forms.Button();
			this.tbCarbonCopy = new System.Windows.Forms.TextBox();
			this.lblCarbonCopy = new System.Windows.Forms.Label();
			this.btnAddRecipent = new System.Windows.Forms.Button();
			this.tbTo = new System.Windows.Forms.TextBox();
			this.lblTo = new System.Windows.Forms.Label();
			this.pMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.btnSend);
			this.pMain.Controls.Add(this.btnClose);
			this.pMain.Controls.Add(this.rtbBody);
			this.pMain.Controls.Add(this.tbSubject);
			this.pMain.Controls.Add(this.lblSubject);
			this.pMain.Controls.Add(this.btnAddBlindCarbonCopy);
			this.pMain.Controls.Add(this.tbBlindCarbonCopy);
			this.pMain.Controls.Add(this.lblBlindCarbonCopy);
			this.pMain.Controls.Add(this.btnAddCarbonCopy);
			this.pMain.Controls.Add(this.tbCarbonCopy);
			this.pMain.Controls.Add(this.lblCarbonCopy);
			this.pMain.Controls.Add(this.btnAddRecipent);
			this.pMain.Controls.Add(this.tbTo);
			this.pMain.Controls.Add(this.lblTo);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(800, 450);
			this.pMain.TabIndex = 0;
			// 
			// btnSend
			// 
			this.btnSend.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSend.Location = new System.Drawing.Point(632, 421);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 12;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(713, 421);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 13;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// rtbBody
			// 
			this.rtbBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbBody.Location = new System.Drawing.Point(12, 113);
			this.rtbBody.Name = "rtbBody";
			this.rtbBody.Size = new System.Drawing.Size(776, 302);
			this.rtbBody.TabIndex = 11;
			this.rtbBody.Text = "";
			// 
			// tbSubject
			// 
			this.tbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSubject.Location = new System.Drawing.Point(109, 87);
			this.tbSubject.Name = "tbSubject";
			this.tbSubject.Size = new System.Drawing.Size(679, 20);
			this.tbSubject.TabIndex = 10;
			// 
			// lblSubject
			// 
			this.lblSubject.AutoSize = true;
			this.lblSubject.Location = new System.Drawing.Point(12, 90);
			this.lblSubject.Name = "lblSubject";
			this.lblSubject.Size = new System.Drawing.Size(43, 13);
			this.lblSubject.TabIndex = 9;
			this.lblSubject.Text = "Subject";
			// 
			// btnAddBlindCarbonCopy
			// 
			this.btnAddBlindCarbonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddBlindCarbonCopy.Location = new System.Drawing.Point(713, 59);
			this.btnAddBlindCarbonCopy.Name = "btnAddBlindCarbonCopy";
			this.btnAddBlindCarbonCopy.Size = new System.Drawing.Size(75, 23);
			this.btnAddBlindCarbonCopy.TabIndex = 8;
			this.btnAddBlindCarbonCopy.Text = "Add";
			this.btnAddBlindCarbonCopy.UseVisualStyleBackColor = true;
			// 
			// tbBlindCarbonCopy
			// 
			this.tbBlindCarbonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbBlindCarbonCopy.Location = new System.Drawing.Point(109, 61);
			this.tbBlindCarbonCopy.Name = "tbBlindCarbonCopy";
			this.tbBlindCarbonCopy.Size = new System.Drawing.Size(598, 20);
			this.tbBlindCarbonCopy.TabIndex = 7;
			// 
			// lblBlindCarbonCopy
			// 
			this.lblBlindCarbonCopy.AutoSize = true;
			this.lblBlindCarbonCopy.Location = new System.Drawing.Point(12, 64);
			this.lblBlindCarbonCopy.Name = "lblBlindCarbonCopy";
			this.lblBlindCarbonCopy.Size = new System.Drawing.Size(92, 13);
			this.lblBlindCarbonCopy.TabIndex = 6;
			this.lblBlindCarbonCopy.Text = "Blind carbon copy";
			// 
			// btnAddCarbonCopy
			// 
			this.btnAddCarbonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddCarbonCopy.Location = new System.Drawing.Point(713, 30);
			this.btnAddCarbonCopy.Name = "btnAddCarbonCopy";
			this.btnAddCarbonCopy.Size = new System.Drawing.Size(75, 23);
			this.btnAddCarbonCopy.TabIndex = 5;
			this.btnAddCarbonCopy.Text = "Add";
			this.btnAddCarbonCopy.UseVisualStyleBackColor = true;
			// 
			// tbCarbonCopy
			// 
			this.tbCarbonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCarbonCopy.Location = new System.Drawing.Point(109, 32);
			this.tbCarbonCopy.Name = "tbCarbonCopy";
			this.tbCarbonCopy.Size = new System.Drawing.Size(598, 20);
			this.tbCarbonCopy.TabIndex = 4;
			// 
			// lblCarbonCopy
			// 
			this.lblCarbonCopy.AutoSize = true;
			this.lblCarbonCopy.Location = new System.Drawing.Point(12, 35);
			this.lblCarbonCopy.Name = "lblCarbonCopy";
			this.lblCarbonCopy.Size = new System.Drawing.Size(67, 13);
			this.lblCarbonCopy.TabIndex = 3;
			this.lblCarbonCopy.Text = "Carbon copy";
			// 
			// btnAddRecipent
			// 
			this.btnAddRecipent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddRecipent.Location = new System.Drawing.Point(713, 4);
			this.btnAddRecipent.Name = "btnAddRecipent";
			this.btnAddRecipent.Size = new System.Drawing.Size(75, 23);
			this.btnAddRecipent.TabIndex = 2;
			this.btnAddRecipent.Text = "Add";
			this.btnAddRecipent.UseVisualStyleBackColor = true;
			// 
			// tbTo
			// 
			this.tbTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTo.Location = new System.Drawing.Point(109, 6);
			this.tbTo.Name = "tbTo";
			this.tbTo.Size = new System.Drawing.Size(598, 20);
			this.tbTo.TabIndex = 1;
			// 
			// lblTo
			// 
			this.lblTo.AutoSize = true;
			this.lblTo.Location = new System.Drawing.Point(12, 9);
			this.lblTo.Name = "lblTo";
			this.lblTo.Size = new System.Drawing.Size(20, 13);
			this.lblTo.TabIndex = 0;
			this.lblTo.Text = "To";
			// 
			// SendMailForm
			// 
			this.AcceptButton = this.btnSend;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SendMailForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Send e-mail";
			this.Shown += new System.EventHandler(this.SendMailForm_Shown);
			this.pMain.ResumeLayout(false);
			this.pMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Button btnAddRecipent;
		private System.Windows.Forms.TextBox tbTo;
		private System.Windows.Forms.Label lblTo;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.RichTextBox rtbBody;
		private System.Windows.Forms.TextBox tbSubject;
		private System.Windows.Forms.Label lblSubject;
		private System.Windows.Forms.Button btnAddBlindCarbonCopy;
		private System.Windows.Forms.TextBox tbBlindCarbonCopy;
		private System.Windows.Forms.Label lblBlindCarbonCopy;
		private System.Windows.Forms.Button btnAddCarbonCopy;
		private System.Windows.Forms.TextBox tbCarbonCopy;
		private System.Windows.Forms.Label lblCarbonCopy;
	}
}