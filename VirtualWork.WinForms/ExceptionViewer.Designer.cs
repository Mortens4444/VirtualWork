namespace VirtualWork.WinForms
{
	partial class ExceptionViewer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionViewer));
			this.p_Main = new System.Windows.Forms.Panel();
			this.p_ExceptionText = new System.Windows.Forms.Panel();
			this.rtb_ExceptionText = new System.Windows.Forms.RichTextBox();
			this.p_Details = new System.Windows.Forms.Panel();
			this.tb_FunctionName = new System.Windows.Forms.TextBox();
			this.lbl_FunctionName = new System.Windows.Forms.Label();
			this.tb_Filename = new System.Windows.Forms.TextBox();
			this.lbl_Filename = new System.Windows.Forms.Label();
			this.tb_ExceptionType = new System.Windows.Forms.TextBox();
			this.lbl_ExceptionType = new System.Windows.Forms.Label();
			this.tb_LastStackElement = new System.Windows.Forms.TextBox();
			this.tb_ExceptionMessage = new System.Windows.Forms.TextBox();
			this.lbl_LastStackElement = new System.Windows.Forms.Label();
			this.lbl_ExceptionMessage = new System.Windows.Forms.Label();
			this.p_Main.SuspendLayout();
			this.p_ExceptionText.SuspendLayout();
			this.p_Details.SuspendLayout();
			this.SuspendLayout();
			// 
			// p_Main
			// 
			this.p_Main.Controls.Add(this.p_ExceptionText);
			this.p_Main.Controls.Add(this.p_Details);
			this.p_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Main.Location = new System.Drawing.Point(0, 0);
			this.p_Main.Name = "p_Main";
			this.p_Main.Size = new System.Drawing.Size(800, 450);
			this.p_Main.TabIndex = 1;
			// 
			// p_ExceptionText
			// 
			this.p_ExceptionText.Controls.Add(this.rtb_ExceptionText);
			this.p_ExceptionText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_ExceptionText.Location = new System.Drawing.Point(0, 146);
			this.p_ExceptionText.Name = "p_ExceptionText";
			this.p_ExceptionText.Size = new System.Drawing.Size(800, 304);
			this.p_ExceptionText.TabIndex = 1;
			// 
			// rtb_ExceptionText
			// 
			this.rtb_ExceptionText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtb_ExceptionText.Location = new System.Drawing.Point(0, 0);
			this.rtb_ExceptionText.Name = "rtb_ExceptionText";
			this.rtb_ExceptionText.ReadOnly = true;
			this.rtb_ExceptionText.Size = new System.Drawing.Size(800, 304);
			this.rtb_ExceptionText.TabIndex = 0;
			this.rtb_ExceptionText.Text = "";
			// 
			// p_Details
			// 
			this.p_Details.Controls.Add(this.tb_FunctionName);
			this.p_Details.Controls.Add(this.lbl_FunctionName);
			this.p_Details.Controls.Add(this.tb_Filename);
			this.p_Details.Controls.Add(this.lbl_Filename);
			this.p_Details.Controls.Add(this.tb_ExceptionType);
			this.p_Details.Controls.Add(this.lbl_ExceptionType);
			this.p_Details.Controls.Add(this.tb_LastStackElement);
			this.p_Details.Controls.Add(this.tb_ExceptionMessage);
			this.p_Details.Controls.Add(this.lbl_LastStackElement);
			this.p_Details.Controls.Add(this.lbl_ExceptionMessage);
			this.p_Details.Dock = System.Windows.Forms.DockStyle.Top;
			this.p_Details.Location = new System.Drawing.Point(0, 0);
			this.p_Details.Name = "p_Details";
			this.p_Details.Size = new System.Drawing.Size(800, 146);
			this.p_Details.TabIndex = 0;
			// 
			// tb_FunctionName
			// 
			this.tb_FunctionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_FunctionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_FunctionName.Location = new System.Drawing.Point(133, 113);
			this.tb_FunctionName.Name = "tb_FunctionName";
			this.tb_FunctionName.ReadOnly = true;
			this.tb_FunctionName.Size = new System.Drawing.Size(655, 20);
			this.tb_FunctionName.TabIndex = 5;
			this.tb_FunctionName.TabStop = false;
			// 
			// lbl_FunctionName
			// 
			this.lbl_FunctionName.AutoSize = true;
			this.lbl_FunctionName.Location = new System.Drawing.Point(12, 116);
			this.lbl_FunctionName.Name = "lbl_FunctionName";
			this.lbl_FunctionName.Size = new System.Drawing.Size(77, 13);
			this.lbl_FunctionName.TabIndex = 7;
			this.lbl_FunctionName.Text = "Function name";
			// 
			// tb_Filename
			// 
			this.tb_Filename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_Filename.Location = new System.Drawing.Point(133, 87);
			this.tb_Filename.Name = "tb_Filename";
			this.tb_Filename.ReadOnly = true;
			this.tb_Filename.Size = new System.Drawing.Size(655, 20);
			this.tb_Filename.TabIndex = 4;
			this.tb_Filename.TabStop = false;
			// 
			// lbl_Filename
			// 
			this.lbl_Filename.AutoSize = true;
			this.lbl_Filename.Location = new System.Drawing.Point(12, 90);
			this.lbl_Filename.Name = "lbl_Filename";
			this.lbl_Filename.Size = new System.Drawing.Size(49, 13);
			this.lbl_Filename.TabIndex = 5;
			this.lbl_Filename.Text = "Filename";
			// 
			// tb_ExceptionType
			// 
			this.tb_ExceptionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_ExceptionType.Location = new System.Drawing.Point(133, 9);
			this.tb_ExceptionType.Name = "tb_ExceptionType";
			this.tb_ExceptionType.ReadOnly = true;
			this.tb_ExceptionType.Size = new System.Drawing.Size(655, 20);
			this.tb_ExceptionType.TabIndex = 1;
			this.tb_ExceptionType.TabStop = false;
			// 
			// lbl_ExceptionType
			// 
			this.lbl_ExceptionType.AutoSize = true;
			this.lbl_ExceptionType.Location = new System.Drawing.Point(12, 12);
			this.lbl_ExceptionType.Name = "lbl_ExceptionType";
			this.lbl_ExceptionType.Size = new System.Drawing.Size(77, 13);
			this.lbl_ExceptionType.TabIndex = 4;
			this.lbl_ExceptionType.Text = "Exception type";
			// 
			// tb_LastStackElement
			// 
			this.tb_LastStackElement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_LastStackElement.Location = new System.Drawing.Point(133, 61);
			this.tb_LastStackElement.Name = "tb_LastStackElement";
			this.tb_LastStackElement.ReadOnly = true;
			this.tb_LastStackElement.Size = new System.Drawing.Size(655, 20);
			this.tb_LastStackElement.TabIndex = 3;
			this.tb_LastStackElement.TabStop = false;
			// 
			// tb_ExceptionMessage
			// 
			this.tb_ExceptionMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_ExceptionMessage.Location = new System.Drawing.Point(133, 35);
			this.tb_ExceptionMessage.Name = "tb_ExceptionMessage";
			this.tb_ExceptionMessage.ReadOnly = true;
			this.tb_ExceptionMessage.Size = new System.Drawing.Size(655, 20);
			this.tb_ExceptionMessage.TabIndex = 2;
			this.tb_ExceptionMessage.TabStop = false;
			// 
			// lbl_LastStackElement
			// 
			this.lbl_LastStackElement.AutoSize = true;
			this.lbl_LastStackElement.Location = new System.Drawing.Point(12, 64);
			this.lbl_LastStackElement.Name = "lbl_LastStackElement";
			this.lbl_LastStackElement.Size = new System.Drawing.Size(96, 13);
			this.lbl_LastStackElement.TabIndex = 1;
			this.lbl_LastStackElement.Text = "Last stack element";
			// 
			// lbl_ExceptionMessage
			// 
			this.lbl_ExceptionMessage.AutoSize = true;
			this.lbl_ExceptionMessage.Location = new System.Drawing.Point(12, 38);
			this.lbl_ExceptionMessage.Name = "lbl_ExceptionMessage";
			this.lbl_ExceptionMessage.Size = new System.Drawing.Size(99, 13);
			this.lbl_ExceptionMessage.TabIndex = 0;
			this.lbl_ExceptionMessage.Text = "Exception message";
			// 
			// ExceptionViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.p_Main);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ExceptionViewer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Exception viewer";
			this.Shown += new System.EventHandler(this.ExceptionViewer_Shown);
			this.p_Main.ResumeLayout(false);
			this.p_ExceptionText.ResumeLayout(false);
			this.p_Details.ResumeLayout(false);
			this.p_Details.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel p_Main;
		private System.Windows.Forms.Panel p_ExceptionText;
		private System.Windows.Forms.RichTextBox rtb_ExceptionText;
		private System.Windows.Forms.Panel p_Details;
		private System.Windows.Forms.TextBox tb_FunctionName;
		private System.Windows.Forms.Label lbl_FunctionName;
		private System.Windows.Forms.TextBox tb_Filename;
		private System.Windows.Forms.Label lbl_Filename;
		private System.Windows.Forms.TextBox tb_ExceptionType;
		private System.Windows.Forms.Label lbl_ExceptionType;
		private System.Windows.Forms.TextBox tb_LastStackElement;
		private System.Windows.Forms.TextBox tb_ExceptionMessage;
		private System.Windows.Forms.Label lbl_LastStackElement;
		private System.Windows.Forms.Label lbl_ExceptionMessage;
	}
}