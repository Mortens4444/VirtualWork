using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using AddressDto = VirtualWork.Core.Contacts.Address;

namespace VirtualWork.Persistence.Repositories
{
	public class AddressRepository : RepositoryBase<AddressDto, Address>
    {
        public AddressRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			AddressConverter addressConverter)
            : base(mtfDatabase, addressConverter, mtfDatabase.Addresses)
        {
        }
	}
}
