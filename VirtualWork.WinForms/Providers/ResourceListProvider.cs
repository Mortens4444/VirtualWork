using System.Windows.Forms;
using VirtualWork.Interfaces.Enums;
using ResourceRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Infrastructure.Resource, VirtualWork.Persistence.Entities.Resource>;

namespace VirtualWork.WinForms.Providers
{
	public class ResourceListProvider
	{
		public const string Resources = "Resources";

		private readonly ResourceRepository resourceRepository;

		public ResourceListProvider(ResourceRepository resourceRepository)
		{
			this.resourceRepository = resourceRepository;
		}

		public void GetResources(TreeView treeView)
		{
			var rootNode = treeView.Nodes[Resources];
			rootNode.Nodes.Clear();

			var items = resourceRepository.GetAll();
			foreach (var item in items)
			{
				var imageIndex = GetNodeIndex(item.ResourceType);
				var treeNode = new TreeNode(item.Key)
				{
					Tag = item,
					ImageIndex = imageIndex,
					SelectedImageIndex = imageIndex
				};
				rootNode.Nodes.Add(treeNode);
			}

			rootNode.ExpandAll();
		}

		private static int GetNodeIndex(ResourceType resourceType)
		{
			switch (resourceType)
			{
				case ResourceType.Car:
					return 38;
				case ResourceType.SoftwareLicense:
					return 39;
				case ResourceType.DesktopComputer:
					return 40;
				case ResourceType.MobilePhone:
					return 41;
				case ResourceType.Display:
					return 42;
				case ResourceType.Keyboard:
					return 43;
				case ResourceType.Mouse:
					return 44;
				case ResourceType.Laptop:
					return 45;
				default:
					return 37;
			}
		}
	}
}
