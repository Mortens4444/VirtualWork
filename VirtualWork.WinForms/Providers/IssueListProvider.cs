using System.Windows.Forms;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Extensions;

namespace VirtualWork.WinForms.Providers
{
	public class IssueListProvider
	{
		private readonly IssueRepository issueRepository;

		public IssueListProvider(IssueRepository issueRepository)
		{
			this.issueRepository = issueRepository;
		}

		public void GetOngoingIssues(TreeView treeView)
		{
			var issuesGroupNode = treeView.Nodes["Issues"];
			var issueNodes = issuesGroupNode.Nodes;
			issueNodes.Clear();
			issueNodes.FillTreeNodeCollectionWithTitle(issueRepository, 1, issue => issue.IssueState != (int)IssueState.Cancelled && issue.IssueState != (int)IssueState.Done);
			issuesGroupNode.ExpandAll();
		}
	}
}
