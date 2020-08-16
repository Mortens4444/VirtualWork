using System;
using System.Collections.Generic;
using System.Linq;
using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using CredentialsDto = VirtualWork.Core.Security.Credentials;

namespace VirtualWork.Persistence.Repositories
{
	public class CredentialsRepository : RepositoryBase<CredentialsDto, Credentials>
    {
        public CredentialsRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			CredentialsConverter credentialsConverter)
            : base(mtfDatabase, credentialsConverter, mtfDatabase.Credentials)
        {
        }

		public IEnumerable<string> GetGroups(Func<Credentials, bool> predicate)
		{
			return DatabaseTable.AsNoTracking().Where(predicate).Select(x => x.Group).Distinct();
		}
	}
}
