using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LanguageService;
using LanguageService.Windows.Forms;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork.WinForms
{
	public partial class LogViewer : Form
	{
		private readonly LogEntryRepository logEntryRepository;
		private readonly ExceptionViewer exceptionViewer;

		public LogViewer(LogEntryRepository logEntryRepository,
			ExceptionViewer exceptionViewer)
		{
			this.logEntryRepository = logEntryRepository;
			this.exceptionViewer = exceptionViewer;

			InitializeComponent();
			Translator.Translate(this);
		}

		private void LogViewer_Shown(object sender, EventArgs e)
		{
			lvLogs.Items.Clear();
			var logEntries = logEntryRepository.GetAll().OrderByDescending(logEntry => logEntry.Id);

			int i = 0;
			foreach (var logEntry in logEntries)
			{
				var backColor = i % 2 == 0 ? lvLogs.BackColor : Color.LightBlue;
				var listViewItem = new ListViewItem(logEntry.Id.ToString())
				{
					BackColor = backColor					
				};
				listViewItem.SubItems.Add(logEntry.User?.ToString() ?? String.Empty);
				listViewItem.SubItems.Add(Lng.Elem(logEntry.LogLevel.ToString()));
				listViewItem.SubItems.Add(logEntry.Message);
				lvLogs.Items.Add(listViewItem);
				i++;
			}
		}

		private void TsmiExceptionViewer_Click(object sender, EventArgs e)
		{
			var selectedItem = lvLogs.SelectedItems[0];
			exceptionViewer.Show(selectedItem.SubItems[3].Text);
		}

		private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
		{
			tsmiExceptionViewer.Enabled = lvLogs.SelectedItems.Count == 1;
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}
	}
}
