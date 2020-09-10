using System.Drawing;
using System.IO;
using VirtualWork.Core.Extensions;
using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Media.EntityImage;
using EntityType = VirtualWork.Persistence.Entities.EntityImage;
using EntityTypeEnum = VirtualWork.Interfaces.Enums.EntityType;

namespace VirtualWork.Persistence.Converters
{
	public class EntityImageConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly UserRepository userRepository;
		private readonly ResourceRepository resourceRepository;

		public EntityImageConverter(EntityProvider<EntityType> entityProvider,
			UserRepository userRepository,
			ResourceRepository resourceRepository,
			PropertyCopier propertyCopier,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, propertyCopier, virtualWorkDatabaseContext)
		{
			this.userRepository = userRepository;
			this.resourceRepository = resourceRepository;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.EntityId = dto.Entity.Id;
			entity.EntityType = (int)dto.EntityType;
			entity.ImageBytes = dto.Image.ToByteArray();
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Image = entity.ImageBytes.ToImage();
			dto.EntityType = (EntityTypeEnum)entity.EntityType;

			switch (dto.EntityType)
			{
				case EntityTypeEnum.User:
					dto.Entity = userRepository.Get(entity.EntityId);
					break;
				case EntityTypeEnum.Partner:
					break;
				case EntityTypeEnum.Group:
					break;
				case EntityTypeEnum.Resource:
					dto.Entity = resourceRepository.Get(entity.EntityId);
					break;
				default:
					break;
			}
		}
	}
}
