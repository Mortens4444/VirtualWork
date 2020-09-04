using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Security;
using VirtualWork.Persistence.Repositories;
using VirtualWork.Service.Process;
using VirtualWork.Service.Utils;
using VirtualWork.WinForms.Providers;

namespace VirtualWork.WinForms
{
	public partial class PasswordManager : Form
	{
		private readonly AddCredentialsForm addCredentialsForm;
		private readonly CredentialsProvider credentialsProvider;
		private readonly CredentialsRepository credentialsRepository;
		private readonly ClipboardHelper clipboardHelper;
		private readonly ProcessUtils processUtils;
		private readonly PasswordManagerGroupsProvider passwordManagerGroupsProvider;

		public PasswordManager(AddCredentialsForm addCredentialsForm,
			CredentialsProvider credentialsProvider,
			CredentialsRepository credentialsRepository,
			ClipboardHelper clipboardHelper,
			ProcessUtils processUtils,
			PasswordManagerGroupsProvider passwordManagerGroupsProvider)
		{
			this.addCredentialsForm = addCredentialsForm;
			this.credentialsProvider = credentialsProvider;
			this.clipboardHelper = clipboardHelper;
			this.processUtils = processUtils;
			this.credentialsRepository = credentialsRepository;
			this.passwordManagerGroupsProvider = passwordManagerGroupsProvider;

			InitializeComponent();
			Translator.Translate(this);
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			if (addCredentialsForm.ShowDialog() == DialogResult.OK)
			{
				GetPasswords(true);
			}
		}

		private void GetPasswords(object sender, EventArgs e)
		{
			GetPasswords(false);
		}

		private void GetPasswords(bool getGroups)
		{
			if (getGroups)
			{
				passwordManagerGroupsProvider.GetGroups(cbGroup);
			}

			var group = cbGroup.SelectedIndex == 0 ? String.Empty : cbGroup.Text;
			credentialsProvider.GetCredentials(lvCredentials, tb_Search.Text, group);
		}

		private void PasswordManager_Shown(object sender, EventArgs e)
		{
			GetPasswords(true);
		}

		private void Tsmi_CopyUsername_Click(object sender, EventArgs e)
		{
			clipboardHelper.SetText(GetCredentials(lvCredentials.SelectedItems[0]).Username);
		}

		private void Tsmi_CopyPassword_Click(object sender, EventArgs e)
		{
			clipboardHelper.SetText(GetCredentials(lvCredentials.SelectedItems[0]).Password);
		}

		private void Tsmi_CopyExtraInformation_Click(object sender, EventArgs e)
		{
			clipboardHelper.SetText(GetCredentials(lvCredentials.SelectedItems[0]).ExtraInformation);
		}

		private void Tsmi_ShowPassword_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem selectedItem in lvCredentials.SelectedItems)
			{
				selectedItem.SubItems[3].Text = GetCredentials(selectedItem).Password;
			}
		}

		private void Tsmi_Delete_Click(object sender, EventArgs e)
		{
			var ids = new List<int>();
			foreach (ListViewItem selectedItem in lvCredentials.SelectedItems)
			{
				ids.Add(GetCredentials(selectedItem).Id);
			}
			credentialsRepository.Remove(credentials => ids.Contains(credentials.Id));
			GetPasswords(true);
		}

		private Credentials GetCredentials(ListViewItem selectedItem)
		{
			return (Credentials)selectedItem.Tag;
		}

		private void Tsmi_VisitLink_Click(object sender, EventArgs e)
		{
			processUtils.OpenInBrowser(GetCredentials(lvCredentials.SelectedItems[0]).Link);
		}

		private void Tsmi_VisitLoginLink_Click(object sender, EventArgs e)
		{
			processUtils.OpenInBrowser(GetCredentials(lvCredentials.SelectedItems[0]).AlternativeLink);
		}

		private void Tsmi_Edit_Click(object sender, EventArgs e)
		{
			if (addCredentialsForm.ShowDialog(GetCredentials(lvCredentials.SelectedItems[0])) == DialogResult.OK)
			{
				GetPasswords(true);
			}
		}

		private void Cms_Menu_Opening(object sender, CancelEventArgs e)
		{
			var selectedItemsCount = lvCredentials.SelectedItems.Count;
			var oneSelected = selectedItemsCount == 1;

			tsmiCopyExtraInformation.Enabled = oneSelected;
			tsmiCopyPassword.Enabled = oneSelected;
			tsmiCopyUsername.Enabled = oneSelected;
			tsmiDelete.Enabled = oneSelected;
			tsmiEdit.Enabled = oneSelected;
			tsmiShowPassword.Enabled = selectedItemsCount > 0;
			tsmiVisitLink.Enabled = oneSelected;
			tsmiVisitAlternativeLink.Enabled = oneSelected;
		}
	}
}
