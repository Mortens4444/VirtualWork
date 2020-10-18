using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Windows.Forms;
using LanguageService;
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

		private User user;

		public AddUserForm(ActualUserGroupsProvider actualUserGroupsProvider,
			UserRepository userRepository,
			GroupRepository groupRepository)
		{
			this.userRepository = userRepository;

			InitializeComponent();
			Translator.Translate(this);

			groups = !userRepository.HasAny() ? new[] { groupRepository.GetAdminGroup() } : actualUserGroupsProvider.Get();
		}

		[PrincipalPermission(SecurityAction.Demand, Role = Roles.UserAndGroupManagement)]
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			user = user ?? new User();
			user.Name = tbName.Text;
			user.PasswordHash = Hash.GetSaltedPasswordHash(tbPassword.Text);
			user.IsActive = true;
			user.Groups = groups;
			user = userRepository.AddOrUpdate(user);
		}

		private void CredentialsChanged(object sender, EventArgs e)
		{
			btnAdd.Enabled = Initializer.LoggedInUser.IsInRole(Roles.ResourceCrud)
				&& !String.IsNullOrEmpty(tbName.Text)
				&& !String.IsNullOrEmpty(tbPassword.Text)
				&& tbPassword.Text == tbConfirmPassword.Text;
		}

		public new bool ShowDialog()
		{
			return base.ShowDialog() == DialogResult.OK;
		}

		public bool ShowDialog(object obj)
		{
			btnAdd.Enabled = Initializer.LoggedInUser.IsInRole(Roles.ResourceCrud);
			user = (User)obj;
			return ShowDialog();
		}

		private void AddUserForm_Shown(object sender, EventArgs e)
		{
			tbPassword.Text = String.Empty;
			tbConfirmPassword.Text = String.Empty;
			if (user == null)
			{
				Text = Lng.Elem("Add user");
				btnAdd.Text = Lng.Elem("Add");

				tbName.Text = String.Empty;
			}
			else
			{
				Text = Lng.Elem("Modify user");
				btnAdd.Text = Lng.Elem("Modify");

				tbName.Text = user.Name;
			}
		}
	}
}
