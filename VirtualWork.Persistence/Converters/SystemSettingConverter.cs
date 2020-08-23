using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Settings.SystemSetting;
using EntityType = VirtualWork.Persistence.Entities.SystemSetting;

namespace VirtualWork.Persistence.Converters
{
	public class SystemSettingConverter : ConverterBase<DtoType, EntityType>
	{
		public SystemSettingConverter(EntityProvider<EntityType> entityProvider,
			PropertyCopier propertyCopier,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, propertyCopier, virtualWorkDatabaseContext)
		{
		}
	}
}
