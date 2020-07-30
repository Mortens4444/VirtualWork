using System;
using System.Windows.Forms;
using LanguageService;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Appointment;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Extensions;
using VirtualWork.WinForms.Utils;

namespace VirtualWork.WinForms
{
	public partial class CreateMeetingForm : Form
	{
		private readonly MeetingRepository meetingRepository;
		private Meeting meeting;

		public CreateMeetingForm(MeetingRepository meetingRepository)
		{
			InitializeComponent();
			Translator.Translate(this);

			this.meetingRepository = meetingRepository;

			cbRepeationType.FillWithEnum<RepeationType>();
		}

		private void CbRepeationType_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetControlsEnable(cbRepeationType.SelectedIndex != 0);
		}

		private void SetControlsEnable(bool isEnabled)
		{
			nudRepeationValue.Enabled = isEnabled;
			chkExpire.Enabled = isEnabled;
			dtpExpirationDate.Enabled = isEnabled;
		}

		private void BtnCreate_Click(object sender, EventArgs e)
		{
			bool create = meeting == null;
			if (create)
			{
				meeting = new Meeting();
			}

			meeting.Title = tbTitle.Text;
			meeting.CreationDate = DateTime.UtcNow;
			meeting.Description = rtbDescription.Text;
			meeting.ExpirationDate = dtpExpirationDate.Value;
			meeting.MeetingDate = dtpMeetingDate.Value;
			meeting.Owner = Initializer.LoggedInUser;
			meeting.RepeationType = EnumUtils.GetByDescription<RepeationType>((string)cbRepeationType.SelectedItem);
			meeting.RepeationValue = (int)nudRepeationValue.Value;
			meeting.MeetingPoint = cbMeetingPoint.Text;

			meetingRepository.AddOrUpdate(meeting);
			meeting = null;
		}

		public DialogResult ShowDialog(Meeting meeting = null)
		{
			this.meeting = meeting;
			return base.ShowDialog();
		}

		private void CreateMeetingForm_Shown(object sender, EventArgs e)
		{
			if (meeting == null)
			{
				tbTitle.Text = String.Empty;
				rtbDescription.Text = String.Empty;
				cbPartner.SelectedIndex = -1;
				cbMeetingPoint.SelectedIndex = -1;
				dtpMeetingDate.Value = DateTime.Now.AddDays(1);
			}
			else
			{
				Text = Lng.Elem("Modify meeting");
				btnCreate.Text = Lng.Elem("Modify");

				tbTitle.Text = meeting.Title;
				rtbDescription.Text = meeting.Description;
				dtpMeetingDate.Value = meeting.MeetingDate;

				//if (meeting.PartnerId != null)
				//{
				//	foreach (Server server in cbServer.Items)
				//	{
				//		if (server.Id == camera.ServerId)
				//		{
				//			cbServer.SelectedItem = server;
				//			break;
				//		}
				//	}
				//}

				//if (meeting.MeetingPoint != null)
				//{
				//	foreach (MeetingPoint meetingPoint in cbMeetingPoint.Items)
				//	{
				//		if (meetingPoint.Id == meeting.MeetingPointId)
				//		{
				//			cbMeetingPoint.SelectedItem = meetingPoint;
				//			break;
				//		}
				//	}
				//}
			}
		}
	}
}
