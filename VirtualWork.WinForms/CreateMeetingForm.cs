﻿using System;
using System.Security.Permissions;
using System.Windows.Forms;
using LanguageService;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Appointment;
using VirtualWork.Core.Extensions;
using VirtualWork.Core.Security;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Service.Utils;
using VirtualWork.WinForms.Extensions;
using MeetingRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Appointment.Meeting, VirtualWork.Persistence.Entities.Meeting>;

namespace VirtualWork.WinForms
{
	public partial class CreateMeetingForm : Form
	{
		private readonly MeetingRepository meetingRepository;
		private Meeting meeting;

		public CreateMeetingForm(MeetingRepository meetingRepository)
		{
			this.meetingRepository = meetingRepository;

			InitializeComponent();
			Translator.Translate(this);

			cbRepetitionType.FillWithEnum<RepetitionType>();
		}

		private void CbRepetitionType_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetControlsEnable(cbRepetitionType.SelectedIndex != 0);
		}

		private void SetControlsEnable(bool isEnabled)
		{
			nudRepetitionValue.Enabled = isEnabled;
			chkExpire.Enabled = isEnabled;
			dtpExpirationDate.Enabled = isEnabled;
		}

		[PrincipalPermission(SecurityAction.Demand, Role = Roles.AppointmentCrud)]
		private void BtnCreate_Click(object sender, EventArgs e)
		{
			meeting = meeting ?? new Meeting();
			meeting.Title = tbTitle.Text;
			meeting.CreationDate = DateTime.UtcNow;
			meeting.Description = rtbDescription.Text;
			meeting.ExpirationDate = dtpExpirationDate.Value;
			meeting.MeetingDate = dtpMeetingDate.Value.CutSeconds();
			meeting.MeetingEndDate = dtpMeetingEndDate.Value.CutSeconds();
			meeting.Owner = Initializer.LoggedInUser;
			meeting.RepetitionType = EnumUtils.GetByDescription<RepetitionType>((string)cbRepetitionType.SelectedItem);
			meeting.RepetitionValue = (int)nudRepetitionValue.Value;
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
			btnCreate.Enabled = Initializer.LoggedInUser.IsInRole(Roles.AppointmentCrud);

			if (meeting == null)
			{
				Text = Lng.Elem("Create meeting");
				btnCreate.Text = Lng.Elem("Create");

				tbTitle.Text = String.Empty;
				rtbDescription.Text = String.Empty;
				cbPartner.SelectedIndex = -1;
				cbMeetingPoint.SelectedIndex = -1;
				dtpMeetingDate.Value = DateTime.Now.AddDays(1).CutMinutes();
				cbRepetitionType.SelectedIndex = 0;
				nudRepetitionValue.Value = 100;
			}
			else
			{
				Text = Lng.Elem("Modify meeting");
				btnCreate.Text = Lng.Elem("Modify");

				tbTitle.Text = meeting.Title;
				rtbDescription.Text = meeting.Description;
				dtpMeetingDate.Value = meeting.MeetingDate;
				dtpMeetingEndDate.Value = meeting.MeetingEndDate;
				nudRepetitionValue.Value = meeting.RepetitionValue;
				cbRepetitionType.SelectedIndex = (int)meeting.RepetitionType;

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

		private void DtpMeetingDate_ValueChanged(object sender, EventArgs e)
		{
			dtpMeetingEndDate.Value = dtpMeetingDate.Value.AddHours(1);
			dtpExpirationDate.Value = dtpMeetingDate.Value.AddMonths(1);
		}
	}
}
