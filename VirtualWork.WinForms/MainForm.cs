﻿using System;
using System.IO;
using System.Windows.Forms;
using Enums;
using LanguageService;
using LanguageService.Windows.Forms;
using MessageBoxes;
using VirtualWork.Interfaces.Date;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Service.Process;
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
		private readonly CreateIssueForm createTaskForm;
		private readonly CreateEventForm createEventForm;
		private readonly CreateMeetingForm createMeetingForm;
		private readonly AddServerForm addServerForm;
		private readonly AddCameraForm addCameraForm;
		private readonly SendMailForm sendMailForm;
		private readonly EmailSettingsForm emailSettingsForm;
		private readonly AboutBox aboutBox;
		private readonly ServerListProvider serverListProvider;
		private readonly FileAndFolderProvider fileAndFolderProvider;
		private readonly IDateTimeProvider dateTimeProvider;

		private string workingDirectoryOnLeft;
		private string workingDirectoryOnRight;

		private ListView active;

		public MainForm(DatabaseSettingsForm databaseSettingsForm,
			UserManagementForm userManagementForm,
			UserProfileForm userProfileForm,
			UserSettingsForm userSettingsForm,
			CreateIssueForm createTaskForm,
			CreateEventForm createEventForm,
			CreateMeetingForm createMeetingForm,
			AddServerForm addServerForm,
			AddCameraForm addCameraForm,
			SendMailForm sendMailForm,
			EmailSettingsForm emailSettingsForm,
			AboutBox aboutBox,
			ServerListProvider serverListProvider,
			FileAndFolderProvider fileAndFolderProvider,
			IDateTimeProvider dateTimeProvider)
		{
			InitializeComponent();
			Translator.Translate(this);

			this.databaseSettingsForm = databaseSettingsForm;
			this.userManagementForm = userManagementForm;
			this.userProfileForm = userProfileForm;
			this.userSettingsForm = userSettingsForm;
			this.createTaskForm = createTaskForm;
			this.createEventForm = createEventForm;
			this.createMeetingForm = createMeetingForm;
			this.sendMailForm = sendMailForm;
			this.emailSettingsForm = emailSettingsForm;
			this.dateTimeProvider = dateTimeProvider;
			this.addServerForm = addServerForm;
			this.addCameraForm = addCameraForm;
			this.serverListProvider = serverListProvider;
			this.fileAndFolderProvider = fileAndFolderProvider;
			this.aboutBox = aboutBox;

			active = lvFileExplorerLeft;
			workingDirectoryOnLeft = (DriveInfo.GetDrives())[0].Name;
			workingDirectoryOnRight = workingDirectoryOnLeft;
			GetDrives();

			cbView.FillWithEnum<CalendarViewType>();
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
		}

		private void DateTimeProvider_ActualDateTimeReport(object sender, ActualDateTimeReportEventArgs e)
		{
			try
			{
				Invoke((Action)(() => { tsslDate.Text = e.DateTimeString; }));
				//Invoke((MethodInvoker)delegate { tsslDate.Text = e.DateTimeString; });
			}
			catch { }
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

		private void TsmiNewTask_Click(object sender, EventArgs e)
		{
			createTaskForm.ShowDialog();
		}

		private void TsmiNewEvent_Click(object sender, EventArgs e)
		{
			createEventForm.ShowDialog();
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

		private void ToolStripSplitButton1_ButtonClick(object sender, EventArgs e)
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
					ErrorBox.Show(ex);
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
	}
}
