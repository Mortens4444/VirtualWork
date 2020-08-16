using System;
using System.Windows.Forms;
using LanguageService;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Security;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Providers;

namespace VirtualWork.WinForms
{
	public partial class AddCredentialsForm : Form
	{
		private readonly CredentialsRepository credentialsRepository;
		private readonly PasswordManagerGroupsProvider passwordManagerGroupsProvider;
		private Credentials credentials;

		public AddCredentialsForm(CredentialsRepository credentialsRepository,
			PasswordManagerGroupsProvider passwordManagerGroupsProvider)
		{
			this.credentialsRepository = credentialsRepository;
			this.passwordManagerGroupsProvider = passwordManagerGroupsProvider;

			InitializeComponent();
			Translator.Translate(this);
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			bool add = credentials == null;
			if (add)
			{
				credentials = new Credentials();
			}
			credentials.Name = tbName.Text;
			credentials.Group = cbGroup.SelectedIndex == 0 ? String.Empty : cbGroup.Text;
			credentials.AlternativeLink = tbAlternativeLink.Text;
			credentials.Link = tbLink.Text;
			credentials.Username = tbUsername.Text;
			credentials.Password = tbPassword.Text;
			credentials.ExtraInformation = rtbExtraInformation.Text;
			credentials.ActorType = ActorType.User;
			credentials.ActorId = Initializer.LoggedInUser.Id;

			credentialsRepository.AddOrUpdate(credentials);
			credentials = null;
		}

		private void AddCredentialsForm_Shown(object sender, EventArgs e)
		{
			cbGroup.SelectedIndex = -1;

			if (credentials == null)
			{
				tbName.Text = String.Empty;
				tbAlternativeLink.Text = String.Empty;
				tbLink.Text = String.Empty;
				tbUsername.Text = String.Empty;
				tbPassword.Text = String.Empty;
				rtbExtraInformation.Text = String.Empty;
			}
			else
			{
				Text = Lng.Elem("Modify credentials");
				btnAdd.Text = Lng.Elem("Modify");

				tbName.Text = credentials.Name;
				cbGroup.Text = credentials.Group;
				tbAlternativeLink.Text = credentials.AlternativeLink;
				tbLink.Text = credentials.Link;
				tbUsername.Text = credentials.Username;
				tbPassword.Text = credentials.Password;
				rtbExtraInformation.Text = credentials.ExtraInformation;
			}
			passwordManagerGroupsProvider.GetGroups(cbGroup);
		}

		public DialogResult ShowDialog(Credentials credentials = null)
		{
			this.credentials = credentials;
			return base.ShowDialog();
		}
	}
}
