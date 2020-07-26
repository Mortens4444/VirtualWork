using System;
using System.Collections.Generic;
using System.Linq;
using VirtualWork.Interfaces.Contacts;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Actors.Partner;
using EntityType = VirtualWork.Persistence.Entities.Partner;

namespace VirtualWork.Persistence.Converters
{
	public class PartnerConverter : ConverterBase<DtoType, EntityType>
	{
		public PartnerConverter(EntityProvider<EntityType> entityProvider,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, virtualWorkDatabaseContext)
		{
		}
	}
}
