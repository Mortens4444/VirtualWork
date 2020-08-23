using System;
using System.ComponentModel;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.WinForms.Providers;

namespace VirtualWork.WinForms
{
	public partial class UserManagementForm : Form
	{
		private readonly AddGroupForm addGroupForm;
		private readonly AddUserForm addUserForm;
		private readonly UserListProvider userListProvider;

		public UserManagementForm(AddGroupForm addGroupForm,
			AddUserForm addUserForm,
			UserListProvider userListProvider)
		{
			this.addGroupForm = addGroupForm;
			this.addUserForm = addUserForm;
			this.userListProvider = userListProvider;

			InitializeComponent();
			Translator.Translate(this);
		}

		private void UserManagementForm_Shown(object sender, EventArgs e)
		{
			userListProvider.GetUsersAndGroups(tvUsersAndGroups);
		}

		private void BtnCreateNewGroup_Click(object sender, EventArgs e)
		{
			addGroupForm.ShowDialog();
		}

		private void BtnCreateNewUser_Click(object sender, EventArgs e)
		{
			addUserForm.ShowDialog();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}
	}
}
