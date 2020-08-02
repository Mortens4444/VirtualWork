using System;
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

		public LogViewer(LogEntryRepository logEntryRepository)
		{
			InitializeComponent();
			Translator.Translate(this);

			this.logEntryRepository = logEntryRepository;
		}

		private void LogViewer_Shown(object sender, System.EventArgs e)
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
	}
}
