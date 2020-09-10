namespace VirtualWork.WinForms
{
	partial class AddImageForm
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
			this.pMain = new System.Windows.Forms.Panel();
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblDescription = new System.Windows.Forms.Label();
			this.rtbDescription = new System.Windows.Forms.RichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSelectPicture = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.pMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.pbImage);
			this.pMain.Controls.Add(this.panel2);
			this.pMain.Controls.Add(this.panel1);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(800, 578);
			this.pMain.TabIndex = 0;
			// 
			// pbImage
			// 
			this.pbImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbImage.Location = new System.Drawing.Point(0, 113);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size(800, 431);
			this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbImage.TabIndex = 10;
			this.pbImage.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblDescription);
			this.panel2.Controls.Add(this.rtbDescription);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(800, 113);
			this.panel2.TabIndex = 9;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(5, 7);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.TabIndex = 1;
			this.lblDescription.Text = "Description";
			// 
			// rtbDescription
			// 
			this.rtbDescription.AcceptsTab = true;
			this.rtbDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.rtbDescription.Location = new System.Drawing.Point(0, 23);
			this.rtbDescription.Name = "rtbDescription";
			this.rtbDescription.Size = new System.Drawing.Size(800, 90);
			this.rtbDescription.TabIndex = 0;
			this.rtbDescription.Text = "";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnSelectPicture);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 544);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 34);
			this.panel1.TabIndex = 7;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(720, 6);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 29;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// btnSelectPicture
			// 
			this.btnSelectPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSelectPicture.Location = new System.Drawing.Point(3, 6);
			this.btnSelectPicture.Name = "btnSelectPicture";
			this.btnSelectPicture.Size = new System.Drawing.Size(154, 23);
			this.btnSelectPicture.TabIndex = 27;
			this.btnSelectPicture.Text = "Select image";
			this.btnSelectPicture.UseVisualStyleBackColor = true;
			this.btnSelectPicture.Click += new System.EventHandler(this.BtnSelectPicture_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(639, 6);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 28;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// AddImageForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(800, 578);
			this.Controls.Add(this.pMain);
			this.Name = "AddImageForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add image";
			this.pMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSelectPicture;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.RichTextBox rtbDescription;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}