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
			dtpEventDate.Value = DateTime.UtcNow.AddDays(1);
		}

		private void BtnCreate_Click(object sender, EventArgs e)
		{
			rtbStartApplication.Text = rtbStartApplication.Text.Trim();
			var firstSpaceIndex = rtbStartApplication.Text.IndexOf(' ');
			var myEvent = new Event
			{
				ApplicationToStart = rtbStartApplication.Text.Substring(0, firstSpaceIndex),
				Arguments = rtbStartApplication.Text.Length > firstSpaceIndex ? rtbStartApplication.Text.Substring(firstSpaceIndex + 1) : String.Empty,
				CreationDate = DateTime.UtcNow,
				Creator = Initializer.LoggedInUser,
				Description = rtbDescription.Text,
				EventDate = dtpEventDate.Value,
				ExpirationDate = chkExpire.Checked ? dtpExpirationDate.Value : (DateTime?)null,
				RepeationValue = (int)nudRepeationValue.Value,
				RepeationType = EnumUtils.Get<RepeationType>((string)cbRepeationType.SelectedItem),
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
	}
}
