using System;
using System.Windows.Forms;
using LanguageService;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Actors;
using VirtualWork.Core.Job;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Repositories;
using VirtualWork.Service.Utils;
using VirtualWork.WinForms.Extensions;
using IssueRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Job.Issue, VirtualWork.Persistence.Entities.Issue>;

namespace VirtualWork.WinForms
{
	public partial class CreateIssueForm : Form
	{
		private readonly IssueRepository issueRepository;
		private readonly UserRepository userRepository;
		private bool selectingOwner, selectingIssue;
		private Issue issue;

		public CreateIssueForm(IssueRepository issueRepository,
			UserRepository userRepository)
		{
			this.issueRepository = issueRepository;
			this.userRepository = userRepository;

			InitializeComponent();
			Translator.Translate(this);

			cbIssueType.FillWithEnum<IssueType>();
			cbIssuePriority.FillWithEnum<Priority>(2);
			cbRepetitionType.FillWithEnum<RepetitionType>();
		}

		private void CbRepetitionType_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetControlsEnable(cbRepetitionType.SelectedIndex != 0);
		}

		private void SetControlsEnable(bool isEnabled)
		{
			nudRepetitionValue.Enabled = isEnabled;
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

		private void CbParent_TextChanged(object sender, EventArgs e)
		{
			if (!selectingIssue)
			{
				GetUnfinishedIssues();
			}
		}

		private void GetUsers()
		{
			var users = userRepository.GetAll(user => user.IsMatchingPattern(cbOwnedBy.Text));
			cbOwnedBy.AddMatchingItems(users);
		}

		private void GetUnfinishedIssues()
		{
			var issueId = issue?.Id ?? 0;
			var parents = issueRepository.GetAll(currentIssue =>
				((currentIssue.IssueState != (int)IssueState.Cancelled) &&
				(currentIssue.IssueState != (int)IssueState.Done)) &&
				currentIssue.IsMatchingPattern(cbParent.Text) &&
				currentIssue.Id != issueId);
			cbParent.AddMatchingItems(parents);
		}

		private void BtnCreate_Click(object sender, EventArgs e)
		{
			issue = issue ?? new Issue();
			issue.Creator = Initializer.LoggedInUser;
			issue.Description = rtbDescription.Text;
			issue.Title = tbTitle.Text;
			issue.IssueType = EnumUtils.GetByDescription<IssueType>((string)cbIssueType.SelectedItem);
			issue.Parent = (Issue)cbParent.SelectedItem;
			issue.DueDate = dtpDueTo.Value;
			issue.Owner = (User)cbOwnedBy.SelectedItem;
			issue.Priority = EnumUtils.GetByDescription<Priority>((string)cbIssuePriority.SelectedItem);
			issue.RepetitionType = EnumUtils.GetByDescription<RepetitionType>((string)cbRepetitionType.SelectedItem);
			issue.RepetitionValue = (int)nudRepetitionValue.Value;
			issue.ExpirationDate = dtpExpirationDate.Value;
			issue.CreationDate = DateTime.UtcNow;
			issueRepository.AddOrUpdate(issue);
			issue = null;
		}

		private void CbOwnedBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectingOwner = false;
		}

		private void CbOwnedBy_SelectionChangeCommitted(object sender, EventArgs e)
		{
			selectingOwner = true;
		}

		private void CreateIssueForm_Shown(object sender, EventArgs e)
		{
			GetUsers();
			GetUnfinishedIssues();

			if (issue == null)
			{
				Text = Lng.Elem("Create issue");
				btnCreate.Text = Lng.Elem("Create");

				tbTitle.Text = String.Empty;
				tbBlocking.Text = String.Empty;
				tbBlockedBy.Text = String.Empty;
				rtbDescription.Text = String.Empty;
				dtpDueTo.Value = DateTime.Now.AddDays(7);
				cbParent.SelectedIndex = -1;
				cbIssueType.SelectedIndex = 0;
				cbIssuePriority.SelectedIndex = 2;
				cbRepetitionType.SelectedIndex = 0;
				cbOwnedBy.SelectedIndex = -1;
			}
			else
			{
				Text = Lng.Elem("Modify issue");
				btnCreate.Text = Lng.Elem("Modify");

				tbTitle.Text = issue.Title;
				//tbBlocking.Text = issue;
				//tbBlockedBy.Text = issue;
				rtbDescription.Text = issue.Description;
				dtpDueTo.Value = issue.DueDate;
				cbParent.SelectedItem = issue.Parent;
				cbIssueType.SelectedIndex = (int)issue.IssueType;
				cbIssuePriority.SelectedIndex = (int)issue.Priority;
				cbRepetitionType.SelectedIndex = (int)issue.RepetitionType;
				cbOwnedBy.SelectedItem = issue.Owner;
			}
		}

		public DialogResult ShowDialog(Issue issue = null)
		{
			this.issue = issue;
			return base.ShowDialog();
		}

		private void CbEpic_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectingIssue = false;
		}

		private void CbEpic_SelectionChangeCommitted(object sender, EventArgs e)
		{
			selectingIssue = true;
		}
	}
}
