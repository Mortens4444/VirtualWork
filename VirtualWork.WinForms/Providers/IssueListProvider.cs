using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Interfaces.Job;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Controls;
using VirtualWork.WinForms.Extensions;
using IssueDto = VirtualWork.Core.Job.Issue;

namespace VirtualWork.WinForms.Providers
{
	public class IssueListProvider
	{
		public const string Issues = "Issues";

		private readonly IssueRepository issueRepository;

		public IssueListProvider(IssueRepository issueRepository)
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

			var rootNode = treeView.Nodes[Issues];
			rootNode.Nodes.Clear();

			var issues = issueRepository.GetAll(issue =>
				 issue.IssueState != (int)IssueState.Cancelled &&
				 issue.IssueState != (int)IssueState.Done).ToList();

			var items = GetNodes(rootNode.Nodes, issues);
			var otherNotCompletedIssues = issues.Except(items);
			foreach (var otherNotCompletedIssue in otherNotCompletedIssues)
			{
				var treeNode = otherNotCompletedIssue.CreateTreeNode(GetNodeIndex(otherNotCompletedIssue.IssueType));
				items.Add(otherNotCompletedIssue);
				rootNode.Nodes.Add(treeNode);
			}

			var taskboardItems = issues.Where(issue => issues.All(currentIssue => currentIssue.Parent?.Id != issue.Id));
			var newIssueViews = taskboard.FillWithItems(taskboardItems);
			rootNode.ExpandAll();

			foreach (IssueView issueView in newIssueViews)
			{
				issueView.IssueBlockedStateChanged += IssueView_IssueBlockedStateChanged;
				issueView.IssueVerifiedStateChanged += IssueView_IssueVerifiedStateChanged;
				issueView.IssueCancelled += IssueView_IssueCancelled;
			}
		}

		private IList<IssueDto> GetNodes(TreeNodeCollection nodes, IList<IssueDto> issues, IssueDto parent = null)
		{
			var result = new List<IssueDto>();

			var filteredIssues = issues.Where(currentIssue => currentIssue.Parent?.Id == parent?.Id);
			foreach (var issue in filteredIssues)
			{
				var treeNode = issue.CreateTreeNode(GetNodeIndex(issue.IssueType));
				var children = GetNodes(treeNode.Nodes, issues, issue);
				result.AddRange(children);
				result.Add(issue);
				nodes.Add(treeNode);
			}

			return result;
		}

		private static int GetNodeIndex(IssueType issueType)
		{
			switch (issueType)
			{
				case IssueType.Epic:
					return 35;
				case IssueType.Story:
					return 34;
				case IssueType.Task:
					return 36;
				case IssueType.Test:
					return 33;
				case IssueType.Bug:
					return 32;
				default:
					throw new ArgumentOutOfRangeException($"No image available for issue type: {issueType}");
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
