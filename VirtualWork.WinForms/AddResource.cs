using System;
using System.Linq;
using System.Windows.Forms;
using LanguageService;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Actors;
using VirtualWork.Core.Infrastructure;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Extensions;
using ResourceRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Infrastructure.Resource, VirtualWork.Persistence.Entities.Resource>;

namespace VirtualWork.WinForms
{
	public partial class AddResource : Form
	{
		private readonly ResourceRepository resourceRepository;
		private readonly UserRepository userRepository;
		private readonly GroupRepository groupRepository;
		private Resource resource;

		public AddResource(ResourceRepository resourceRepository,
			UserRepository userRepository,
			GroupRepository groupRepository)
		{
			this.resourceRepository = resourceRepository;
			this.userRepository = userRepository;
			this.groupRepository = groupRepository;

			InitializeComponent();
			Translator.Translate(this);

			cbOwnerType.FillWithEnum<ActorType>();
			cbResourceType.FillWithEnum<ResourceType>();
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			resource = resource ?? new Resource();
			resource.Key = rtbKey.Text;
			resource.OtherInformation = rtbOtherInformation.Text;
			resource.ActorType = (ActorType)cbOwnerType.SelectedIndex;
			resource.Actor = (Actor)cbOwner.SelectedItem;
			resource.ResourceType = (ResourceType)cbResourceType.SelectedIndex;
			resourceRepository.AddOrUpdate(resource);
			resource = null;
		}

		private void CbOwnerType_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbOwner.Items.Clear();
			var actorType = (ActorType)cbOwnerType.SelectedIndex;
			switch (actorType)
			{
				case ActorType.User:
					var users = userRepository.GetAll();
					cbOwner.Items.AddRange(users.ToArray());
					break;
				case ActorType.Partner:
					break;
				case ActorType.Group:
					var groups = groupRepository.GetAll();
					cbOwner.Items.AddRange(groups.ToArray());
					break;
				default:
					throw new NotImplementedException($"ActorType is not found: {actorType}");
			}
			cbOwner.SelectFirstIfAny();
		}

		private void AddResource_Shown(object sender, EventArgs e)
		{
			if (resource == null)
			{
				Text = Lng.Elem("Create resource");
				btnOk.Text = Lng.Elem("Add");

				cbOwnerType.SelectedIndex = 0;
				rtbKey.Text = String.Empty;
				rtbOtherInformation.Text = String.Empty;
				cbResourceType.SelectedIndex = 0;
			}
			else
			{
				Text = Lng.Elem("Modify resource");
				btnOk.Text = Lng.Elem("Modify");

				cbOwnerType.SelectedIndex = (int)resource.ActorType;
				rtbKey.Text = resource.Key;
				rtbOtherInformation.Text = resource.OtherInformation;
				cbOwner.SelectedItem = resource.Actor;
				cbResourceType.SelectedIndex = (int)resource.ResourceType;
			}
		}

		public DialogResult ShowDialog(Resource resource = null)
		{
			this.resource = resource;
			return base.ShowDialog();
		}
	}
}
