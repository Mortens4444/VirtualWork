using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Enums;
using LanguageService;
using LanguageService.Windows.Forms;
using MessageBoxes;
using VirtualWork.Core.Appointment;
using VirtualWork.Core.Infrastructure;
using VirtualWork.Core.Job;
using VirtualWork.Interfaces.Date;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Interfaces.Job;
using VirtualWork.Persistence.Repositories;
using VirtualWork.Service.Process;
using VirtualWork.Service.Utils;
using VirtualWork.WinForms.Extensions;
using VirtualWork.WinForms.Providers;

namespace VirtualWork.WinForms
{
	public partial class MainForm : Form
	{
		private const Int32 WM_DEVICECHANGE = 0x219;
		private const Int32 DBT_DEVICEARRIVAL = 0x8000;
		private const Int32 DBT_DEVICEREMOVECOMPLETE = 0x8004;

		private readonly DatabaseSettingsForm databaseSettingsForm;
		private readonly UserManagementForm userManagementForm;
		private readonly UserProfileForm userProfileForm;
		private readonly UserSettingsForm userSettingsForm;
		private readonly CreateIssueForm createIssueForm;
		private readonly CreateEventForm createEventForm;
		private readonly CreateMeetingForm createMeetingForm;
		private readonly AddServerForm addServerForm;
		private readonly AddCameraForm addCameraForm;
		private readonly SendMailForm sendMailForm;
		private readonly EmailSettingsForm emailSettingsForm;
		private readonly AboutBox aboutBox;
		private readonly ServerListProvider serverListProvider;
		private readonly FileAndFolderProvider fileAndFolderProvider;
		private readonly IssueListProvider issueListProvider;
		private readonly MeetingsListProvider meetingsListProvider;
		private readonly EventListProvider eventListProvider;
		private readonly IssueRepository issueRepository;
		private readonly EventRepository eventRepository;
		private readonly MeetingRepository meetingRepository;
		private readonly ServerRepository serverRepository;
		private readonly CameraRepository cameraRepository;
		private readonly CalendarItemsProvider calendarItemsProvider;
		private readonly IDateTimeProvider dateTimeProvider;

		private string workingDirectoryOnLeft;
		private string workingDirectoryOnRight;

		private ListView active;

		public MainForm(DatabaseSettingsForm databaseSettingsForm,
			UserManagementForm userManagementForm,
			UserProfileForm userProfileForm,
			UserSettingsForm userSettingsForm,
			CreateIssueForm createIssueForm,
			CreateEventForm createEventForm,
			CreateMeetingForm createMeetingForm,
			AddServerForm addServerForm,
			AddCameraForm addCameraForm,
			SendMailForm sendMailForm,
			EmailSettingsForm emailSettingsForm,
			AboutBox aboutBox,
			ServerListProvider serverListProvider,
			FileAndFolderProvider fileAndFolderProvider,
			IssueListProvider issueListProvider,
			MeetingsListProvider meetingsListProvider,
			EventListProvider eventListProvider,
			IssueRepository issueRepository,
			ServerRepository serverRepository,
			CameraRepository cameraRepository,
			MeetingRepository meetingRepository,
			EventRepository eventRepository,
			CalendarItemsProvider calendarItemsProvider,
			IDateTimeProvider dateTimeProvider)
		{
			this.databaseSettingsForm = databaseSettingsForm;
			this.userManagementForm = userManagementForm;
			this.userProfileForm = userProfileForm;
			this.userSettingsForm = userSettingsForm;
			this.createIssueForm = createIssueForm;
			this.createEventForm = createEventForm;
			this.createMeetingForm = createMeetingForm;
			this.sendMailForm = sendMailForm;
			this.emailSettingsForm = emailSettingsForm;
			this.dateTimeProvider = dateTimeProvider;
			this.addServerForm = addServerForm;
			this.addCameraForm = addCameraForm;
			this.serverListProvider = serverListProvider;
			this.fileAndFolderProvider = fileAndFolderProvider;
			this.issueListProvider = issueListProvider;
			this.issueRepository = issueRepository;
			this.eventRepository = eventRepository;
			this.meetingRepository = meetingRepository;
			this.serverRepository = serverRepository;
			this.cameraRepository = cameraRepository;
			this.meetingsListProvider = meetingsListProvider;
			this.eventListProvider = eventListProvider;
			this.calendarItemsProvider = calendarItemsProvider;
			this.aboutBox = aboutBox;

			InitializeComponent();
			Translator.Translate(this);

			active = lvFileExplorerLeft;
			workingDirectoryOnLeft = (DriveInfo.GetDrives())[0].Name;
			workingDirectoryOnRight = workingDirectoryOnLeft;
			GetDrives();

			cbView.FillWithEnum<CalendarViewType>();

			var columns = taskboard.GetColumns();
			foreach (var column in columns)
			{
				column.IssueStateChanged += TaskboardColumn_IssueStateChanged;
			}

			SetCalendarColumnSize();
		}

