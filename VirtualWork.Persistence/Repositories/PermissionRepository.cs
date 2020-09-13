using VirtualWork.Persistence.Entities;
using PermissionConverter = VirtualWork.Persistence.Converters.ConverterBase<VirtualWork.Core.Security.Permission, VirtualWork.Persistence.Entities.Permission>;
using PermissionDto = VirtualWork.Core.Security.Permission;

namespace VirtualWork.Persistence.Repositories
{
	public class PermissionRepository : RepositoryBase<PermissionDto, Permission>
    {
        public PermissionRepository(
            VirtualWorkDatabaseContext mtfDatabase,
			PermissionConverter permissionConverter)
            : base(mtfDatabase, permissionConverter, mtfDatabase.Permisssions)
		{
        }

		public PermissionDto Get(string name)
        {
			return GetSingle(permission => permission.Name == name);
		}
    }
}
