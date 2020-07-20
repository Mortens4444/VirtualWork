using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using VirtualWork.Core.Actors;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork.Persistence
{
	public class PermissionHandler
    {
		private readonly PermissionRepository permissionRepository;

		public PermissionHandler(PermissionRepository permissionRepository)
		{
			this.permissionRepository = permissionRepository;
		}

        public void SetPrincipals(User user)
        {
			IEnumerable<string> principals;
			if (user.IsAdmin())
			{
				principals = permissionRepository.GetAll().Select(permisssion => permisssion.Name);				
			}
			else
			{
				principals = user.Groups.SelectMany(group => group.Permissions.Select(groupPermission => groupPermission.Name));
			}
            var genericIdentity = new GenericIdentity(user.Name);
            Thread.CurrentPrincipal = new GenericPrincipal(genericIdentity, principals.ToArray());
        }
    }
}
