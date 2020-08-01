using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Interfaces.Job;

namespace VirtualWork.WinForms.Controls
{
	public partial class TaskboardColumn : UserControl
	{
		public event EventHandler<IssueStateChangedEventArgs> IssueStateChanged;

		public TaskboardColumn()
		{
			InitializeComponent();
			Dock = DockStyle.Fill;
		}

		[
			Category("Behavior"),
			Description("The corresponding state of an issue associated with this column."),
			DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
			DefaultValue(new[] { IssueState.ToDo })
		]
		public IssueState[] ColumnStates { get; set; }

		public void Clear()
		{
			pMain.Controls.Clear();
		}

		public void CreateChildControl(IssueView issueView)
		{
			SetLocation(issueView);
			var previousState = issueView.Issue.IssueState;
			issueView.Issue.IssueState = ColumnStates.First();
			pMain.Controls.Add(issueView);
			OnIssueStateChanged(this, new IssueStateChangedEventArgs(issueView.Issue, previousState));
		}


		public IList<IssueView> GetIssueViews()
		{
			var result = new List<IssueView>();
			var controls = pMain.Controls;
			foreach (var control in controls)
			{
				result.Add(control as IssueView);
			}
			return result;
		}

		public void RecalculateLocations()
		{
			var panel = Controls[0] as Panel;
			for (int i = 0; i < panel.Controls.Count; i++)
			{
				var issueView = panel.Controls[i] as IssueView;
				SetLocation(issueView, i);
			}
		}

		public bool IsInThisColumn(IssueState issueState)
		{
			return ColumnStates.Any(columnState => columnState == issueState);
		}

		private void SetLocation(IssueView issueView, int? index = null)
		{
			const int delta = 5;
			var position = index ?? pMain.Controls.Count;

			var maximumViewInRow = Math.Max(pMain.Width / (issueView.Width + delta), 1);
			var deltaX = position % maximumViewInRow;
			var deltaY = position / maximumViewInRow;

			issueView.Location = new Point(deltaX * (delta + issueView.Width) + delta, deltaY * (issueView.Height + delta) + delta);
		}

		private void Panel_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetData(e.Data.GetFormats()[0]) is IssueView issueView)
			{
				if (!IsInThisColumn(issueView.Issue.IssueState))
				{
					CreateChildControl(issueView);
				}
			}
		}

		private void Panel_DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		protected virtual void OnIssueStateChanged(TaskboardColumn sender, IssueStateChangedEventArgs e)
		{
			var handler = IssueStateChanged;
			handler?.Invoke(sender, e);
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			RecalculateLocations();
		}
	}
}
