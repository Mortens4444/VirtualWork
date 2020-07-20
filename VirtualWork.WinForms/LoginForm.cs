using System;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Actors;
using VirtualWork.Persistence.Repositories;
using VirtualWork.Service.Cryptography;

namespace VirtualWork.WinForms
{
	public partial class LoginForm : Form
	{
		private readonly UserRepository usersRepository;

		public User LoggedInUser;

		public LoginForm(UserRepository usersRepository)
		{
			InitializeComponent();
			Translator.Translate(this);
			this.usersRepository = usersRepository;
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
					var byteXorCypher = new ByteXorCypher(xorPassword);
					var saltedPasswordHash = Hash.GetSaltedPasswordHash(byteXorCypher, tbPassword.Text);

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
	}
}
