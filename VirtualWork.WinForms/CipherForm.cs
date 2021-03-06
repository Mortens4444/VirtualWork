﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Cryptography;
using VirtualWork.Core.Cryptography.Ciphers;
using VirtualWork.Core.Extensions;
using VirtualWork.Service.Utils;
using VirtualWork.WinForms.Extensions;

namespace VirtualWork.WinForms
{
	public partial class CipherForm : Form
	{
		private CipherMode cipherMode;
		private bool encrypt = true;
		private ErrorBoxHelper errorBoxHelper;

		public CipherForm(ErrorBoxHelper errorBoxHelper)
		{
			this.errorBoxHelper = errorBoxHelper;

			InitializeComponent();
			Translator.Translate(this);

			cbCipherMode.FillWithEnum<CipherMode>();
		}

		private void CipherForm_Resize(object sender, EventArgs e)
		{
			p_Left.Size = new Size(p_Upper.Size.Width / 2, p_Left.Size.Height);
		}

		private void Rtb_PlainText_TextChanged(object sender, EventArgs e)
		{
			encrypt = true;
			Encrypt();
			tb_MD5.Text = rtb_PlainText.Text.Md5();
			tb_SHA1.Text = rtb_PlainText.Text.Sha1();
			tb_SHA2.Text = rtb_PlainText.Text.Sha2();
		}

		private void Rtb_CipherText_TextChanged(object sender, EventArgs e)
		{
			encrypt = false;
			Decrypt();
			tb_MD5.Text = rtb_CipherText.Text.Md5();
			tb_SHA1.Text = rtb_CipherText.Text.Sha1();
			tb_SHA2.Text = rtb_CipherText.Text.Sha2();
		}

