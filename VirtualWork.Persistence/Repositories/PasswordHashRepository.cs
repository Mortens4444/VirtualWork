using System.Linq;
using VirtualWork.Core.Cryptography.Ciphers;

namespace VirtualWork.Persistence.Repositories
{
	public class PasswordHashRepository
	{
		private readonly XorCipher xorCipher;
		private readonly VirtualWorkDatabaseContext mtfDatabase;

		public PasswordHashRepository(XorCipher xorCipher,
			VirtualWorkDatabaseContext mtfDatabase)
		{
			this.mtfDatabase = mtfDatabase;
			this.xorCipher = xorCipher;
		}

		public string GetSystemEncryptionPassword(string salt)
		{
			return GetUserEncryptionPassword(1, salt);
		}

		public string GetUserEncryptionPassword(int userId, string salt)
		{
			var currentUser = mtfDatabase.Users.AsNoTracking().Single(user => user.Id == userId);
			return xorCipher.Encrypt(currentUser.PasswordHash, salt);
		}
	}
}
