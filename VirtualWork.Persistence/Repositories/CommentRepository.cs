using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using CommentDto = VirtualWork.Core.Other.Comment;

namespace VirtualWork.Persistence.Repositories
{
	public class CommentRepository : RepositoryBase<CommentDto, Comment>
    {
        public CommentRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			CommentConverter commentConverter)
            : base(mtfDatabase, commentConverter, mtfDatabase.Comments)
        {
        }
	}
}
