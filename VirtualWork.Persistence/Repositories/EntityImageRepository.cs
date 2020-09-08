using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using EntityImageDto = VirtualWork.Core.Media.EntityImage;

namespace VirtualWork.Persistence.Repositories
{
	public class EntityImageRepository : RepositoryBase<EntityImageDto, EntityImage>
    {
        public EntityImageRepository(
            VirtualWorkDatabaseContext mtfDatabase,
			EntityImageConverter entityImageConverter)
            : base(mtfDatabase, entityImageConverter, mtfDatabase.EntityImages)
        {
        }
    }
}
