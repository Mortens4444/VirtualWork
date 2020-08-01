using System;
using System.Windows.Forms;
using LanguageService;
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
		private Event myEvent;

		public CreateEventForm(EventRepository eventRepository)
		{
			InitializeComponent();
			Translator.Translate(this);

			this.eventRepository = eventRepository;

			cbRepeationType.FillWithEnum<RepeationType>();
		}

		private void CreateEventForm_Shown(object sender, EventArgs e)
		{
			if (myEvent == null)
			{
				dtpEventDate.Value = DateTime.Now.AddDays(1);
				tbTitle.Text = String.Empty;
				tbEventLocation.Text = String.Empty;
				rtbDescription.Text = String.Empty;
				rtbStartApplication.Text = String.Empty;
				cbRepeationType.SelectedIndex = -1;
			}
			else
			{
				Text = Lng.Elem("Modify event");
				btnCreate.Text = Lng.Elem("Modify");

				dtpEventDate.Value = myEvent.EventDate;
				tbTitle.Text = myEvent.Title;
				tbEventLocation.Text = myEvent.EventLocation;
				rtbDescription.Text = myEvent.Description;
				rtbStartApplication.Text = $"\"{myEvent.ApplicationToStart}\" {myEvent.Arguments}";
				cbRepeationType.SelectedIndex = -1;
			}
		}

		private void BtnCreate_Click(object sender, EventArgs e)
		{
			bool create = myEvent == null;
			if (create)
			{
				myEvent = new Event();
			}

			rtbStartApplication.Text = rtbStartApplication.Text.Trim();
			var firstSpaceIndex = rtbStartApplication.Text.IndexOf(' ');

			myEvent.ApplicationToStart = rtbStartApplication.Text.Substring(0, firstSpaceIndex);
			myEvent.Arguments = rtbStartApplication.Text.Length > firstSpaceIndex ? rtbStartApplication.Text.Substring(firstSpaceIndex + 1) : String.Empty;
			myEvent.CreationDate = DateTime.UtcNow;
			myEvent.Creator = Initializer.LoggedInUser;
			myEvent.Description = rtbDescription.Text;
			myEvent.EventDate = dtpEventDate.Value;
			myEvent.EventLocation = tbEventLocation.Text;
			myEvent.ExpirationDate = chkExpire.Checked ? dtpExpirationDate.Value : (DateTime?)null;
			myEvent.RepeationValue = (int)nudRepeationValue.Value;
			myEvent.RepeationType = EnumUtils.GetByDescription<RepeationType>((string)cbRepeationType.SelectedItem);
			myEvent.Title = tbTitle.Text;

			eventRepository.AddOrUpdate(myEvent);
			myEvent = null;
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

		public DialogResult ShowDialog(Event myEvent = null)
		{
			this.myEvent = myEvent;
			return base.ShowDialog();
		}
	}
}
