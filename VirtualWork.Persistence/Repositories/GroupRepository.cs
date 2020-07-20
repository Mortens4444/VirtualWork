using System.Linq;
using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using GroupDto = VirtualWork.Core.Security.Group;

namespace VirtualWork.Persistence.Repositories
{
	public class GroupRepository : RepositoryBase<GroupDto, Group>
    {
        public GroupRepository(
            VirtualWorkDatabaseContext mtfDatabase,
			GroupConverter groupConverter)
            : base(mtfDatabase, groupConverter, mtfDatabase.Groups)
        {
        }

		public bool HasAnyUser()
		{
			return VirtualWorkDatabase.Users.Any();
		}

		public GroupDto Get(string name)
        {
			return GetSingle(group => group.Name == name);
		}

		public GroupDto GetAdminGroup()
		{
			return Get(1);
		}
	}
}
