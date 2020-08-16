using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Actors;
using VirtualWork.Core.Cryptography.Hashing;
using VirtualWork.Core.Security;
using VirtualWork.Interfaces.Windows;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Providers;

namespace VirtualWork.WinForms
{
	public partial class AddUserForm : Form, IWindow
	{
		private readonly IList<Group> groups;
		private readonly UserRepository userRepository;

		public AddUserForm(ActualUserGroupsProvider actualUserGroupsProvider,
			UserRepository userRepository,
			GroupRepository groupRepository)
		{
			this.userRepository = userRepository;

			InitializeComponent();
			Translator.Translate(this);

			groups = !userRepository.HasAny() ? new[] { groupRepository.GetAdminGroup() } : actualUserGroupsProvider.Get();
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			var user = new User
			{
				Name = tbName.Text,
				PasswordHash = Hash.GetSaltedPasswordHash(tbPassword.Text),
				IsActive = true,
				Groups = groups
			};
			user = userRepository.Add(user);
		}

		private void CredentialsChanged(object sender, EventArgs e)
		{
			btnAdd.Enabled = !String.IsNullOrEmpty(tbName.Text) && !String.IsNullOrEmpty(tbPassword.Text) && tbPassword.Text == tbConfirmPassword.Text;
		}

		bool IWindow.ShowDialog()
		{
			return ShowDialog() == DialogResult.OK;
		}
	}
}
