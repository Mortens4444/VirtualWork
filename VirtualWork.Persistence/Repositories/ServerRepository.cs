using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using CommentDto = VirtualWork.Core.Infrastructure.Server;

namespace VirtualWork.Persistence.Repositories
{
	public class ServerRepository : RepositoryBase<CommentDto, Server>
    {
        public ServerRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			ServerConverter serverConverter)
            : base(mtfDatabase, serverConverter, mtfDatabase.Servers)
        {
        }
	}
}
