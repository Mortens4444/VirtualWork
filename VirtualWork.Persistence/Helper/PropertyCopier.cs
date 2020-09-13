using System;
using System.Linq;
using VirtualWork.Core.Cryptography.Ciphers.Production;
using VirtualWork.Core.Extensions;
using VirtualWork.Interfaces.Attributes;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork.Persistence.Helper
{
	public class PropertyCopier
	{
		public readonly ProductionCipher productionCipher;
		public readonly PasswordHashRepository passwordHashRepository;

		public PropertyCopier(ProductionCipher productionCipher,
			PasswordHashRepository passwordHashRepository)
		{
			this.productionCipher = productionCipher;
			this.passwordHashRepository = passwordHashRepository;
		}

		public void CopyProperties(object from, object to)
		{
			var fromType = from.GetType();
			var toType = to.GetType();

			var fromProperties = fromType.GetProperties();
			var toProperties = toType.GetProperties().ToList();

			foreach (var fromProperty in fromProperties)
			{
				var toProperty = toProperties.FirstOrDefault(property => property.Name == fromProperty.Name && property.SetMethod != null);
				if (toProperty != null)
				{
					var fromValue = fromProperty.GetValue(from);
					if (fromProperty.PropertyType == toProperty.PropertyType)
					{
						// PropertyCopier should be separated and moved into Core, Encryption should be here
						if (fromProperty.PropertyType == typeof(DateTime))
						{
							if (fromProperty.HasUtcDateTimeAttribute())
							{
								fromValue = ((DateTime)fromValue).GetViewDateTimeFormat();
							}
							else if (toProperty.HasUtcDateTimeAttribute())
							{
								fromValue = ((DateTime)fromValue).GetRepositoryDateTimeFormat();
							}
						}
						else if (fromProperty.PropertyType == typeof(DateTime?))
						{
							if (fromProperty.HasUtcDateTimeAttribute())
							{
								fromValue = ((DateTime?)fromValue)?.GetViewDateTimeFormat();
							}
							else if (toProperty.HasUtcDateTimeAttribute())
							{
								fromValue = ((DateTime?)fromValue)?.GetRepositoryDateTimeFormat();
							}
						}
						else
						{
							var encryptionKey = GetEncryptionKey(fromProperty.GetEncryptionAttribute());
							if (encryptionKey != null)
							{
								fromValue = productionCipher.Decrypt(fromValue.ToString(), encryptionKey);
							}
							else
							{
								encryptionKey = GetEncryptionKey(toProperty.GetEncryptionAttribute());
								if (encryptionKey != null)
								{
									fromValue = productionCipher.Encrypt(fromValue.ToString(), encryptionKey);
								}
							}
						}

						toProperty.SetValue(to, fromValue);
					}
				}
			}
		}

		private string GetEncryptionKey(EncryptionAttribute encryptionAttribute)
		{
			if (encryptionAttribute is SimpleEncryptionAttribute simpleEncryptionAttribute)
			{
				return simpleEncryptionAttribute.EncryptionKey;
			}

			if (encryptionAttribute is SystemSpecificEncryptionAttribute systemSpecificEncryptionAttribute)
			{
				return passwordHashRepository.GetSystemEncryptionPassword(systemSpecificEncryptionAttribute.Salt);
			}

			return null;
		}
	}
}
