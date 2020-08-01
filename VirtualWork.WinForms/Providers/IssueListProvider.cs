using System.Windows.Forms;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Interfaces.Job;
using VirtualWork.Persistence.Entities;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Controls;
using IssueDto = VirtualWork.Core.Job.Issue;

namespace VirtualWork.WinForms.Providers
{
	public class IssueListProvider : ListProviderBase<IssueDto, Issue>
	{
		public const string Issues = "Issues";

		private readonly IssueRepository issueRepository;

		public IssueListProvider(IssueRepository issueRepository)
			: base(issueRepository)
		{
			this.issueRepository = issueRepository;
		}

		public void GetOngoingIssues(TreeView treeView, Taskboard taskboard)
		{
			var issueViews = taskboard.GetIssueViews();
			foreach (IssueView issueView in issueViews)
			{
				issueView.IssueBlockedStateChanged -= IssueView_IssueBlockedStateChanged;
				issueView.IssueVerifiedStateChanged -= IssueView_IssueVerifiedStateChanged;
				issueView.IssueCancelled -= IssueView_IssueCancelled;
			}

			var items = GetNodes(treeView, Issues, 1, issue => issue.IssueType != (int)IssueType.Bug && issue.IssueType != (int)IssueType.Test && issue.IssueState != (int)IssueState.Cancelled && issue.IssueState != (int)IssueState.Done);
			var newIssueViews = taskboard.FillWithItems(items);
			items = GetNodes(treeView, Issues, 33, issue => issue.IssueType == (int)IssueType.Test && issue.IssueState != (int)IssueState.Cancelled && issue.IssueState != (int)IssueState.Done, true);
			newIssueViews.AddRange(taskboard.FillWithItems(items, true));
			items = GetNodes(treeView, Issues, 32, issue => issue.IssueType == (int)IssueType.Bug && issue.IssueState != (int)IssueState.Cancelled && issue.IssueState != (int)IssueState.Done, true);
			newIssueViews.AddRange(taskboard.FillWithItems(items, true));

			foreach (IssueView issueView in newIssueViews)
			{
				issueView.IssueBlockedStateChanged += IssueView_IssueBlockedStateChanged;
				issueView.IssueVerifiedStateChanged += IssueView_IssueVerifiedStateChanged;
				issueView.IssueCancelled += IssueView_IssueCancelled;
			}
		}

		private void IssueView_IssueCancelled(object sender, IssueCancelledEventArgs e)
		{
			var issue = issueRepository.Get(e.Issue.Id);
			issue.IssueState = IssueState.Cancelled;
			issueRepository.Update(issue);
		}

		private void IssueView_IssueVerifiedStateChanged(object sender, IssueVerifiedStateChangedEventArgs e)
		{
			var issue = issueRepository.Get(e.Issue.Id);
			issue.IsVerified = e.IsVerified;
			issueRepository.Update(issue);
		}

		private void IssueView_IssueBlockedStateChanged(object sender, IssueBlockedStateChangedEventArgs e)
		{
			var issue = issueRepository.Get(e.Issue.Id);
			issue.IsBlocked = e.IsBlocked;
			issueRepository.Update(issue);
		}
	}
}
