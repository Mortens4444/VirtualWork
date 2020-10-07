using System;
using System.ComponentModel;
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
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Date;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Interfaces.Job;
using VirtualWork.Persistence.Repositories;
using VirtualWork.Service.Network;
using VirtualWork.Service.Process;
using VirtualWork.Service.Utils;
using VirtualWork.WinForms.Extensions;
using VirtualWork.WinForms.Providers;
using VirtualWork.WinForms.Utils;
using CameraRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Infrastructure.Camera, VirtualWork.Persistence.Entities.Camera>;
using EventRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Appointment.Event, VirtualWork.Persistence.Entities.Event>;
using IssueRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Job.Issue, VirtualWork.Persistence.Entities.Issue>;
using MeetingRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Appointment.Meeting, VirtualWork.Persistence.Entities.Meeting>;
using ResourceRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Infrastructure.Resource, VirtualWork.Persistence.Entities.Resource>;
using ServerRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Infrastructure.Server, VirtualWork.Persistence.Entities.Server>;

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
		private readonly AddResource addResource;
		private readonly AddServerForm addServerForm;
		private readonly AddCameraForm addCameraForm;
		private readonly CalculatorForm calculatorForm;
		private readonly EditorForm editorForm;
		private readonly PasswordManager passwordManager;
		private readonly CipherForm cipherForm;
		private readonly SendMailForm sendMailForm;
		private readonly LogViewer logViewer;
		private readonly EmailSettingsForm emailSettingsForm;
		private readonly AboutBox aboutBox;
		private readonly ServerListProvider serverListProvider;
		private readonly ResourceListProvider resourceListProvider;
		private readonly FileManager fileManager;		
		private readonly IssueListProvider issueListProvider;
		private readonly MeetingsListProvider meetingsListProvider;
		private readonly EventListProvider eventListProvider;
		private readonly IssueRepository issueRepository;
		private readonly ResourceRepository resourceRepository;
		private readonly EventRepository eventRepository;
		private readonly MeetingRepository meetingRepository;
		private readonly ServerRepository serverRepository;
		private readonly CameraRepository cameraRepository;
		private readonly CalendarItemsProvider calendarItemsProvider;
		private readonly SystemSettingsRepository systemSettingsRepository;
		private readonly WakeOnLan wakeOnLan;
		private readonly PingRequestSender pingRequestSender;
		private readonly IDateTimeProvider dateTimeProvider;
		private readonly ProcessUtils processUtils;
		private readonly ErrorBoxHelper errorBoxHelper;
		private readonly AddImageForm addImageForm;

		public MainForm(DatabaseSettingsForm databaseSettingsForm,
			UserManagementForm userManagementForm,
			UserProfileForm userProfileForm,
			UserSettingsForm userSettingsForm,
			CreateIssueForm createIssueForm,
			CreateEventForm createEventForm,
			CreateMeetingForm createMeetingForm,
			AddResource addResource,
			AddServerForm addServerForm,
			AddCameraForm addCameraForm,
			CalculatorForm calculatorForm,
			EditorForm editorForm,
			PasswordManager passwordManager,
			CipherForm cipherForm,
			SendMailForm sendMailForm,
			LogViewer logViewer,
			EmailSettingsForm emailSettingsForm,
			AboutBox aboutBox,
			ResourceListProvider resourceListProvider,
			ServerListProvider serverListProvider,
			FileManager fileManager,
			IssueListProvider issueListProvider,
			MeetingsListProvider meetingsListProvider,
			EventListProvider eventListProvider,
			IssueRepository issueRepository,
			ResourceRepository resourceRepository,
			ServerRepository serverRepository,
			CameraRepository cameraRepository,
			MeetingRepository meetingRepository,
			EventRepository eventRepository,
			CalendarItemsProvider calendarItemsProvider,
			WakeOnLan wakeOnLan,
			PingRequestSender pingRequestSender,
			SystemSettingsRepository systemSettingsRepository,
			ProcessUtils processUtils,
			ErrorBoxHelper errorBoxHelper,
			AddImageForm addImageForm,
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
			this.logViewer = logViewer;
			this.emailSettingsForm = emailSettingsForm;
			this.dateTimeProvider = dateTimeProvider;
			this.addResource = addResource;
			this.addServerForm = addServerForm;
			this.addCameraForm = addCameraForm;
			this.calculatorForm = calculatorForm;
			this.editorForm = editorForm;
			this.passwordManager = passwordManager;
			this.cipherForm = cipherForm;
			this.resourceListProvider = resourceListProvider;
			this.serverListProvider = serverListProvider;
			this.fileManager = fileManager;
			this.issueListProvider = issueListProvider;
			this.issueRepository = issueRepository;
			this.resourceRepository = resourceRepository;
			this.eventRepository = eventRepository;
			this.meetingRepository = meetingRepository;
			this.serverRepository = serverRepository;
			this.cameraRepository = cameraRepository;
			this.meetingsListProvider = meetingsListProvider;
			this.eventListProvider = eventListProvider;
			this.calendarItemsProvider = calendarItemsProvider;
			this.systemSettingsRepository = systemSettingsRepository;
			this.aboutBox = aboutBox;
			this.wakeOnLan = wakeOnLan;
			this.pingRequestSender = pingRequestSender;
			this.processUtils = processUtils;
			this.errorBoxHelper = errorBoxHelper;
			this.addImageForm = addImageForm;

			InitializeComponent();
			pTaskDetails.Dock = DockStyle.Fill;
			Translator.Translate(this);

			addResource.FormClosed += (_, __) =>
			{
				resourceListProvider.GetResources(tvItems);
			};

			fileManager.Active = lvFileExplorerLeft;
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
			resourceListProvider.GetResources(tvItems);
			GetIssues();
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
			aboutBox.Show();
		}

		private void TsmiDatabaseSettings_Click(object sender, EventArgs e)
		{
			databaseSettingsForm.ShowDialog();
		}

		private void TsmiUserManagement_Click(object sender, EventArgs e)
		{
			userManagementForm.Show();
		}

		private void TsmiUserSettings_Click(object sender, EventArgs e)
		{
			userSettingsForm.Show();
		}

		private void TsmiUserProfile_Click(object sender, EventArgs e)
		{
			userProfileForm.Show();
		}

		private void TsmiNewIssue_Click(object sender, EventArgs e)
		{
			if (createIssueForm.ShowDialog() == DialogResult.OK)
			{
				GetIssues();
			}
		}

		private void TsmiNewEvent_Click(object sender, EventArgs e)
		{
			if (createEventForm.ShowDialog() == DialogResult.OK)
			{
				eventListProvider.GetUpcomingEvents(tvItems);
			}
		}

		private void TsmiSendEmail_Click(object sender, EventArgs e)
		{
			sendMailForm.Show();
		}

		private void TsmiEmailSettings_Click(object sender, EventArgs e)
		{
			emailSettingsForm.ShowDialog();
		}

		private void TsmiNewMeeting_Click(object sender, EventArgs e)
		{
			if (createMeetingForm.ShowDialog() == DialogResult.OK)
			{
				meetingsListProvider.GetUpcomingMeetings(tvItems);
			}
		}

		private void TsmiNewServer_Click(object sender, EventArgs e)
		{
			if (addServerForm.ShowDialog() == DialogResult.OK)
			{
				serverListProvider.GetServersAndCamera(tvItems);
			}
		}

		private void TsmiNewCamera_Click(object sender, EventArgs e)
		{
			if (addCameraForm.ShowDialog() == DialogResult.OK)
			{
				serverListProvider.GetServersAndCamera(tvItems);
			}
		}

		private void TssbOpenCmd_ButtonClick(object sender, EventArgs e)
		{
			processUtils.StartAsAdmin("CMD");
		}

		private void TssbOpenPowerShellIse_ButtonClick(object sender, EventArgs e)
		{
			processUtils.StartAsAdmin("PowerShell_ISE");
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
				processUtils.Start(cbCommandPrompt.Text);
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
					case DBT_DEVICEREMOVECOMPLETE:
						GetDrives();
						break;
				}
			}
		}

		private void CbDrive_SelectedIndexChanged(object sender, EventArgs e)
		{
			fileManager.ListDriveOnTheLeft((ComboBox)sender, lvFileExplorerLeft);
		}

		private void CbDrive2_SelectedIndexChanged(object sender, EventArgs e)
		{
			fileManager.ListDriveOnTheRight((ComboBox)sender, lvFileExplorerRight);
		}

		private void LvFileExplorerLeft_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			fileManager.ListFilesOnTheLeft(lvFileExplorerLeft);
		}

		private void LvFileExplorerRight_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			fileManager.ListFilesOnTheRight(lvFileExplorerRight);
		}

		private void LvFileExplorerLeft_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (int)Keys.Enter)
			{
				fileManager.ListFilesOnTheLeft(lvFileExplorerLeft);
			}
		}

		private void LvFileExplorerRight_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (int)Keys.Enter)
			{
				fileManager.ListFilesOnTheRight(lvFileExplorerRight);
			}
		}

		private void BtnCopy_Click(object sender, EventArgs e)
		{
			try
			{
				fileManager.Copy(lvFileExplorerLeft, lvFileExplorerRight);
			}
			catch (Exception ex)
			{
				errorBoxHelper.Show(ex);
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
			fileManager.Active = (ListView)sender;
		}

		private void TvItems_MouseDown(object sender, MouseEventArgs e)
		{
			tvItems.SelectedNode = tvItems.GetNodeAt(e.X, e.Y);
		}

		private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
		{
			var enabledMenuItems = new[] { cmiNewIssue, cmiNewEvent, cmiNewMeeting, cmiCreateServer, cmiCreateCamera };

			var disabledMenuItems = new[]
			{
				cmiModifyServer, cmiDeleteServer, cmiModifyCamera, cmiDeleteCamera,
				cmiModifyIssue, cmiModifyEvent, cmiModifyMeeting,
				cmiDeleteIssue, cmiDeleteEvent, cmiDeleteMeeting,
				cmiCreateResource, cmiEditResource, cmiDeleteResource, cmiAddImage
			};

			e.Cancel = false;
			if (tvItems.SelectedNode == null)
			{
				foreach (var menuItem in enabledMenuItems)
				{
					menuItem.SetEnabled(true);
				}
				foreach (var menuItem in disabledMenuItems)
				{
					menuItem.SetEnabled(false);
				}
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
			cmiWakeOnLAN.SetEnabled(serverSelected);
			cmiCommandSender.SetEnabled(serverSelected);
			cmiPing.SetEnabled(serverSelected);

			var cameraSelected = tvItems.SelectedNode.Tag is Camera;
			cmiModifyCamera.SetEnabled(cameraSelected);
			cmiDeleteCamera.SetEnabled(cameraSelected);

			var resourceRootSelected = tvItems.SelectedNode == tvItems.Nodes[ResourceListProvider.Resources];
			cmiCreateResource.SetEnabled(resourceRootSelected);

			var resourceSelected = tvItems.SelectedNode.Tag is Resource;
			cmiEditResource.SetEnabled(resourceSelected);
			cmiDeleteResource.SetEnabled(resourceSelected);
			cmiAddImage.SetEnabled(resourceSelected);

			var menuItems = enabledMenuItems.Concat(disabledMenuItems);
			if (menuItems.All(menuItem => !menuItem.Enabled))
			{
				e.Cancel = true;
			}			
		}

		private void CmiModifyServer_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Server server)
			{
				if (addServerForm.ShowDialog(server) == DialogResult.OK)
				{
					serverListProvider.GetServersAndCamera(tvItems);
				}
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
				if (addCameraForm.ShowDialog(camera) == DialogResult.OK)
				{
					serverListProvider.GetServersAndCamera(tvItems);
				}
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
				if (createIssueForm.ShowDialog(issue) == DialogResult.OK)
				{
					GetIssues();
				}
			}
		}

		private void GetIssues()
		{
			issueListProvider.GetOngoingIssues(tvItems);
			GetTaskboradIssues();
		}

		private void GetTaskboradIssues()
		{
			var testedIssue = tvItems.SelectedNode?.Tag as Issue;
			var hasChildren = issueListProvider.GetOngoingIssues(taskboard, testedIssue);
			if (!hasChildren && testedIssue != null)
			{
				tbTaskTitle.Text = testedIssue.Title;
				rtbTaskDescription.Text = testedIssue.Description;
				dtpTaskDueTo.Value = testedIssue.DueDate;
			}
			taskboard.Visible = hasChildren;
			pTaskDetails.Visible = !hasChildren;
		}

		private void CmiDeleteIssue_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Issue issue &&
				ConfirmBox.Show(Lng.Elem("Confirmation"),
				Lng.Elem("Are you sure you want to delete the selected issue?"), Decide.No) == DialogResult.Yes)
			{
				issueRepository.Remove(issue.Id);
				GetIssues();
			}
		}

		private void CmiModifyEvent_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Event myEvent)
			{
				if (createEventForm.ShowDialog(myEvent) == DialogResult.OK)
				{
					eventListProvider.GetUpcomingEvents(tvItems);
				}
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
				if (createMeetingForm.ShowDialog(meeting) == DialogResult.OK)
				{
					meetingsListProvider.GetUpcomingMeetings(tvItems);
				}
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
			calendarItemsProvider.SetBoldDates(monthCalendar);
		}

		private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
		{
			dateTimePicker.Value = e.Start;
		}

		private void TsmiLogViewer_Click(object sender, EventArgs e)
		{
			logViewer.ShowDialog();
		}

		private void TssbCalculator_ButtonClick(object sender, EventArgs e)
		{
			calculatorForm.Show();
		}

		private void TssbEditor_ButtonClick(object sender, EventArgs e)
		{
			editorForm.Show();
		}

		private void PasswordManagerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			passwordManager.ShowDialog();
		}

		private void BtnEdit_Click(object sender, EventArgs e)
		{
			try
			{
				if (fileManager.Active.SelectedItems.Count == 1)
				{
					var path = (fileManager.Active == lvFileExplorerLeft) ? fileManager.WorkingDirectoryOnLeft : fileManager.WorkingDirectoryOnRight;
					editorForm.Show(Path.Combine(path, fileManager.Active.SelectedItems[0].Text));
				}
			}
			catch (Exception ex)
			{
				errorBoxHelper.Show(ex);
			}
		}

		private void CmiWakeOnLAN_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Server server)
			{
				wakeOnLan.SendMagicPacket(server.MacAddress);
			}
		}

		private void CmiCommandSender_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Server server)
			{
				processUtils.Start("CommandSender", server.IpAddress);
			}
		}

		private void CipherToolStripMenuItem_Click(object sender, EventArgs e)
		{
			cipherForm.Show();
		}

		private void TvItems_AfterSelect(object sender, TreeViewEventArgs e)
		{
			GetTaskboradIssues();
		}

		private void TsmiPing_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode.Tag is Server server)
			{
				pingRequestSender.SendAndShowResult(server.IpAddress);
			}
		}

		public new void ShowDialog()
		{
			throw new NotSupportedException("This method is not supported, use 'Show' instead of this function.");
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			eventListProvider.StopTasks();
			meetingsListProvider.StopTasks();
			dateTimeProvider.Stop();
		}

		private void TsmiNewResource_Click(object sender, EventArgs e)
		{
			addResource.ShowDialog();
		}

		private void CmiEditResource_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Resource resource)
			{
				if (addResource.ShowDialog(resource) == DialogResult.OK)
				{
					resourceListProvider.GetResources(tvItems);
				}
			}
		}

		private void CmiDeleteResource_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is Resource resource &&
				ConfirmBox.Show(Lng.Elem("Confirmation"),
				Lng.Elem("Are you sure you want to delete the selected resource?"), Decide.No) == DialogResult.Yes)
			{
				resourceRepository.Remove(resource.Id);
				resourceListProvider.GetResources(tvItems);
			}
		}

		private void CmiAddImage_Click(object sender, EventArgs e)
		{
			if (tvItems.SelectedNode?.Tag is IHaveIdentifier haveIdentifier)
			{
				addImageForm.Show(haveIdentifier);
			}
		}
	}
}
