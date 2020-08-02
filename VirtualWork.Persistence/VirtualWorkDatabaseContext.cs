using System.Data.Entity;
using VirtualWork.Persistence.Entities;

namespace VirtualWork.Persistence
{
	public class VirtualWorkDatabaseContext : DbContext
    {
        public VirtualWorkDatabaseContext() : base("name=VirtualWorkDbConnectionString") { }

		public DbSet<Address> Addresses { get; set; }

		public DbSet<Camera> Cameras { get; set; }

		public DbSet<Comment> Comments { get; set; }

		public DbSet<Server> Servers { get; set; }

		public DbSet<Email> Emails { get; set; }

		public DbSet<Event> Events { get; set; }

		public DbSet<Group> Groups { get; set; }

		public DbSet<IssueHistory> IssueHistoryEntries { get; set; }

		public DbSet<Issue> Issues { get; set; }

		public DbSet<License> Licenses { get; set; }

		public DbSet<LogEntry> Logs { get; set; }

		public DbSet<Meeting> Meetings { get; set; }

		public DbSet<Permission> Permisssions { get; set; }

		public DbSet<Partner> Partners { get; set; }

		public DbSet<ResourceImage> ResourceImages { get; set; }

		public DbSet<Resource> Resources { get; set; }

		public DbSet<SystemSetting> SystemSettings { get; set; }

		public DbSet<TelephoneNumber> TelephoneNumbers { get; set; }

		public DbSet<ActorImage> UserImages { get; set; }

        public DbSet<UserSetting> UserSettings { get; set; }

		public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new Migrator());

			modelBuilder.Entity<Server>().
				HasMany<Camera>(server => server.Cameras).
				WithOptional(camera => camera.Server).
				WillCascadeOnDelete(true);

			modelBuilder.Entity<Group>()
				.HasMany<Permission>(user => user.Permissions)
				.WithMany(permission => permission.Groups)
				.Map(groupPermission =>
				{
					groupPermission.MapLeftKey("GroupId");
					groupPermission.MapRightKey("PermissionId");
				});

			modelBuilder.Entity<User>()
				.HasMany<Group>(user => user.Groups)
				.WithMany(group => group.Users)
				.Map(userGroup =>
				{
					userGroup.MapLeftKey("UserId");
					userGroup.MapRightKey("GroupId");
				});

			modelBuilder.Entity<User>()
				.HasMany<Issue>(user => user.FollowedIssues)
				.WithMany(issue => issue.Followers)
				.Map(userGroup =>
				{
					userGroup.MapLeftKey("UserId");
					userGroup.MapRightKey("IssueId");
				});

			modelBuilder.Entity<Issue>()
				.HasMany<IssueConnection>(issue => issue.IssueConnections)
				.WithRequired(connection => connection.Issue1)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Issue>()
				.HasMany<IssueConnection>(issue => issue.IssueConnections)
				.WithRequired(connection => connection.Issue2)
				.WillCascadeOnDelete(false);

			base.OnModelCreating(modelBuilder);
		}
	}
}
