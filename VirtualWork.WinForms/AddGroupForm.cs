﻿using System;
using System.Drawing;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Security;
using VirtualWork.Interfaces.Windows;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Extensions;

namespace VirtualWork.WinForms
{
	public partial class AddGroupForm : Form, IWindow
	{
		private readonly GroupRepository groupRepository;
		private readonly PermissionRepository permissionRepository;

		public Group AddedGroup { get; set; }

		public AddGroupForm(GroupRepository groupRepository,
			PermissionRepository permissionRepository)
		{
			InitializeComponent();
			Translator.Translate(this);
			this.groupRepository = groupRepository;
			this.permissionRepository = permissionRepository;

			if (this is AddAdminGroupForm)
			{
				gb_Permissions.Visible = false;
				this.MinimumSize = new Size(816, 221);
				this.Size = new Size(816, 221);
			}
			else
			{
				var permissions = permissionRepository.GetAll();
				foreach (var permission in permissions)
				{
					var item = new ListViewItem(permission.Name)
					{						
						Tag = permission
					};					
					lvAvailablePermissions.Items.Add(item);
				}
			}
		}

		private void NameChanged(object sender, EventArgs e)
		{
			btnAdd.Enabled = !String.IsNullOrEmpty(tbGroupName.Text);
		}

		bool IWindow.ShowDialog()
		{
			return ShowDialog() == DialogResult.OK;
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			var permissions = this is AddAdminGroupForm
				? new Permission[] { }
				: lvGrantedPermissions.Items.ToPermissions();

			AddedGroup = new Group
			{
				Name = tbGroupName.Text,
				Description = rtbDescription.Text,
				Permissions = permissions,
				IsActive = true
			};
			AddedGroup = groupRepository.Add(AddedGroup);
		}
	}
}