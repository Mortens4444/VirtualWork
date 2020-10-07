using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Contacts;
using VirtualWork.Core.Media;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Repositories;
using VirtualWork.Service.Utils;
using AddressRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Contacts.Address, VirtualWork.Persistence.Entities.Address>;
using EntityImageRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Media.EntityImage, VirtualWork.Persistence.Entities.EntityImage>;
using TelephoneNumberRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Contacts.TelephoneNumber, VirtualWork.Persistence.Entities.TelephoneNumber>;

namespace VirtualWork.WinForms
{
	public partial class UserProfileForm : Form
	{
		private readonly AddressRepository addressRepository;
		private readonly EmailRepository emailRepository;
		private readonly TelephoneNumberRepository telephoneNumberRepository;
		private readonly EntityImageRepository entityImageRepository;
		private readonly UserRepository userRepository;
		private readonly ErrorBoxHelper errorBoxHelper;

		public UserProfileForm(AddressRepository addressRepository,
			EmailRepository emailRepository,
			TelephoneNumberRepository telephoneNumberRepository,
			EntityImageRepository entityImageRepository,
			UserRepository userRepository,
			ErrorBoxHelper errorBoxHelper)
		{
			this.addressRepository = addressRepository;
			this.emailRepository = emailRepository;
			this.telephoneNumberRepository = telephoneNumberRepository;
			this.entityImageRepository = entityImageRepository;
			this.userRepository = userRepository;
			this.errorBoxHelper = errorBoxHelper;

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
			var entityImage = entityImageRepository.Get(image => image.EntityId == user.Id && image.EntityType == (int)EntityType.User);
			pb_Image.Image = entityImage?.Image;
			pb_Image.Tag = entityImage;
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
			if (pb_Image.Image != null)
			{
				var entityImage = ((EntityImage)pb_Image.Tag);
				entityImageRepository.AddOrUpdate(new EntityImage
				{
					Id = entityImage?.Id ?? 0,
					Entity = Initializer.LoggedInUser,
					EntityType = EntityType.User,
					Image = pb_Image.Image
				});
			}
			Close();
		}

		public new void ShowDialog()
		{
			throw new NotSupportedException("This method is not supported, use 'Show' instead of this function.");
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Btn_SelectPicture_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					pb_Image.Image = Image.FromFile(openFileDialog.FileName);
				}
				catch (Exception ex)
				{
					errorBoxHelper.Show(ex);
				}
			}
		}
	}
}
