using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using CameraDto = VirtualWork.Core.Infrastructure.Camera;
using CameraConverter = VirtualWork.Persistence.Converters.ConverterBase<VirtualWork.Core.Infrastructure.Camera, VirtualWork.Persistence.Entities.Camera>;

namespace VirtualWork.Persistence.Repositories
{
	public class CameraRepository : RepositoryBase<CameraDto, Camera>
    {
        public CameraRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			CameraConverter cameraConverter)
            : base(mtfDatabase, cameraConverter, mtfDatabase.Cameras)
        {
        }
	}
}
