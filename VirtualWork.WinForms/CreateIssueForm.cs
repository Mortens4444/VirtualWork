using System;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Actors;
using VirtualWork.Core.Job;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Extensions;
using VirtualWork.WinForms.Utils;

namespace VirtualWork.WinForms
{
	public partial class CreateIssueForm : Form
	{
		private readonly IssueRepository issueRepository;
		private readonly UserRepository userRepository;
		private bool selectingOwner;

		public CreateIssueForm(IssueRepository issueRepository,
			UserRepository userRepository)
		{
			InitializeComponent();
			Translator.Translate(this);

			this.issueRepository = issueRepository;
			this.userRepository = userRepository;

			cbIssueType.FillWithEnum<IssueType>();
			cbIssuePriority.FillWithEnum<Priority>(2);
			cbRepeationType.FillWithEnum<RepeationType>();

			GetUsers();
			GetEpics();
		}

		private void CbRepeationType_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetControlsEnable(cbRepeationType.SelectedIndex != 0);
		}

		private void SetControlsEnable(bool isEnabled)
		{
			nudRepeationValue.Enabled = isEnabled;
			chkExpire.Enabled = isEnabled;
			dtpExpirationDate.Enabled = isEnabled;
		}

		private void CbOwnedBy_TextChanged(object sender, EventArgs e)
		{
			if (!selectingOwner)
			{
				GetUsers();
			}
		}

		private void CbEpic_TextChanged(object sender, EventArgs e)
		{
			GetEpics();
		}

		private void GetUsers()
		{
			var users = userRepository.GetMatchings(cbOwnedBy.Text, user => user.IsMatchingPattern(cbOwnedBy.Text));
			cbOwnedBy.AddMatchingItems(users);
		}

		private void GetEpics()
		{
			var epics = issueRepository.GetMatchings(cbEpic.Text, issue => issue.IssueType == (int)IssueType.Epic && issue.IsMatchingPattern(cbIssueType.Text));
			cbEpic.AddMatchingItems(epics);
		}

		private void BtnCreate_Click(object sender, EventArgs e)
		{
			var issue = new Issue
			{
				IssueState = IssueState.ToDo,
				Creator = Initializer.LoggedInUser,
				Description = rtbDescription.Text,
				Title = tbTitle.Text,
				IssueType = EnumUtils.GetByDescription<IssueType>((string)cbIssueType.SelectedItem),
				Epic = (Issue)cbEpic.SelectedItem,
				DueDate = dtpDueTo.Value.ToUniversalTime(),
				Owner = (User)cbOwnedBy.SelectedItem,
				Priority = EnumUtils.GetByDescription<Priority>((string)cbIssuePriority.SelectedItem),
				RepeationType = EnumUtils.GetByDescription<RepeationType>((string)cbRepeationType.SelectedItem),
				RepeationValue = (int)nudRepeationValue.Value,
				ExpirationDate = dtpExpirationDate.Value.ToUniversalTime(),
				CreationDate = DateTime.UtcNow
			};
			issueRepository.Add(issue);
		}

		private void CbOwnedBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectingOwner = false;
		}

		private void CbOwnedBy_SelectionChangeCommitted(object sender, EventArgs e)
		{
			selectingOwner = true;
		}
	}
}
