using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using ResourceImageDto = VirtualWork.Core.Media.ResourceImage;

namespace VirtualWork.Persistence.Repositories
{
	public class ImageRepository : RepositoryBase<ResourceImageDto, ResourceImage>
    {
        public ImageRepository(
            VirtualWorkDatabaseContext mtfDatabase,
			ResourceImageConverter resourceImageConverter)
            : base(mtfDatabase, resourceImageConverter, mtfDatabase.ResourceImages)
        {
        }
    }
}
