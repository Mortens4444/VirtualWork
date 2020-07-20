using System.Linq;
using System.Windows.Forms;
using VirtualWork.Core.Security;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Extensions;

namespace VirtualWork.WinForms.Providers
{
	public class UserListProvider
	{
		private readonly GroupRepository groupRepository;
		private readonly UserRepository userRepository;

		public UserListProvider(GroupRepository groupRepository,
			UserRepository userRepository)
		{
			this.groupRepository = groupRepository;
			this.userRepository = userRepository;
		}

		public void GetUsersAndGroups(TreeView tvUsersAndGroups)
		{
			tvUsersAndGroups.Nodes.Clear();
			tvUsersAndGroups.Nodes.FillTreeNodeCollectionWithName(groupRepository);
			foreach (TreeNode groupTreeNode in tvUsersAndGroups.Nodes)
			{
				var group = groupTreeNode.Tag as Group;
				groupTreeNode.Nodes.FillTreeNodeCollectionWithName(userRepository, 1, user => user.Groups.Any(userGroup => userGroup.Id == group.Id));
			}
			tvUsersAndGroups.ExpandAll();
		}
	}
}
