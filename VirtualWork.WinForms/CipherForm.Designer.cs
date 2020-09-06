namespace VirtualWork.WinForms
{
	partial class CipherForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CipherForm));
			this.p_Main = new System.Windows.Forms.Panel();
			this.p_Upper = new System.Windows.Forms.Panel();
			this.p_Right = new System.Windows.Forms.Panel();
			this.gb_CipherText = new System.Windows.Forms.GroupBox();
			this.rtb_CipherText = new System.Windows.Forms.RichTextBox();
			this.p_Left = new System.Windows.Forms.Panel();
			this.gb_PlainText = new System.Windows.Forms.GroupBox();
			this.rtb_PlainText = new System.Windows.Forms.RichTextBox();
			this.p_Lower = new System.Windows.Forms.Panel();
			this.p_Hash = new System.Windows.Forms.Panel();
			this.gb_Hashes = new System.Windows.Forms.GroupBox();
			this.tb_SHA2 = new System.Windows.Forms.TextBox();
			this.tb_SHA1 = new System.Windows.Forms.TextBox();
			this.tb_MD5 = new System.Windows.Forms.TextBox();
			this.lbl_SHA2 = new System.Windows.Forms.Label();
			this.lbl_SHA1 = new System.Windows.Forms.Label();
			this.lbl_MD5 = new System.Windows.Forms.Label();
			this.p_CipherMethod = new System.Windows.Forms.Panel();
			this.gbCipherMethod = new System.Windows.Forms.GroupBox();
			this.cbCipherMode = new System.Windows.Forms.ComboBox();
			this.chk_KeyAndIVInByteArrayFormat = new System.Windows.Forms.CheckBox();
			this.chk_ByteArrayValues = new System.Windows.Forms.CheckBox();
			this.lbl_Key = new System.Windows.Forms.Label();
			this.lbl_Error = new System.Windows.Forms.Label();
			this.nud_Key = new System.Windows.Forms.NumericUpDown();
			this.tb_IV = new System.Windows.Forms.TextBox();
			this.lbl_IV = new System.Windows.Forms.Label();
			this.tb_Password = new System.Windows.Forms.TextBox();
			this.lbl_Password = new System.Windows.Forms.Label();
			this.p_Main.SuspendLayout();
			this.p_Upper.SuspendLayout();
			this.p_Right.SuspendLayout();
			this.gb_CipherText.SuspendLayout();
			this.p_Left.SuspendLayout();
			this.gb_PlainText.SuspendLayout();
			this.p_Lower.SuspendLayout();
			this.p_Hash.SuspendLayout();
			this.gb_Hashes.SuspendLayout();
			this.p_CipherMethod.SuspendLayout();
			this.gbCipherMethod.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_Key)).BeginInit();
			this.SuspendLayout();
			// 
			// p_Main
			// 
			this.p_Main.Controls.Add(this.p_Upper);
			this.p_Main.Controls.Add(this.p_Lower);
			this.p_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Main.Location = new System.Drawing.Point(0, 0);
			this.p_Main.Name = "p_Main";
			this.p_Main.Size = new System.Drawing.Size(800, 450);
			this.p_Main.TabIndex = 1;
			// 
			// p_Upper
			// 
			this.p_Upper.Controls.Add(this.p_Right);
			this.p_Upper.Controls.Add(this.p_Left);
			this.p_Upper.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Upper.Location = new System.Drawing.Point(0, 0);
			this.p_Upper.Name = "p_Upper";
			this.p_Upper.Size = new System.Drawing.Size(800, 255);
			this.p_Upper.TabIndex = 1;
			// 
			// p_Right
			// 
			this.p_Right.Controls.Add(this.gb_CipherText);
			this.p_Right.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Right.Location = new System.Drawing.Point(377, 0);
			this.p_Right.Name = "p_Right";
			this.p_Right.Size = new System.Drawing.Size(423, 255);
			this.p_Right.TabIndex = 1;
			// 
			// gb_CipherText
			// 
			this.gb_CipherText.Controls.Add(this.rtb_CipherText);
			this.gb_CipherText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_CipherText.Location = new System.Drawing.Point(0, 0);
			this.gb_CipherText.Name = "gb_CipherText";
			this.gb_CipherText.Size = new System.Drawing.Size(423, 255);
			this.gb_CipherText.TabIndex = 1;
			this.gb_CipherText.TabStop = false;
			this.gb_CipherText.Text = "Cipher text";
			// 
			// rtb_CipherText
			// 
			this.rtb_CipherText.AcceptsTab = true;
			this.rtb_CipherText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtb_CipherText.Location = new System.Drawing.Point(3, 16);
			this.rtb_CipherText.Name = "rtb_CipherText";
			this.rtb_CipherText.Size = new System.Drawing.Size(417, 236);
			this.rtb_CipherText.TabIndex = 1;
			this.rtb_CipherText.Text = "";
			this.rtb_CipherText.TextChanged += new System.EventHandler(this.Rtb_CipherText_TextChanged);
			// 
			// p_Left
			// 
			this.p_Left.BackColor = System.Drawing.SystemColors.Control;
			this.p_Left.Controls.Add(this.gb_PlainText);
			this.p_Left.Dock = System.Windows.Forms.DockStyle.Left;
			this.p_Left.Location = new System.Drawing.Point(0, 0);
			this.p_Left.Name = "p_Left";
			this.p_Left.Size = new System.Drawing.Size(377, 255);
			this.p_Left.TabIndex = 0;
			// 
			// gb_PlainText
			// 
			this.gb_PlainText.Controls.Add(this.rtb_PlainText);
			this.gb_PlainText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_PlainText.Location = new System.Drawing.Point(0, 0);
			this.gb_PlainText.Name = "gb_PlainText";
			this.gb_PlainText.Size = new System.Drawing.Size(377, 255);
			this.gb_PlainText.TabIndex = 0;
			this.gb_PlainText.TabStop = false;
			this.gb_PlainText.Text = "Plain text";
			// 
			// rtb_PlainText
			// 
			this.rtb_PlainText.AcceptsTab = true;
			this.rtb_PlainText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtb_PlainText.Location = new System.Drawing.Point(3, 16);
			this.rtb_PlainText.Name = "rtb_PlainText";
			this.rtb_PlainText.Size = new System.Drawing.Size(371, 236);
			this.rtb_PlainText.TabIndex = 0;
			this.rtb_PlainText.Text = "";
			this.rtb_PlainText.TextChanged += new System.EventHandler(this.Rtb_PlainText_TextChanged);
			// 
			// p_Lower
			// 
			this.p_Lower.Controls.Add(this.p_Hash);
			this.p_Lower.Controls.Add(this.p_CipherMethod);
			this.p_Lower.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.p_Lower.Location = new System.Drawing.Point(0, 255);
			this.p_Lower.Name = "p_Lower";
			this.p_Lower.Size = new System.Drawing.Size(800, 195);
			this.p_Lower.TabIndex = 0;
			// 
			// p_Hash
			// 
			this.p_Hash.Controls.Add(this.gb_Hashes);
			this.p_Hash.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Hash.Location = new System.Drawing.Point(0, 106);
			this.p_Hash.Name = "p_Hash";
			this.p_Hash.Size = new System.Drawing.Size(800, 89);
			this.p_Hash.TabIndex = 1;
			// 
			// gb_Hashes
			// 
			this.gb_Hashes.Controls.Add(this.tb_SHA2);
			this.gb_Hashes.Controls.Add(this.tb_SHA1);
			this.gb_Hashes.Controls.Add(this.tb_MD5);
			this.gb_Hashes.Controls.Add(this.lbl_SHA2);
			this.gb_Hashes.Controls.Add(this.lbl_SHA1);
			this.gb_Hashes.Controls.Add(this.lbl_MD5);
			this.gb_Hashes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_Hashes.Location = new System.Drawing.Point(0, 0);
			this.gb_Hashes.Name = "gb_Hashes";
			this.gb_Hashes.Size = new System.Drawing.Size(800, 89);
			this.gb_Hashes.TabIndex = 0;
			this.gb_Hashes.TabStop = false;
			this.gb_Hashes.Text = "Hashes";
			// 
			// tb_SHA2
			// 
			this.tb_SHA2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_SHA2.Location = new System.Drawing.Point(15, 59);
			this.tb_SHA2.Multiline = true;
			this.tb_SHA2.Name = "tb_SHA2";
			this.tb_SHA2.ReadOnly = true;
			this.tb_SHA2.Size = new System.Drawing.Size(764, 18);
			this.tb_SHA2.TabIndex = 5;
			// 
			// tb_SHA1
			// 
			this.tb_SHA1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_SHA1.Location = new System.Drawing.Point(398, 13);
			this.tb_SHA1.Name = "tb_SHA1";
			this.tb_SHA1.ReadOnly = true;
			this.tb_SHA1.Size = new System.Drawing.Size(381, 20);
			this.tb_SHA1.TabIndex = 4;
			// 
			// tb_MD5
			// 
			this.tb_MD5.Location = new System.Drawing.Point(59, 13);
			this.tb_MD5.Name = "tb_MD5";
			this.tb_MD5.ReadOnly = true;
			this.tb_MD5.Size = new System.Drawing.Size(262, 20);
			this.tb_MD5.TabIndex = 3;
			// 
			// lbl_SHA2
			// 
			this.lbl_SHA2.AutoSize = true;
			this.lbl_SHA2.Location = new System.Drawing.Point(12, 43);
			this.lbl_SHA2.Name = "lbl_SHA2";
			this.lbl_SHA2.Size = new System.Drawing.Size(38, 13);
			this.lbl_SHA2.TabIndex = 2;
			this.lbl_SHA2.Text = "SHA-2";
			// 
			// lbl_SHA1
			// 
			this.lbl_SHA1.AutoSize = true;
			this.lbl_SHA1.Location = new System.Drawing.Point(354, 16);
			this.lbl_SHA1.Name = "lbl_SHA1";
			this.lbl_SHA1.Size = new System.Drawing.Size(38, 13);
			this.lbl_SHA1.TabIndex = 1;
			this.lbl_SHA1.Text = "SHA-1";
			// 
			// lbl_MD5
			// 
			this.lbl_MD5.AutoSize = true;
			this.lbl_MD5.Location = new System.Drawing.Point(12, 16);
			this.lbl_MD5.Name = "lbl_MD5";
			this.lbl_MD5.Size = new System.Drawing.Size(30, 13);
			this.lbl_MD5.TabIndex = 0;
			this.lbl_MD5.Text = "MD5";
			// 
			// p_CipherMethod
			// 
			this.p_CipherMethod.Controls.Add(this.gbCipherMethod);
			this.p_CipherMethod.Dock = System.Windows.Forms.DockStyle.Top;
			this.p_CipherMethod.Location = new System.Drawing.Point(0, 0);
			this.p_CipherMethod.Name = "p_CipherMethod";
			this.p_CipherMethod.Size = new System.Drawing.Size(800, 106);
			this.p_CipherMethod.TabIndex = 0;
			// 
			// gbCipherMethod
			// 
			this.gbCipherMethod.Controls.Add(this.cbCipherMode);
			this.gbCipherMethod.Controls.Add(this.chk_KeyAndIVInByteArrayFormat);
			this.gbCipherMethod.Controls.Add(this.chk_ByteArrayValues);
			this.gbCipherMethod.Controls.Add(this.lbl_Key);
			this.gbCipherMethod.Controls.Add(this.lbl_Error);
			this.gbCipherMethod.Controls.Add(this.nud_Key);
			this.gbCipherMethod.Controls.Add(this.tb_IV);
			this.gbCipherMethod.Controls.Add(this.lbl_IV);
			this.gbCipherMethod.Controls.Add(this.tb_Password);
			this.gbCipherMethod.Controls.Add(this.lbl_Password);
			this.gbCipherMethod.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbCipherMethod.Location = new System.Drawing.Point(0, 0);
			this.gbCipherMethod.Name = "gbCipherMethod";
			this.gbCipherMethod.Size = new System.Drawing.Size(800, 106);
			this.gbCipherMethod.TabIndex = 1;
			this.gbCipherMethod.TabStop = false;
			this.gbCipherMethod.Text = "Chiper method";
			// 
			// cbCipherMode
			// 
			this.cbCipherMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCipherMode.FormattingEnabled = true;
			this.cbCipherMode.Location = new System.Drawing.Point(6, 30);
			this.cbCipherMode.Name = "cbCipherMode";
			this.cbCipherMode.Size = new System.Drawing.Size(158, 21);
			this.cbCipherMode.TabIndex = 16;
			this.cbCipherMode.SelectedIndexChanged += new System.EventHandler(this.CbCipherMode_SelectedIndexChanged);
			// 
			// chk_KeyAndIVInByteArrayFormat
			// 
			this.chk_KeyAndIVInByteArrayFormat.AutoSize = true;
			this.chk_KeyAndIVInByteArrayFormat.Location = new System.Drawing.Point(6, 78);
			this.chk_KeyAndIVInByteArrayFormat.Name = "chk_KeyAndIVInByteArrayFormat";
			this.chk_KeyAndIVInByteArrayFormat.Size = new System.Drawing.Size(216, 17);
			this.chk_KeyAndIVInByteArrayFormat.TabIndex = 15;
			this.chk_KeyAndIVInByteArrayFormat.Text = "Password and IV are in byte array format";
			this.chk_KeyAndIVInByteArrayFormat.UseVisualStyleBackColor = true;
			this.chk_KeyAndIVInByteArrayFormat.TextChanged += new System.EventHandler(this.EncryptEnvironmentChanged);
			// 
			// chk_ByteArrayValues
			// 
			this.chk_ByteArrayValues.AutoSize = true;
			this.chk_ByteArrayValues.Location = new System.Drawing.Point(6, 57);
			this.chk_ByteArrayValues.Name = "chk_ByteArrayValues";
			this.chk_ByteArrayValues.Size = new System.Drawing.Size(107, 17);
			this.chk_ByteArrayValues.TabIndex = 12;
			this.chk_ByteArrayValues.Text = "Byte array values";
			this.chk_ByteArrayValues.UseVisualStyleBackColor = true;
			this.chk_ByteArrayValues.CheckedChanged += new System.EventHandler(this.EncryptEnvironmentChanged);
			// 
			// lbl_Key
			// 
			this.lbl_Key.AutoSize = true;
			this.lbl_Key.Location = new System.Drawing.Point(236, 16);
			this.lbl_Key.Name = "lbl_Key";
			this.lbl_Key.Size = new System.Drawing.Size(25, 13);
			this.lbl_Key.TabIndex = 5;
			this.lbl_Key.Text = "Key";
			// 
			// lbl_Error
			// 
			this.lbl_Error.AutoSize = true;
			this.lbl_Error.ForeColor = System.Drawing.Color.IndianRed;
			this.lbl_Error.Location = new System.Drawing.Point(12, 104);
			this.lbl_Error.Name = "lbl_Error";
			this.lbl_Error.Size = new System.Drawing.Size(0, 13);
			this.lbl_Error.TabIndex = 5;
			// 
			// nud_Key
			// 
			this.nud_Key.Location = new System.Drawing.Point(239, 32);
			this.nud_Key.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.nud_Key.Name = "nud_Key";
			this.nud_Key.Size = new System.Drawing.Size(82, 20);
			this.nud_Key.TabIndex = 4;
			this.nud_Key.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_Key.ValueChanged += new System.EventHandler(this.EncryptEnvironmentChanged);
			// 
			// tb_IV
			// 
			this.tb_IV.Location = new System.Drawing.Point(342, 78);
			this.tb_IV.MaxLength = 16;
			this.tb_IV.Name = "tb_IV";
			this.tb_IV.Size = new System.Drawing.Size(270, 20);
			this.tb_IV.TabIndex = 3;
			this.tb_IV.TextChanged += new System.EventHandler(this.EncryptEnvironmentChanged);
			// 
			// lbl_IV
			// 
			this.lbl_IV.AutoSize = true;
			this.lbl_IV.Location = new System.Drawing.Point(339, 59);
			this.lbl_IV.Name = "lbl_IV";
			this.lbl_IV.Size = new System.Drawing.Size(113, 13);
			this.lbl_IV.TabIndex = 2;
			this.lbl_IV.Text = "Initialization vector (IV)";
			// 
			// tb_Password
			// 
			this.tb_Password.Location = new System.Drawing.Point(342, 32);
			this.tb_Password.Name = "tb_Password";
			this.tb_Password.Size = new System.Drawing.Size(270, 20);
			this.tb_Password.TabIndex = 1;
			this.tb_Password.TextChanged += new System.EventHandler(this.EncryptEnvironmentChanged);
			// 
			// lbl_Password
			// 
			this.lbl_Password.AutoSize = true;
			this.lbl_Password.Location = new System.Drawing.Point(339, 16);
			this.lbl_Password.Name = "lbl_Password";
			this.lbl_Password.Size = new System.Drawing.Size(53, 13);
			this.lbl_Password.TabIndex = 0;
			this.lbl_Password.Text = "Password";
			// 
			// CipherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.p_Main);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CipherForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Encryption / encoding / hashing";
			this.p_Main.ResumeLayout(false);
			this.p_Upper.ResumeLayout(false);
			this.p_Right.ResumeLayout(false);
			this.gb_CipherText.ResumeLayout(false);
			this.p_Left.ResumeLayout(false);
			this.gb_PlainText.ResumeLayout(false);
			this.p_Lower.ResumeLayout(false);
			this.p_Hash.ResumeLayout(false);
			this.gb_Hashes.ResumeLayout(false);
			this.gb_Hashes.PerformLayout();
			this.p_CipherMethod.ResumeLayout(false);
			this.gbCipherMethod.ResumeLayout(false);
			this.gbCipherMethod.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_Key)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel p_Main;
		private System.Windows.Forms.Panel p_Upper;
		private System.Windows.Forms.Panel p_Right;
		private System.Windows.Forms.GroupBox gb_CipherText;
		private System.Windows.Forms.RichTextBox rtb_CipherText;
		private System.Windows.Forms.Panel p_Left;
		private System.Windows.Forms.GroupBox gb_PlainText;
		private System.Windows.Forms.RichTextBox rtb_PlainText;
		private System.Windows.Forms.Panel p_Lower;
		private System.Windows.Forms.Panel p_Hash;
		private System.Windows.Forms.GroupBox gb_Hashes;
		private System.Windows.Forms.TextBox tb_SHA2;
		private System.Windows.Forms.TextBox tb_SHA1;
		private System.Windows.Forms.TextBox tb_MD5;
		private System.Windows.Forms.Label lbl_SHA2;
		private System.Windows.Forms.Label lbl_SHA1;
		private System.Windows.Forms.Label lbl_MD5;
		private System.Windows.Forms.Panel p_CipherMethod;
		private System.Windows.Forms.GroupBox gbCipherMethod;
		private System.Windows.Forms.CheckBox chk_KeyAndIVInByteArrayFormat;
		private System.Windows.Forms.CheckBox chk_ByteArrayValues;
		private System.Windows.Forms.Label lbl_Key;
		private System.Windows.Forms.Label lbl_Error;
		private System.Windows.Forms.NumericUpDown nud_Key;
		private System.Windows.Forms.TextBox tb_IV;
		private System.Windows.Forms.Label lbl_IV;
		private System.Windows.Forms.TextBox tb_Password;
		private System.Windows.Forms.Label lbl_Password;
		private System.Windows.Forms.ComboBox cbCipherMode;
	}
}