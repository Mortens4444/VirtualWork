using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Production.License;
using EntityType = VirtualWork.Persistence.Entities.License;

namespace VirtualWork.Persistence.Converters
{
	public class LicenseConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly UserRepository userRepository;

		public LicenseConverter(EntityProvider<EntityType> entityProvider,
			UserRepository userRepository,
			PropertyCopier propertyCopier,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, propertyCopier, virtualWorkDatabaseContext)
		{
			this.userRepository = userRepository;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.ActorId = dto.Actor.Id;
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Actor = userRepository.Get(entity.ActorId);
		}
	}
}