		private void TaskboardColumn_IssueStateChanged(object sender, IssueStateChangedEventArgs e)
		{
			var issue = issueRepository.Get(e.Issue.Id);
			if (issue.IssueState != e.Issue.IssueState)
			{
				issue.IssueState = e.Issue.IssueState;
				issueRepository.Update(issue);

				var fromColumn = taskboard.GetColumnByState(e.PreviousState);
				fromColumn.RecalculateLocations();
			}
		}

		private void GetDrives()
		{
			GetDrives(cbDrive);
			GetDrives(cbDrive2);
		}

		private void GetDrives(ComboBox comboBox)
		{
			var drives = DriveInfo.GetDrives();
			comboBox.Items.Clear();
			comboBox.Items.AddRange(drives);
			comboBox.SelectedIndex = 0;
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			dateTimeProvider.ActualDateTimeReport += DateTimeProvider_ActualDateTimeReport;
			serverListProvider.GetServersAndCamera(tvItems);
			issueListProvider.GetOngoingIssues(tvItems, taskboard);
			eventListProvider.GetUpcomingEvents(tvItems);
			meetingsListProvider.GetUpcomingMeetings(tvItems);
		}

		private void DateTimeProvider_ActualDateTimeReport(object sender, ActualDateTimeReportEventArgs e)
		{
			try
			{
				Invoke((Action)(() => { tsslDate.Text = e.DateTimeString; }));
			}
			catch
			{
				// Try ... catch block is needed because of form dispose could throw an exception here.
			}
		}

		private void TsmiExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void TsmiAbout_Click(object sender, EventArgs e)
		{
			aboutBox.ShowDialog();
		}

		private void TsmiDatabaseSettings_Click(object sender, EventArgs e)
		{
			databaseSettingsForm.ShowDialog();
		}

		private void TsmiUserManagement_Click(object sender, EventArgs e)
		{
			userManagementForm.ShowDialog();
		}

		private void TsmiUserSettings_Click(object sender, EventArgs e)
		{
			userSettingsForm.ShowDialog();
		}

		private void TsmiUserProfile_Click(object sender, EventArgs e)
		{
			userProfileForm.ShowDialog();
		}

		private void TsmiNewIssue_Click(object sender, EventArgs e)
		{
			createIssueForm.ShowDialog();
			issueListProvider.GetOngoingIssues(tvItems, taskboard);
		}

		private void TsmiNewEvent_Click(object sender, EventArgs e)
		{
			createEventForm.ShowDialog();
			eventListProvider.GetUpcomingEvents(tvItems);
		}

		private void TsmiSendEmail_Click(object sender, EventArgs e)
		{
			sendMailForm.ShowDialog();
		}

		private void TsmiEmailSettings_Click(object sender, EventArgs e)
		{
			emailSettingsForm.ShowDialog();
		}

		private void TsmiNewMeeting_Click(object sender, EventArgs e)
		{
			createMeetingForm.ShowDialog();
			meetingsListProvider.GetUpcomingMeetings(tvItems);
		}

		private void TsmiNewServer_Click(object sender, EventArgs e)
		{
			addServerForm.ShowDialog();
			serverListProvider.GetServersAndCamera(tvItems);
		}

