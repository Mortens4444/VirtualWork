using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using CommentDto = VirtualWork.Core.Infrastructure.Camera;

namespace VirtualWork.Persistence.Repositories
{
	public class CameraRepository : RepositoryBase<CommentDto, Camera>
    {
        public CameraRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			CameraConverter cameraConverter)
            : base(mtfDatabase, cameraConverter, mtfDatabase.Cameras)
        {
        }
	}
}
