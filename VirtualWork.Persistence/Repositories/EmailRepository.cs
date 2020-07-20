using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using EmailDto = VirtualWork.Core.Contacts.Email;

namespace VirtualWork.Persistence.Repositories
{
	public class EmailRepository : RepositoryBase<EmailDto, Email>
    {
        public EmailRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			EmailConverter emailConverter)
            : base(mtfDatabase, emailConverter, mtfDatabase.Emails)
        {
        }
	}
}
