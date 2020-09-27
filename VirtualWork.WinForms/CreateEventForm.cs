using System;
using System.Windows.Forms;
using LanguageService;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Appointment;
using VirtualWork.Core.Extensions;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Service.Process;
using VirtualWork.Service.Utils;
using VirtualWork.WinForms.Extensions;
using EventRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Appointment.Event, VirtualWork.Persistence.Entities.Event>;

namespace VirtualWork.WinForms
{
	public partial class CreateEventForm : Form
	{
		private readonly EventRepository eventRepository;
		private readonly ProcessUtils processUtils;
		private Event myEvent;

		public CreateEventForm(EventRepository eventRepository,
			ProcessUtils processUtils)
		{
			this.eventRepository = eventRepository;
			this.processUtils = processUtils;

			InitializeComponent();
			Translator.Translate(this);

			cbRepetitionType.FillWithEnum<RepetitionType>();
		}

		private void CreateEventForm_Shown(object sender, EventArgs e)
		{
			if (myEvent == null)
			{
				Text = Lng.Elem("Create event");
				btnCreate.Text = Lng.Elem("Create");

				var now = DateTime.Now;
				dtpEventDate.Value = now.AddDays(1);
				dtpEventEndDate.Value = now.AddDays(1).AddHours(1);
				tbTitle.Text = String.Empty;
				tbEventLocation.Text = String.Empty;
				rtbDescription.Text = String.Empty;
				rtbStartApplication.Text = String.Empty;
				cbRepetitionType.SelectedIndex = 0;
				nudRepetitionValue.Value = 100;
			}
			else
			{
				Text = Lng.Elem("Modify event");
				btnCreate.Text = Lng.Elem("Modify");

				dtpEventDate.Value = myEvent.EventDate;
				dtpEventEndDate.Value = myEvent.EventEndDate;
				tbTitle.Text = myEvent.Title;
				tbEventLocation.Text = myEvent.EventLocation;
				rtbDescription.Text = myEvent.Description;
				rtbStartApplication.Text = $"\"{myEvent.ApplicationToStart}\" {myEvent.Arguments}";
				if (rtbStartApplication.Text == "\"\" ")
				{
					rtbStartApplication.Text = String.Empty;
				}
				nudRepetitionValue.Value = myEvent.RepetitionValue;
				cbRepetitionType.SelectedIndex = (int)myEvent.RepetitionType;
			}
		}

		private void BtnCreate_Click(object sender, EventArgs e)
		{
			myEvent = myEvent ?? new Event();
			var applicationWithParameters = rtbStartApplication.Text.GetExecutionParameters();
			myEvent.ApplicationToStart = applicationWithParameters.Application;
			myEvent.Arguments = applicationWithParameters.Parameters;
			myEvent.CreationDate = DateTime.UtcNow;
			myEvent.Creator = Initializer.LoggedInUser;
			myEvent.Description = rtbDescription.Text;
			myEvent.EventDate = dtpEventDate.Value.CutSeconds();
			myEvent.EventEndDate = dtpEventEndDate.Value.CutSeconds();
			myEvent.EventLocation = tbEventLocation.Text;
			myEvent.ExpirationDate = chkExpire.Checked ? dtpExpirationDate.Value : (DateTime?)null;
			myEvent.RepetitionValue = (int)nudRepetitionValue.Value;
			myEvent.RepetitionType = EnumUtils.GetByDescription<RepetitionType>((string)cbRepetitionType.SelectedItem);
			myEvent.Title = tbTitle.Text;
			eventRepository.AddOrUpdate(myEvent);
			myEvent = null;
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

		private void BtnTest_Click(object sender, EventArgs e)
		{
			var executionParameters = rtbStartApplication.Text.GetExecutionParameters();
			processUtils.Start(executionParameters.Application, executionParameters.Parameters);
		}

		public DialogResult ShowDialog(Event myEvent = null)
		{
			this.myEvent = myEvent;
			return base.ShowDialog();
		}
	}
}