		private void TsmiNewCamera_Click(object sender, EventArgs e)
		{
			addCameraForm.ShowDialog();
			serverListProvider.GetServersAndCamera(tvItems);
		}

		private void TssbOpenCmd_ButtonClick(object sender, EventArgs e)
		{
			ProcessUtils.StartAsAdmin("CMD");
		}

		private void TssbOpenPowerShellIse_ButtonClick(object sender, EventArgs e)
		{
			ProcessUtils.StartAsAdmin("PowerShell_ISE");
		}

		private void BtnVisit_Click(object sender, EventArgs e)
		{
			try
			{
				webBrowser.Navigate(tbWebAddress.Text);
			}
			catch { }
		}

		private void CbCommandPrompt_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				ProcessUtils.Start(cbCommandPrompt.Text);
				cbCommandPrompt.Items.Insert(0, cbCommandPrompt.Text);
				cbCommandPrompt.Text = String.Empty;
			}
		}

		private void PFileExlorer_SizeChanged(object sender, EventArgs e)
		{
			pFileExplorerLeft.Width = (int)(pFileExlorer.Width / 2);
			chFileExplorerLeftFilename.Width = lvFileExplorerLeft.Width - 25 - chFileExplorerLeftFileSize.Width;
			chFileExplorerRightFilename.Width = lvFileExplorerRight.Width - 25 - chFileExplorerRightFileSize.Width;
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == WM_DEVICECHANGE)
			{
				switch (m.WParam.ToInt32())
				{
					case DBT_DEVICEARRIVAL:
						GetDrives();
						break;
					case DBT_DEVICEREMOVECOMPLETE:
						GetDrives();
						break;
				}
			}
		}

		private void CbDrive_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListDrive((ComboBox)sender, lvFileExplorerLeft, ref workingDirectoryOnLeft);
		}

		private void CbDrive2_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListDrive((ComboBox)sender, lvFileExplorerRight, ref workingDirectoryOnRight);
		}

		private void LvFileExplorerLeft_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ListFiles(lvFileExplorerLeft, ref workingDirectoryOnLeft);
		}

		private void LvFileExplorerRight_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ListFiles(lvFileExplorerRight, ref workingDirectoryOnRight);
		}

		private void ListDrive(ComboBox comboBox, ListView listView, ref string workingDirectory)
		{
			var filesAndFolders = fileAndFolderProvider.Get(comboBox.Text);
			if (filesAndFolders.Success)
			{
				listView.FillItems(filesAndFolders.Items);
				workingDirectory = comboBox.Text;
			}
			if (listView == active)
			{
				lblWorkingDirectory.Text = workingDirectory;
			}
		}

		private void ListFiles(ListView listView, ref string workingDirectory)
		{
			if (listView.SelectedItems.Count == 1)
			{
				var navigateToParent = listView.SelectedItems[0].Text == FileAndFolderProvider.ParentDirectory;
				var fullPath = navigateToParent ? Directory.GetParent(workingDirectory).FullName :
					Path.Combine(workingDirectory, listView.SelectedItems[0].Text);

				if (File.Exists(fullPath))
				{
					ProcessUtils.Start(fullPath);
				}
				else if (Directory.Exists(fullPath))
				{
					var filesAndFolders = fileAndFolderProvider.Get(fullPath);
					if (filesAndFolders.Success)
					{
						listView.FillItems(filesAndFolders.Items, navigateToParent ? workingDirectory : null);
						workingDirectory = fullPath;
					}
				}
			}
			if (listView == active)
			{
				lblWorkingDirectory.Text = workingDirectory;
			}
		}

		private void LvFileExplorerLeft_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (int)Keys.Enter)
			{
				ListFiles(lvFileExplorerLeft, ref workingDirectoryOnLeft);
			}
		}

		private void LvFileExplorerRight_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (int)Keys.Enter)
			{
				ListFiles(lvFileExplorerRight, ref workingDirectoryOnRight);
			}
		}

		private void BtnCopy_Click(object sender, EventArgs e)
		{
			var source = active == lvFileExplorerLeft ? workingDirectoryOnLeft : workingDirectoryOnRight;
			var destination = active == lvFileExplorerLeft ? workingDirectoryOnRight : workingDirectoryOnLeft;

			foreach (ListViewItem item in active.SelectedItems)
			{
				if (item.Text == FileAndFolderProvider.ParentDirectory)
				{
					continue;
				}

				var sourceFile = Path.Combine(source, item.Text);
				var destinationFile = Path.Combine(destination, item.Text);

				DialogResult dialogResult;
				if (File.Exists(destinationFile))
				{
					dialogResult = ConfirmBox.Show(Lng.Elem("Confirmation"),
						String.Concat(Lng.Elem("Are you sure you want to overwrite this file?"), Environment.NewLine, destinationFile), Decide.No);
				}
				else
				{
					dialogResult = DialogResult.Yes;
				}

				try
				{
					File.Copy(sourceFile, destinationFile, dialogResult == DialogResult.Yes);
					if (active == lvFileExplorerLeft)
					{
						ListFiles(lvFileExplorerLeft, ref workingDirectoryOnLeft);
					}
					else
					{
						ListFiles(lvFileExplorerRight, ref workingDirectoryOnRight);
					}
				}
				catch (Exception ex)
				{
					ErrorBoxHelper.Show(ex);
				}
			}
		}

		private void BtnMove_Click(object sender, EventArgs e)
		{
		}

		private void BtnNewFolder_Click(object sender, EventArgs e)
		{
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{

		}

		private void ListView_Enter(object sender, EventArgs e)
		{
			active = (ListView)sender;
		}

		private void TvItems_MouseDown(object sender, MouseEventArgs e)
		{
			tvItems.SelectedNode = tvItems.GetNodeAt(e.X, e.Y);
		}

		private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if (tvItems.SelectedNode == null)
			{
				cmiNewEvent.SetEnabled(true);
				cmiNewIssue.SetEnabled(true);
				cmiNewMeeting.SetEnabled(true);
				cmiCreateServer.SetEnabled(true);
				cmiCreateCamera.SetEnabled(true);

				cmiModifyServer.SetEnabled(false);
				cmiDeleteServer.SetEnabled(false);
				cmiModifyCamera.SetEnabled(false);
				cmiDeleteCamera.SetEnabled(false);
				cmiModifyIssue.SetEnabled(false);
				cmiModifyEvent.SetEnabled(false);
				cmiModifyMeeting.SetEnabled(false);
				cmiDeleteIssue.SetEnabled(false);
				cmiDeleteEvent.SetEnabled(false);
				cmiDeleteMeeting.SetEnabled(false);

				return;
			}

			cmiNewEvent.SetEnabled(tvItems.SelectedNode == tvItems.Nodes[EventListProvider.Events]);
			var eventSelected = tvItems.SelectedNode.Tag is Event;
			cmiModifyEvent.SetEnabled(eventSelected);
			cmiDeleteEvent.SetEnabled(eventSelected);

			cmiNewIssue.SetEnabled(tvItems.SelectedNode == tvItems.Nodes[IssueListProvider.Issues]);
			var issueSelected = tvItems.SelectedNode.Tag is Issue;
			cmiModifyIssue.SetEnabled(issueSelected);
			cmiDeleteIssue.SetEnabled(issueSelected);

			cmiNewMeeting.SetEnabled(tvItems.SelectedNode == tvItems.Nodes[MeetingsListProvider.Meetings]);
			var meetingSelected = tvItems.SelectedNode.Tag is Meeting;
			cmiModifyMeeting.SetEnabled(meetingSelected);
			cmiDeleteMeeting.SetEnabled(meetingSelected);

			var serverRootSelected = tvItems.SelectedNode == tvItems.Nodes[ServerListProvider.Servers];
			cmiCreateServer.SetEnabled(serverRootSelected);

			var serverSelected = tvItems.SelectedNode.Tag is Server;
			cmiCreateCamera.SetEnabled(serverRootSelected || serverSelected);
			cmiModifyServer.SetEnabled(serverSelected);
			cmiDeleteServer.SetEnabled(serverSelected);

			var cameraSelected = tvItems.SelectedNode.Tag is Camera;
			cmiModifyCamera.SetEnabled(cameraSelected);
			cmiDeleteCamera.SetEnabled(cameraSelected);

			var menuItems = new[]
			{
				cmiNewIssue, cmiNewEvent, cmiNewMeeting, cmiCreateServer, cmiCreateCamera,
				cmiModifyServer, cmiDeleteServer, cmiModifyCamera, cmiDeleteCamera,
				cmiModifyIssue, cmiModifyEvent, cmiModifyMeeting,
				cmiDeleteIssue, cmiDeleteEvent, cmiDeleteMeeting
			};
			if (menuItems.All(menuItem => !menuItem.Enabled))
			{
				e.Cancel = true;
			}			
		}

		private void CmiModifyServer_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Server server)
			{
				addServerForm.ShowDialog(server);
				serverListProvider.GetServersAndCamera(tvItems);
			}
		}

		private void CmiDeleteServer_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Server server &&
				ConfirmBox.Show(Lng.Elem("Confirmation"),
					Lng.Elem("Are you sure you want to delete the selected server?"), Decide.No) == DialogResult.Yes)
			{
				serverRepository.Remove(server.Id);
				serverListProvider.GetServersAndCamera(tvItems);
			}
		}

		private void CmiModifyCamera_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Camera camera)
			{
				addCameraForm.ShowDialog(camera);
				serverListProvider.GetServersAndCamera(tvItems);
			}
		}

		private void CmiDeleteCamera_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Camera camera &&
				ConfirmBox.Show(Lng.Elem("Confirmation"),
					Lng.Elem("Are you sure you want to delete the selected camera?"), Decide.No) == DialogResult.Yes)
			{
				cameraRepository.Remove(camera.Id);
				serverListProvider.GetServersAndCamera(tvItems);
			}
		}

		private void CmiModifyIssue_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Issue issue)
			{
				createIssueForm.ShowDialog(issue);
				issueListProvider.GetOngoingIssues(tvItems, taskboard);
			}
		}

		private void CmiDeleteIssue_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Issue issue &&
				ConfirmBox.Show(Lng.Elem("Confirmation"),
				Lng.Elem("Are you sure you want to delete the selected issue?"), Decide.No) == DialogResult.Yes)
			{
				issueRepository.Remove(issue.Id);
				issueListProvider.GetOngoingIssues(tvItems, taskboard);
			}
		}

		private void CmiModifyEvent_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Event myEvent)
			{
				createEventForm.ShowDialog(myEvent);
				eventListProvider.GetUpcomingEvents(tvItems);
			}
		}

		private void CmiDeleteEvent_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Event myEvent &&
				ConfirmBox.Show(Lng.Elem("Confirmation"),
				Lng.Elem("Are you sure you want to delete the selected event?"), Decide.No) == DialogResult.Yes)
			{
				eventRepository.Remove(myEvent.Id);
				eventListProvider.GetUpcomingEvents(tvItems);
			}
		}

		private void CmiModifyMeeting_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Meeting meeting)
			{
				createMeetingForm.ShowDialog(meeting);
				meetingsListProvider.GetUpcomingMeetings(tvItems);
			}
		}

		private void CmiDeleteMeeting_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Meeting meeting &&
				ConfirmBox.Show(Lng.Elem("Confirmation"),
				Lng.Elem("Are you sure you want to delete the selected meeting?"), Decide.No) == DialogResult.Yes)
			{
				meetingRepository.Remove(meeting.Id);
				meetingsListProvider.GetUpcomingMeetings(tvItems);
			}
		}

		private void DgvCalendar_SizeChanged(object sender, EventArgs e)
		{
			SetCalendarColumnSize();
		}

		private void SetCalendarColumnSize()
		{
			dgvCalendar.Columns[0].Width = dgvCalendar.Size.Width - dgvCalendar.RowHeadersWidth - 20;
		}

		private void DateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			calendarItemsProvider.GetItems(dgvCalendar, dateTimePicker.Value);
		}
	}
}
