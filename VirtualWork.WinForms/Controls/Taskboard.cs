using System;
using System.Collections.Generic;
using System.Drawing;
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

		private void Panel_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetData(e.Data.GetFormats()[0]) is Control control)
			{
				var panel = sender as Panel;
				SetLocation(control, panel);
				panel.Controls.Add(control);
			}
		}

		private static void SetLocation(Control control, Panel panel)
		{
			const int delta = 5;
			control.Location = new Point(delta, panel.Controls.Count * (control.Height + delta) + delta);
		}

		private void Panel_DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		public void FillWithItems(IEnumerable<Issue> issues, bool appendItems = false)
		{
			if (!appendItems)
			{
				pToDo.Controls.Clear();
				pInProgress.Controls.Clear();
				pReview.Controls.Clear();
				pVerification.Controls.Clear();
				pDone.Controls.Clear();
			}

			foreach (var issue in issues)
			{
				var issueView = new IssueView();
				issueView.SetIssue(issue);

				var panel = GetPanel(issue.IssueState);
				if (panel != null)
				{
					SetLocation(issueView, panel);
					panel.Controls.Add(issueView);
				}
			}
		}

		private Panel GetPanel(IssueState issueState)
		{
			switch (issueState)
			{
				case IssueState.ToDo:
					return pToDo;
				case IssueState.InProgress:
					return pInProgress;
				case IssueState.UnderReview:
					return pReview;
				case IssueState.UnderVerification:
					return pVerification;
				case IssueState.Cancelled:
				case IssueState.Done:
					return pDone;
				case IssueState.Verified:
				case IssueState.Blocked:
				default:
					return null;
			}
		}

		private void TableLayoutPanel_SizeChanged(object sender, EventArgs e)
		{
			tableLayoutPanel.RowStyles[tableLayoutPanel.RowCount - 1].Height = tableLayoutPanel.Height - tableLayoutPanel.RowStyles[0].Height;
		}
	}
}
