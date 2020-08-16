using System;
using VirtualWork.Core.Cryptography;
using VirtualWork.Core.Cryptography.Ciphers;
using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using UserDto = VirtualWork.Core.Actors.User;

namespace VirtualWork.Persistence.Repositories
{
	public class UserRepository : RepositoryBase<UserDto, User>
    {
		private readonly XorCipher xorCipher;

		public UserRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			XorCipher xorCipher,
			UserConverter userConverter)
            : base(mtfDatabase, userConverter, mtfDatabase.Users)
        {
			this.xorCipher = xorCipher;
		}

		public UserDto Get(string name)
        {
			return GetSingle(user => user.Name == name && user.IsActive);
		}

		public UserDto GetArchived(string name)
		{
			return GetSingle(user => user.Name == name && !user.IsActive);
		}

		public string GetSystemEncryptionPassword(string salt)
		{
			return GetUserEncryptionPassword(1, salt);
		}

		public string GetUserEncryptionPassword(int userId, string salt)
		{
			return xorCipher.Encrypt(GetSingle(user => user.Id == userId).PasswordHash, salt);
		}
	}
}
