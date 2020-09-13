using VirtualWork.Persistence.Entities;
using AddressDto = VirtualWork.Core.Contacts.Address;
using AddressConverter = VirtualWork.Persistence.Converters.ConverterBase<VirtualWork.Core.Contacts.Address, VirtualWork.Persistence.Entities.Address>;

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
