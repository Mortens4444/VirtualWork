using System;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Contacts;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork.WinForms
{
	public partial class UserProfileForm : Form
	{
		private readonly AddressRepository addressRepository;
		private readonly EmailRepository emailRepository;
		private readonly TelephoneNumberRepository telephoneNumberRepository;
		private readonly ImageRepository userImagesRepository;
		private readonly UserRepository userRepository;

		public UserProfileForm(AddressRepository addressRepository,
			EmailRepository emailRepository,
			TelephoneNumberRepository telephoneNumberRepository,
			ImageRepository userImagesRepository,
			UserRepository userRepository)
		{
			this.addressRepository = addressRepository;
			this.emailRepository = emailRepository;
			this.telephoneNumberRepository = telephoneNumberRepository;
			this.userImagesRepository = userImagesRepository;
			this.userRepository = userRepository;

			InitializeComponent();
			Translator.Translate(this);
		}

		private void UserProfileForm_Shown(object sender, EventArgs e)
		{
			var user = Initializer.LoggedInUser;
			tb_Address.Text = user.GetFirstAddress()?.FullAddress ?? String.Empty;
			tb_EmailAddress.Text = user.GetFirstEmailAddress()?.Address ?? String.Empty;
			tb_TelephoneNumber.Text = user.GetFirstTelephoneNumber()?.Number ?? String.Empty;
			tb_FullName.Text = user.FullName;
			//tb_LicensePlate.Text = user.Li
			tb_Username.Text = user.Name;
			tb_OtherInformations.Text = user.OtherInformation;
		}

		private void Btn_Save_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(tb_EmailAddress.Text))
			{
				emailRepository.AddOrUpdate(new Email
				{
					Address = tb_EmailAddress.Text,
					ActorId = Initializer.LoggedInUser.Id,
					ActorType = ActorType.User
				});
			}
		}
	}
}
