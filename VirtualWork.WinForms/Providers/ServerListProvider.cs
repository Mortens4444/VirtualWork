using System.Windows.Forms;
using VirtualWork.Core.Infrastructure;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Extensions;

namespace VirtualWork.WinForms.Providers
{
	public class ServerListProvider
	{
		public const string Servers = "Servers";

		private readonly ServerRepository serverRepository;
		private readonly CameraRepository cameraRepository;

		public ServerListProvider(ServerRepository serverRepository,
			CameraRepository cameraRepository)
		{
			this.serverRepository = serverRepository;
			this.cameraRepository = cameraRepository;
		}

		public void GetServersAndCamera(TreeView treeView)
		{
			var serverGroupNode = treeView.Nodes[Servers];
			var serverNodes = serverGroupNode.Nodes;
			serverNodes.Clear();
			serverNodes.FillTreeNodeCollectionWithName(serverRepository);
			foreach (TreeNode serverTreeNode in serverNodes)
			{
				var server = serverTreeNode.Tag as Server;
				serverTreeNode.Nodes.FillTreeNodeCollectionWithName(cameraRepository, 31, camera => camera.ServerId == server.Id);
			}

			serverNodes.FillTreeNodeCollectionWithName(cameraRepository, 31, camera => camera.ServerId == null);
			serverGroupNode.ExpandAll();
		}
	}
}