		private void CbCipherMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbCipherMode.SelectedIndex != -1)
			{
				cipherMode = (CipherMode)cbCipherMode.SelectedIndex;
				chk_KeyAndIVInByteArrayFormat.Enabled = cipherMode == CipherMode.TripleDes;
				var des = cipherMode == CipherMode.TripleDes || cipherMode == CipherMode.Des;
				tb_IV.Enabled = des;
				tb_Password.Enabled = des || cipherMode == CipherMode.Xor;
				nud_Key.Enabled = cipherMode == CipherMode.Caesar || cipherMode == CipherMode.Rotate;
				chk_ByteArrayValues.Enabled = des;
				Changed();
			}
		}

		private void Encrypt()
		{
			rtb_CipherText.TextChanged -= Rtb_CipherText_TextChanged;
			rtb_CipherText.Text = String.Empty;
			try
			{
				switch (cipherMode)
				{
					case CipherMode.Base64:
						rtb_CipherText.Text = rtb_PlainText.Text.Base64Encode();
						break;
					case CipherMode.Caesar:
						rtb_CipherText.Text = rtb_PlainText.Text.CaesarEncrypt((int)nud_Key.Value);
						break;
					case CipherMode.Des:
						if (chk_ByteArrayValues.Checked)
						{
							var encryptedText = new StringBuilder();
							var encryptedBytes = DesCipher.DesEncrypt(Encoding.UTF8.GetChars(Encoding.UTF8.GetBytes(rtb_PlainText.Text)), Encoding.ASCII.GetBytes(tb_Password.Text), Encoding.ASCII.GetBytes(tb_IV.Text));
							foreach (var encryptedByte in encryptedBytes)
							{
								encryptedText.AppendFormat("[{0}]", encryptedByte);
							}
							rtb_CipherText.Text = encryptedText.ToString();
						}
						else
						{
							rtb_CipherText.Text = rtb_PlainText.Text.DesEncrypt(tb_Password.Text, tb_IV.Text);
						}
						break;
					case CipherMode.Rotate:
						rtb_CipherText.Text = rtb_PlainText.Text.RotateEncrypt((int)nud_Key.Value);
						break;
					case CipherMode.TripleDes:
						if (chk_ByteArrayValues.Checked)
						{
							if (chk_KeyAndIVInByteArrayFormat.Checked)
							{
							}
							else
							{
								var encryptedText = new StringBuilder();
								var encryptedBytes = TripleDesCipher.TripleDesEncrypt(Encoding.UTF8.GetChars(Encoding.UTF8.GetBytes(rtb_PlainText.Text)), Encoding.ASCII.GetBytes(tb_Password.Text), Encoding.ASCII.GetBytes(tb_IV.Text));
								foreach (var encryptedByte in encryptedBytes)
								{
									encryptedText.AppendFormat("[{0}]", encryptedByte);
								}
								rtb_CipherText.Text = encryptedText.ToString();
							}
						}
						else
						{
							if (chk_KeyAndIVInByteArrayFormat.Checked)
							{
							}
							else
							{
								rtb_CipherText.Text = rtb_PlainText.Text.TripleDesEncrypt(tb_Password.Text, tb_IV.Text);
							}
						}
						break;
					case CipherMode.Xor:
						rtb_CipherText.Text = rtb_PlainText.Text.XorCrypt(tb_Password.Text);
						break;
				}
			}
			catch (Exception ex)
			{
				lbl_Error.Text = ex.Message;
			}
			finally
			{
				rtb_CipherText.TextChanged += Rtb_CipherText_TextChanged;
			}
		}

		private void Decrypt()
		{
			rtb_PlainText.TextChanged -= Rtb_PlainText_TextChanged;
			rtb_PlainText.Text = String.Empty;
			try
			{
				switch (cipherMode)
				{
					case CipherMode.Base64:
						rtb_PlainText.Text = rtb_CipherText.Text.Base64Decode();
						break;
					case CipherMode.Caesar:
						rtb_PlainText.Text = rtb_CipherText.Text.CaesarDecrypt((int)nud_Key.Value);
						break;
					case CipherMode.Des:
						if (chk_ByteArrayValues.Checked)
						{
							var byteStrings = rtb_CipherText.Text.Replace("[", "").Split(']');
							var bytes = new byte[byteStrings.Length - 1];
							for (var i = 0; i < bytes.Length; i++)
							{
								bytes[i] = Convert.ToByte(byteStrings[i]);
							}
							rtb_PlainText.Text = Encoding.UTF8.GetString(DesCipher.DesDecrypt(bytes, Encoding.ASCII.GetBytes(tb_Password.Text), Encoding.ASCII.GetBytes(tb_IV.Text)));
						}
						else rtb_PlainText.Text = rtb_CipherText.Text.DesDecrypt(tb_Password.Text, tb_IV.Text);
						break;
					case CipherMode.Rotate:
						rtb_PlainText.Text = rtb_CipherText.Text.RotateDecrypt((int)nud_Key.Value);
						break;
					case CipherMode.TripleDes:
						if (chk_ByteArrayValues.Checked)
						{
							var bytes = rtb_CipherText.Text.StringToByteArray();
							if (chk_KeyAndIVInByteArrayFormat.Checked)
							{
								var keyBytes = tb_Password.Text.StringToByteArray();
								var ivBytes = tb_IV.Text.StringToByteArray();
								rtb_PlainText.Text = Encoding.UTF8.GetString(TripleDesCipher.TripleDesDecrypt(bytes, keyBytes, ivBytes));
							}
							else
							{
								rtb_PlainText.Text = Encoding.UTF8.GetString(TripleDesCipher.TripleDesDecrypt(bytes, Encoding.ASCII.GetBytes(tb_Password.Text), Encoding.ASCII.GetBytes(tb_IV.Text)));
							}
						}
						else
						{
							if (chk_KeyAndIVInByteArrayFormat.Checked)
							{
								var keyBytes = tb_Password.Text.StringToByteArray();
								var ivBytes = tb_IV.Text.StringToByteArray();
								rtb_PlainText.Text = rtb_CipherText.Text.TripleDesDecrypt(keyBytes, ivBytes);
							}
							else
							{
								rtb_PlainText.Text = rtb_CipherText.Text.TripleDesDecrypt(tb_Password.Text, tb_IV.Text);
							}
						}
						break;
					case CipherMode.Xor:
						rtb_PlainText.Text = rtb_CipherText.Text.XorCrypt(tb_Password.Text);
						break;
				}
			}
			catch (Exception ex)
			{
				rtb_PlainText.Text = ex.Message;
			}
			finally
			{
				rtb_PlainText.TextChanged += Rtb_PlainText_TextChanged;
			}
		}

		private void Changed()
		{
			lbl_Error.Text = String.Empty;
			if (encrypt)
			{
				Encrypt();
			}
			else
			{
				Decrypt();
			}
		}

		private void EncryptEnvironmentChanged(object sender, EventArgs e)
		{
			Changed();
		}

		public new void ShowDialog()
		{
			throw new NotSupportedException("This method is not supported, use 'Show' instead of this function.");
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}

		private void TsmiPaste_Click(object sender, EventArgs e)
		{
			SendKeys.Send("^V");
		}

		private void TsmiCopy_Click(object sender, EventArgs e)
		{
			SendKeys.Send("^C");
		}

		private void TsmiSavePlaintTextIntoFile_Click(object sender, EventArgs e)
		{
			try
			{
				var dialogResult = saveFileDialog.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					File.WriteAllText(saveFileDialog.FileName, rtb_PlainText.Text.Base64Encode());
				}
			}
			catch (Exception ex)
			{
				errorBoxHelper.Show(ex);
			}
		}

		private void TsmiSaveCipherTextIntoFile_Click(object sender, EventArgs e)
		{
			try
			{
				var bytes = Convert.FromBase64String(rtb_CipherText.Text);
				var dialogResult = saveFileDialog.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					File.WriteAllBytes(saveFileDialog.FileName, bytes);
				}
			}
			catch (Exception ex)
			{
				errorBoxHelper.Show(ex);
			}
		}
	}
}
