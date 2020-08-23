using System;
using System.ComponentModel;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Actors;
using VirtualWork.Core.Cryptography.Ciphers;
using VirtualWork.Core.Cryptography.Hashing;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork.WinForms
{
	public partial class LoginForm : Form
	{
		private readonly UserRepository usersRepository;

		public User LoggedInUser;

		public LoginForm(UserRepository usersRepository)
		{
			this.usersRepository = usersRepository;

			InitializeComponent();
			Translator.Translate(this);
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			LoggedInUser = usersRepository.Get(tbUserName.Text);
			if (LoggedInUser == null)
			{
				return;
			}

			ushort xorPwdPart1 = Byte.MinValue;
			while (xorPwdPart1 <= Byte.MaxValue)
			{
				ushort xorPwdPart2 = Byte.MinValue;
				while (xorPwdPart2 <= Byte.MaxValue)
				{
					var xorPassword = new byte[] { (byte)xorPwdPart1, (byte)xorPwdPart2 };
					var byteXorCipher = new ByteXorCipher(xorPassword);
					var saltedPasswordHash = Hash.GetSaltedPasswordHash(byteXorCipher, tbPassword.Text);

					if (LoggedInUser.PasswordHash == saltedPasswordHash)
					{
						DialogResult = DialogResult.OK;
						xorPwdPart1 = Byte.MaxValue;
						break;
					}
					xorPwdPart2++;
				}

				xorPwdPart1++;
			}
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}
	}
}
