using LanguageService;
using VirtualWork.Core.Cryptography;
using VirtualWork.Persistence.Repositories;
using User = VirtualWork.Persistence.Entities.User;
using UserDto = VirtualWork.Core.Actors.User;

namespace VirtualWork.WinForms.Creators
{
	public class AdminUserCreator : Creator<UserDto, User>
	{
		protected override string ConnectionSuccessfulInfoTitle => Lng.Elem("Connection successful");
		protected override string ConnectionSuccessfulInfoMessage => Lng.Elem("Connection to the database was successful and users table is not empty.");
		protected override string CreateInfoTitle => Lng.Elem("Create an administrator");
		protected override string CreateInfoMessage => Lng.Elem("You need to create at least one administrator user.");
		protected override string CreationErrorTitle => Lng.Elem("Database error");
		protected override string CreationErrorMessage => Lng.Elem("Unable to connect to database.");

		private readonly GroupRepository groupRepository;

		public AdminUserCreator(UserRepository usersRepository,
			GroupRepository groupRepository,
			AddUserForm addUserForm)
			: base(usersRepository, addUserForm)
		{
			this.groupRepository = groupRepository;
		}

		protected override void CreateDefaultEntity()
		{
			var user = new UserDto
			{
				Name = "Admin",
				PasswordHash = Hash.GetSaltedPasswordHash("P@ssw0rd"),
				IsActive = true,
				Group = groupRepository.GetAdminGroup()
			};
			repository.Add(user);
		}
	}
}
