using System;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Job;
using VirtualWork.Core.Utils;
using VirtualWork.Interfaces.Attributes;
using VirtualWork.Interfaces.Job;

namespace VirtualWork.WinForms.Controls
{
	public partial class IssueView : UserControl
	{
		public event EventHandler<IssueBlockedStateChangedEventArgs> IssueBlockedStateChanged;
		public event EventHandler<IssueVerifiedStateChangedEventArgs> IssueVerifiedStateChanged;
		public event EventHandler<IssueCancelledEventArgs> IssueCancelled;

		public IssueView()
		{
			InitializeComponent();
			Translator.Translate(this);

			Anchor = AnchorStyles.Top | AnchorStyles.Left;
		}

		public Issue Issue { get; set; }

		public void SetIssue(Issue issue)
		{
			Issue = issue;
			toolStrip.BackColor = issue.IssueType.GetColoring<TitleBarColoring>();
			rtbDescription.BackColor = issue.IssueType.GetColoring<BackgroundColoring>();
			toolStrip.ForeColor = issue.IssueType.GetColoring<FontColoring>();
			rtbDescription.ForeColor = issue.IssueType.GetColoring<FontColoring>();

			tslTitle.Text = issue.ToString();
			rtbDescription.Text = issue.Description;
		}

		private void ToolStrip_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				DoDragDrop(this, DragDropEffects.Move);
			}
		}

		protected virtual void OnIssueBlockedStateChanged(IssueView sender, IssueBlockedStateChangedEventArgs e)
		{
			var handler = IssueBlockedStateChanged;
			handler?.Invoke(sender, e);
		}

		protected virtual void OnIssueVerifiedStateChanged(IssueView sender, IssueVerifiedStateChangedEventArgs e)
		{
			var handler = IssueVerifiedStateChanged;
			handler?.Invoke(sender, e);
		}

		protected virtual void OnIssueCancelled(IssueView sender, IssueCancelledEventArgs e)
		{
			var handler = IssueCancelled;
			handler?.Invoke(sender, e);
		}

		private void CmiBlocked_CheckedChanged(object sender, EventArgs e)
		{
			OnIssueBlockedStateChanged(this, new IssueBlockedStateChangedEventArgs(Issue, cmiBlocked.Checked));
		}

		private void CmiVerified_Click(object sender, EventArgs e)
		{
			OnIssueVerifiedStateChanged(this, new IssueVerifiedStateChangedEventArgs(Issue, cmiVerified.Checked));
		}

		private void CmiCancel_Click(object sender, EventArgs e)
		{
			OnIssueCancelled(this, new IssueCancelledEventArgs(Issue));
		}

		private void TslTitle_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				contextMenuStrip.Show(PointToScreen(e.Location));
			}
		}
	}
}
