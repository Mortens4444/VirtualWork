using System;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Appointment;
using VirtualWork.Core.Extensions;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Repositories;
using VirtualWork.Service.Process;
using VirtualWork.WinForms.Extensions;
using VirtualWork.WinForms.Utils;

namespace VirtualWork.WinForms
{
	public partial class CreateEventForm : Form
	{
		private readonly EventRepository eventRepository;

		public CreateEventForm(EventRepository eventRepository)
		{
			InitializeComponent();
			Translator.Translate(this);

			this.eventRepository = eventRepository;

			cbRepeationType.FillWithEnum<RepeationType>();
		}

		private void CreateEventForm_Shown(object sender, EventArgs e)
		{
			dtpEventDate.Value = DateTime.Now.AddDays(1);
		}

		private void BtnCreate_Click(object sender, EventArgs e)
		{
			dtpEventDate.Value = new DateTime(dtpEventDate.Value.Year, dtpEventDate.Value.Month, dtpEventDate.Value.Day, dtpEventTime.Value.Hour, dtpEventTime.Value.Minute, dtpEventTime.Value.Second);
			rtbStartApplication.Text = rtbStartApplication.Text.Trim();
			var firstSpaceIndex = rtbStartApplication.Text.IndexOf(' ');
			var myEvent = new Event
			{
				ApplicationToStart = rtbStartApplication.Text.Substring(0, firstSpaceIndex),
				Arguments = rtbStartApplication.Text.Length > firstSpaceIndex ? rtbStartApplication.Text.Substring(firstSpaceIndex + 1) : String.Empty,
				CreationDate = DateTime.UtcNow,
				Creator = Initializer.LoggedInUser,
				Description = rtbDescription.Text,
				EventDate = dtpEventDate.Value.ToUniversalTime(),
				EventLocation = tbEventLocation.Text,
				ExpirationDate = chkExpire.Checked ? dtpExpirationDate.Value.ToUniversalTime() : (DateTime?)null,
				RepeationValue = (int)nudRepeationValue.Value,
				RepeationType = EnumUtils.GetByDescription<RepeationType>((string)cbRepeationType.SelectedItem),
				Title = tbTitle.Text
			};
			eventRepository.Add(myEvent);
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

		private void BtnTest_Click(object sender, EventArgs e)
		{
			var executionParameters = rtbStartApplication.Text.GetExecutionParameters();
			ProcessUtils.Start(executionParameters.Application, executionParameters.Parameters);
		}
	}
}
