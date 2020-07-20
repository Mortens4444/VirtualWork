using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using TelephoneNumberDto = VirtualWork.Core.Contacts.TelephoneNumber;

namespace VirtualWork.Persistence.Repositories
{
	public class TelephoneNumberRepository : RepositoryBase<TelephoneNumberDto, TelephoneNumber>
    {
        public TelephoneNumberRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			TelephoneNumberConverter telephoneNumberConverter)
            : base(mtfDatabase, telephoneNumberConverter, mtfDatabase.TelephoneNumbers)
        {
        }
	}
}
