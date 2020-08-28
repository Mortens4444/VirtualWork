using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VirtualWork.Core.Security;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Providers;

namespace VirtualWork.WinForms
{
	public class AddAdminGroupForm : AddGroupForm
	{
		private readonly ActualUserGroupsProvider actualUserGroupsProvider;

		public AddAdminGroupForm(ActualUserGroupsProvider actualUserGroupsProvider,
			GroupRepository groupRepository, PermissionRepository permissionRepository)
			: base(groupRepository, permissionRepository)
		{
			this.actualUserGroupsProvider = actualUserGroupsProvider;
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			actualUserGroupsProvider.Set(new List<Group> { AddedGroup });
		}
	}
}
