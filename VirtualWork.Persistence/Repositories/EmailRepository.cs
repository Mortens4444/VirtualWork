using System;
using System.Linq.Expressions;
using VirtualWork.Interfaces;
using VirtualWork.Persistence.Entities;
using EmailConverter = VirtualWork.Persistence.Converters.ConverterBase<VirtualWork.Core.Contacts.Email, VirtualWork.Persistence.Entities.Email>;
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

		protected override Expression<Func<Email, bool>> EntitySearchPredicate(EmailDto dto)
		{
			return dbEntity => dbEntity.ActorId == dto.ActorId && dbEntity.ActorType == (int)dto.ActorType;
		}
	}
}
