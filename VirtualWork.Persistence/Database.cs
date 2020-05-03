//#define DO_NOT_CREATE_DATABASE

using VirtualWork.Persistence.Entities;
using System.Data.Entity;

namespace VirtualWork.Persistence
{
    public class Database : DbContext
    {
        public Database() : base("name=DbConnectionString") { }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Option> Options { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #if DO_NOT_CREATE_DATABASE
                System.Data.Entity.Database.SetInitializer<Database>(null);
            #endif
            base.OnModelCreating(modelBuilder);
        }
    }
}
