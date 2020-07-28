using System.Windows.Forms;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Entities;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Controls;
using IssueDto = VirtualWork.Core.Job.Issue;

namespace VirtualWork.WinForms.Providers
{
	public class IssueListProvider : ListProviderBase<IssueDto, Issue>
	{
		public const string Issues = "Issues";

		public IssueListProvider(IssueRepository issueRepository)
			: base(issueRepository)
		{
		}

		public void GetOngoingIssues(TreeView treeView, Taskboard taskboard)
		{
			var items = GetNodes(treeView, Issues, 1, issue => issue.IssueType != (int)IssueType.Bug && issue.IssueType != (int)IssueType.Test && issue.IssueState != (int)IssueState.Cancelled && issue.IssueState != (int)IssueState.Done);
			taskboard.FillWithItems(items);
			items = GetNodes(treeView, Issues, 33, issue => issue.IssueType == (int)IssueType.Test && issue.IssueState != (int)IssueState.Cancelled && issue.IssueState != (int)IssueState.Done, true);
			taskboard.FillWithItems(items, true);
			items = GetNodes(treeView, Issues, 32, issue => issue.IssueType == (int)IssueType.Bug && issue.IssueState != (int)IssueState.Cancelled && issue.IssueState != (int)IssueState.Done, true);
			taskboard.FillWithItems(items, true);
		}
	}
}
