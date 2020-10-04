using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using LanguageService;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Extensions;
using VirtualWork.Core.Log;
using VirtualWork.Core.Utils;
using VirtualWork.Interfaces.Enums;
using VirtualWork.WinForms.Extensions;
using DbLogEntry = VirtualWork.Persistence.Entities.LogEntry;
using LogEntryRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Log.LogEntry, VirtualWork.Persistence.Entities.LogEntry>;

namespace VirtualWork.WinForms
{
	public partial class LogViewer : Form
	{
		private readonly LogEntryRepository logEntryRepository;
		private readonly ExceptionViewer exceptionViewer;
		private IList<ListViewItem> logEntries;

		public LogViewer(LogEntryRepository logEntryRepository,
			ExceptionViewer exceptionViewer)
		{
			this.logEntryRepository = logEntryRepository;
			this.exceptionViewer = exceptionViewer;

			InitializeComponent();
			Translator.Translate(this);

			cbLogLevel.Items.Add(Lng.Elem("All"));
			cbLogLevel.FillWithEnum<LogLevel>();
			GetLogItems();
		}

		private void GetLogItems(Func<Persistence.Entities.LogEntry, bool> predicate = null)
		{
			var items = logEntryRepository.GetAll(predicate);
			var convertedItems = items.Select((item, index) => { return LogEntryToListViewItem(item, index); });
			logEntries = convertedItems.OrderByDescending(listviewItem => ((LogEntry)listviewItem.Tag).Id).ToList();
			lvLogs.VirtualListSize = logEntries.Count;
		}

		private ListViewItem LogEntryToListViewItem(LogEntry logEntry, int itemIndex)
		{
			var backColor = itemIndex % 2 == 0 ? lvLogs.BackColor : Color.LightBlue;
			var listViewItem = new ListViewItem(logEntry.Id.ToString())
			{
				BackColor = backColor
			};
			listViewItem.SubItems.Add(logEntry.User?.ToString() ?? String.Empty);
			listViewItem.SubItems.Add(Lng.Elem(logEntry.LogLevel.ToString()));
			listViewItem.SubItems.Add(logEntry.Message);
			listViewItem.Tag = logEntry;
			return listViewItem;
		}

		private void TsmiExceptionViewer_Click(object sender, EventArgs e)
		{
			var selectedItem = logEntries[lvLogs.SelectedIndices[0]];
			exceptionViewer.Show(selectedItem.SubItems[3].Text);
		}

		private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
		{
			tsmiExceptionViewer.Enabled = lvLogs.SelectedIndices.Count == 1;
		}

		private void LvLogs_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
		{
			e.Item = logEntries[e.ItemIndex];
		}

		private bool IsFiltered()
		{
			return tbMessage.Text != String.Empty || cbUser.Text != String.Empty || cbLogLevel.Text != String.Empty;
		}

		private void FiltersChanged(object sender, EventArgs e)
		{
			GetItems();
		}

		private void GetItems()
		{
			Expression<Func<DbLogEntry, bool>> resultExpression = entity => true;
			Expression<Func<DbLogEntry, bool>> messageFilter = entity => entity.Message.ContainsIgnoreCase(tbMessage.Text);
			Expression<Func<DbLogEntry, bool>> userFilter = entity => entity.User != null && entity.User.FullName.ContainsIgnoreCase(cbUser.Text) || entity.User.Name.ContainsIgnoreCase(cbUser.Text);
			Expression<Func<DbLogEntry, bool>> logLevelFilter = entity => entity.LogLevel == (int)EnumUtils.GetEnumValue<LogLevel>(cbLogLevel.Text);

			if (tbMessage.Text != String.Empty)
			{
				resultExpression = resultExpression.And(messageFilter);
			}
			if (cbUser.Text != String.Empty)
			{
				resultExpression = resultExpression.And(userFilter);
			}
			else if (cbLogLevel.SelectedIndex != 0)
			{
				resultExpression = resultExpression.And(logLevelFilter);
			}
			GetLogItems(resultExpression.Compile());
		}
	}





}
