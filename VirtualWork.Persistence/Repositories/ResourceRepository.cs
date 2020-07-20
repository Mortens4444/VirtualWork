using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using ResourceDto = VirtualWork.Core.Infrastructure.Resource;

namespace VirtualWork.Persistence.Repositories
{
	public class ResourceRepository : RepositoryBase<ResourceDto, Resource>
    {
        public ResourceRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			ResourceConverter resourceConverter)
            : base(mtfDatabase, resourceConverter, mtfDatabase.Resources)
        {
        }
	}
}
