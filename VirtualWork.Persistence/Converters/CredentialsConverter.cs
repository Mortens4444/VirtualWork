using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Security.Credentials;
using EntityType = VirtualWork.Persistence.Entities.Credentials;

namespace VirtualWork.Persistence.Converters
{
	public class CredentialsConverter : ConverterBase<DtoType, EntityType>
	{
		public CredentialsConverter(EntityProvider<EntityType> entityProvider,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, virtualWorkDatabaseContext)
		{
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.ActorType = (int)dto.ActorType;
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.ActorType = (ActorType)entity.ActorType;
		}
	}
}
