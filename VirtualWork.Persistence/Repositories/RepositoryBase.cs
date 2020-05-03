namespace VirtualWork.Persistence.Repositories
{
    public class RepositoryBase
    {
        protected Database VirtualWorkDatabase;

        public RepositoryBase(Database mtfDatabase)
        {
            VirtualWorkDatabase = mtfDatabase;
        }
    }
}
