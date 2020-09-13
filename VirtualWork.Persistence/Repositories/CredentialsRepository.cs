using System;
using System.Collections.Generic;
using System.Linq;
using VirtualWork.Persistence.Entities;
using CredentialsConverter = VirtualWork.Persistence.Converters.ConverterBase<VirtualWork.Core.Security.Credentials, VirtualWork.Persistence.Entities.Credentials>;
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
