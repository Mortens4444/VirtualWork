using System;
using System.Windows.Forms;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Repositories;

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
				case ResourceType.DesktopComputer:
				case ResourceType.Laptop:
				case ResourceType.MobilePhone:
				case ResourceType.SoftwareLicense:
					return 37;
				default:
					throw new ArgumentOutOfRangeException($"No image available for resource type: {resourceType}");
			}
		}
	}
}
