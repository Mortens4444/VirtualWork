using System;
using System.Collections.Generic;
using System.Linq;
using VirtualWork.Interfaces.Contacts;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Actors.User;
using EntityType = VirtualWork.Persistence.Entities.User;

namespace VirtualWork.Persistence.Converters
{
	public class UserConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly AddressConverter addressConverter;
		private readonly GroupConverter groupConverter;

		public UserConverter(GroupConverter groupConverter,
			EntityProvider<EntityType> entityProvider,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, virtualWorkDatabaseContext)
		{
			this.groupConverter = groupConverter;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.Groups = dto.Groups.Select(groupConverter.ToEntity).ToList();
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Groups = entity.Groups.Select(groupConverter.ToDto).ToList();
		}
	}
}
