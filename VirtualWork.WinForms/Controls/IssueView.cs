using System.Drawing;
using System.Windows.Forms;
using VirtualWork.Core.Job;
using VirtualWork.Core.Utils;
using VirtualWork.Interfaces.Attributes;

namespace VirtualWork.WinForms.Controls
{
	public partial class IssueView : UserControl
	{
		public IssueView()
		{
			InitializeComponent();
			Anchor = AnchorStyles.Top | AnchorStyles.Left;
		}

		public void SetIssue(Issue issue)
		{
			toolStrip.BackColor = issue.IssueType.GetColoring<TitleBarColoring>();
			rtbDescription.BackColor = issue.IssueType.GetColoring<BackgroundColoring>();
			toolStrip.ForeColor = issue.IssueType.GetColoring<FontColoring>();
			rtbDescription.ForeColor = issue.IssueType.GetColoring<FontColoring>();

			tslTitle.Text = $"{issue.Id} - {issue.Title}";
			rtbDescription.Text = issue.Description;
		}

		private void ToolStrip_MouseDown(object sender, MouseEventArgs e)
		{
			DoDragDrop(this, DragDropEffects.Move);
		}
	}
}
