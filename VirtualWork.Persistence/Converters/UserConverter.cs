using System.Linq;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Actors.User;
using EntityType = VirtualWork.Persistence.Entities.User;

namespace VirtualWork.Persistence.Converters
{
	public class UserConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly GroupConverter groupConverter;
		private readonly EmailRepository emailRepository;
		private readonly TelephoneNumberRepository telephoneNumberRepository;
		private readonly AddressRepository addressRepository;

		public UserConverter(GroupConverter groupConverter,
			EmailRepository emailRepository,
			TelephoneNumberRepository telephoneNumberRepository,
			AddressRepository addressRepository,
			EntityProvider<EntityType> entityProvider,
			PropertyCopier propertyCopier,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, propertyCopier, virtualWorkDatabaseContext)
		{
			this.emailRepository = emailRepository;
			this.telephoneNumberRepository = telephoneNumberRepository;
			this.addressRepository = addressRepository;
			this.groupConverter = groupConverter;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.Groups = dto.Groups.Select(groupConverter.ToEntity).ToList();
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			var emails = emailRepository.GetAll(email => email.ActorType == (int)ActorType.User && email.ActorId == entity.Id);
			var telephoneNumbers = telephoneNumberRepository.GetAll(telephoneNumber => telephoneNumber.ActorType == (int)ActorType.User && telephoneNumber.ActorId == entity.Id);
			var addresses = addressRepository.GetAll(address => address.EntityType == (int)Interfaces.Enums.EntityType.User && address.EntityId == entity.Id);
			dto.Contacts = emails;
			dto.Contacts.Concat(telephoneNumbers);
			dto.Contacts.Concat(addresses);
			dto.Groups = entity.Groups.Select(groupConverter.ToDto).ToList();
		}
	}
}
