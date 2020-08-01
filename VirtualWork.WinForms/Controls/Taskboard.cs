using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VirtualWork.Core.Job;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.WinForms.Controls
{
	public partial class Taskboard : UserControl
	{
		public Taskboard()
		{
			InitializeComponent();
		}

		public List<IssueView> FillWithItems(IEnumerable<Issue> issues, bool appendItems = false)
		{
			var result = new List<IssueView>();
			if (!appendItems)
			{
				var columns = GetColumns();
				foreach (var column in columns)
				{
					column.Clear();
				}
			}

			foreach (var issue in issues)
			{
				var issueView = new IssueView();
				issueView.SetIssue(issue);

				var taskboardColumn = GetTaskboardColumn(issue.IssueState);
				taskboardColumn?.CreateChildControl(issueView);
				result.Add(issueView);
			}
			return result;
		}

		public IList<IssueView> GetIssueViews()
		{
			var result = new List<IssueView>();
			var columns = GetColumns();
			foreach (var column in columns)
			{
				result.AddRange(column.GetIssueViews());
			}
			return result;
		}

		public IList<TaskboardColumn> GetColumns()
		{
			var result = new List<TaskboardColumn>();
			foreach (var control in tableLayoutPanel.Controls)
			{
				if (control is TaskboardColumn taskboardColumn)
				{
					result.Add(taskboardColumn);
				}
			}
			return result;
		}

		public TaskboardColumn GetColumnByState(IssueState issueState)
		{
			var columns = GetColumns();
			foreach (var column in columns)
			{
				if (column.IsInThisColumn(issueState))
				{
					return column;
				}
			}
			return null;
		}

		private TaskboardColumn GetTaskboardColumn(IssueState issueState)
		{
			var columns = GetColumns();
			foreach (var column in columns)
			{
				if (column.IsInThisColumn(issueState))
				{
					return column;
				}
			}
			return null;
		}

		private void TableLayoutPanel_SizeChanged(object sender, EventArgs e)
		{
			var actualHeight = tableLayoutPanel.Height - tableLayoutPanel.RowStyles[0].Height;
			if (actualHeight > 0)
			{
				tableLayoutPanel.RowStyles[tableLayoutPanel.RowCount - 1].Height = actualHeight;
			}
		}
	}
}
