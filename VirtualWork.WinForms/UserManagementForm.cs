using System;
using System.ComponentModel;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Actors;
using VirtualWork.Core.Security;
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

		public new void ShowDialog()
		{
			throw new NotSupportedException("This method is not supported, use 'Show' instead of this function.");
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}

		private void Btn_Close_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void TvUsersAndGroups_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node.Tag is User user)
			{
				rtbDescription.Text = $"{user.FullName}{Environment.NewLine}{user.OtherInformation}";
				chkIsActive.Checked = user.IsActive;
			}
			else if (e.Node.Tag is Group group)
			{
				rtbDescription.Text = $"{group.Description}";
				chkIsActive.Checked = group.IsActive;

			}
		}
	}
}
