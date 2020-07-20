using System;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Entities;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Contacts.Address;
using EntityType = VirtualWork.Persistence.Entities.Address;

namespace VirtualWork.Persistence.Converters
{
	public class AddressConverter : ConverterBase<DtoType, EntityType>
	{
		public AddressConverter(EntityProvider<EntityType> entityProvider,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, virtualWorkDatabaseContext)
		{
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.PublicAreaKind = (int)dto.PublicAreaKind;
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.PublicAreaKind = (PublicAreaKind)entity.PublicAreaKind;
		}
	}
}
