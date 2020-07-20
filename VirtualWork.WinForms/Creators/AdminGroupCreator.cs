using LanguageService;
using VirtualWork.Persistence.Repositories;
using Group = VirtualWork.Persistence.Entities.Group;
using GroupDto = VirtualWork.Core.Security.Group;

namespace VirtualWork.WinForms.Creators
{
	public class AdminGroupCreator : Creator<GroupDto, Group>
	{
		protected override string ConnectionSuccessfulInfoTitle => Lng.Elem("Connection successful");
		protected override string ConnectionSuccessfulInfoMessage => Lng.Elem("Connection to the database was successful and groups table is not empty.");
		protected override string CreateInfoTitle => Lng.Elem("Create administrator group");
		protected override string CreateInfoMessage => Lng.Elem("You need to create the administrator group.");
		protected override string CreationErrorTitle => Lng.Elem("Database error");
		protected override string CreationErrorMessage => Lng.Elem("Unable to connect to database.");

		public AdminGroupCreator(GroupRepository groupRepository,
			AddAdminGroupForm addGroupForm)
			: base(groupRepository, addGroupForm)
		{
		}

		protected override void CreateDefaultEntity()
		{
			repository.Add(new GroupDto
			{
				Name = Lng.Elem("Administrators"),
				Description = Lng.Elem("Built-in administrators group"),
				IsActive = true
			});
		}
	}
}
