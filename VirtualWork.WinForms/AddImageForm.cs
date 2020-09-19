using System;
using System.ComponentModel;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Extensions;
using VirtualWork.Core.Media;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Service.Utils;
using EntityImageRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Media.EntityImage, VirtualWork.Persistence.Entities.EntityImage>;

namespace VirtualWork.WinForms
{
	public partial class AddImageForm : Form
	{
		private readonly EntityImageRepository entityImageRepository;
		private readonly ErrorBoxHelper errorBoxHelper;
		
		private EntityType entityType;
		private IHaveIdentifier entity;

		public AddImageForm(EntityImageRepository entityImageRepository,
			ErrorBoxHelper errorBoxHelper)
		{
			this.entityImageRepository = entityImageRepository;
			this.errorBoxHelper = errorBoxHelper;

			InitializeComponent();
			Translator.Translate(this);
		}

		public void Show(IHaveIdentifier entity)
		{
			rtbDescription.Text = String.Empty;
			pbImage.Image = null;
			entityType = entity.GetEntityType();
			this.entity = entity;
			Show();
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

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			entityImageRepository.Add(new EntityImage
			{
				Entity = entity,
				EntityType = entityType,
				Image = pbImage.Image,
				Description = rtbDescription.Text
			});
			Close();
		}

		private void BtnSelectPicture_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					pbImage.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
				}
				catch (Exception ex)
				{
					errorBoxHelper.Show(ex);
				}
			}
		}
	}
}
