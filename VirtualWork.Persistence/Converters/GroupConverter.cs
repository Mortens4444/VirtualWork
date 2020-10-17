using System.Linq;
using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Security.Group;
using EntityType = VirtualWork.Persistence.Entities.Group;
using PermissionConverter = VirtualWork.Persistence.Converters.ConverterBase<VirtualWork.Core.Security.Permission, VirtualWork.Persistence.Entities.Permission>;

namespace VirtualWork.Persistence.Converters
{
	public class GroupConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly PermissionConverter permissionConverter;

		public GroupConverter(EntityProvider<EntityType> entityProvider,
			PermissionConverter permissionConverter,
			PropertyCopier propertyCopier,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, propertyCopier, virtualWorkDatabaseContext)
		{
			this.permissionConverter = permissionConverter;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.Permissions = dto.Permissions?.Select(permissionConverter.ToEntity).ToList();
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Permissions = entity.Permissions?.Select(permissionConverter.ToDto).ToList();
		}
	}
}
