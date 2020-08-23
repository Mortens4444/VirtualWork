using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using UserDto = VirtualWork.Core.Actors.User;

namespace VirtualWork.Persistence.Repositories
{
	public class UserRepository : RepositoryBase<UserDto, User>
    {
		public UserRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			UserConverter userConverter)
            : base(mtfDatabase, userConverter, mtfDatabase.Users)
        {
		}

		public UserDto Get(string name)
        {
			return GetSingle(user => user.Name == name && user.IsActive);
		}

		public UserDto GetArchived(string name)
		{
			return GetSingle(user => user.Name == name && !user.IsActive);
		}
	}
}
