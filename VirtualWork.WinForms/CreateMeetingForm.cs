using System;
using System.Windows.Forms;
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
			dtpMeetingDate.Value = new DateTime(dtpMeetingDate.Value.Year, dtpMeetingDate.Value.Month, dtpMeetingDate.Value.Day, dtpMeetingTime.Value.Hour, dtpMeetingTime.Value.Minute, dtpMeetingTime.Value.Second);
			var meeting = new Meeting
			{
				Title = tbTitle.Text,
				CreationDate = DateTime.UtcNow,
				Description = rtbDescription.Text,
				ExpirationDate = dtpExpirationDate.Value,
				MeetingDate = dtpMeetingDate.Value,
				Owner = Initializer.LoggedInUser,
				RepeationType = EnumUtils.Get<RepeationType>((string)cbRepeationType.SelectedItem),
				RepeationValue = (int)nudRepeationValue.Value
			};
			meetingRepository.Add(meeting);
		}
	}
}
