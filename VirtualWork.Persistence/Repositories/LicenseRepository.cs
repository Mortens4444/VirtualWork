using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using LicenseDto = VirtualWork.Core.Production.License;

namespace VirtualWork.Persistence.Repositories
{
	public class LicenseRepository : RepositoryBase<LicenseDto, License>
    {
        public LicenseRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			LicenseConverter licenseConverter)
            : base(mtfDatabase, licenseConverter, mtfDatabase.Licenses)
        {
        }
	}
}
