using System;
using System.Linq;
using System.Reflection;
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
						fromValue = SetSpecificValue(fromProperty, toProperty, fromValue);
						toProperty.SetValue(to, fromValue);
					}
					else
					{
						if (toProperty.PropertyType.IsEnum)
						{
							toProperty.SetValue(to, Enum.ToObject(toProperty.PropertyType, fromValue));
						}
						else if (fromProperty.PropertyType.IsEnum)
						{
							toProperty.SetValue(to, Convert.ChangeType(fromValue, toProperty.PropertyType));
						}
					}
				}
			}
		}

		private object SetSpecificValue(PropertyInfo fromProperty, PropertyInfo toProperty, object fromValue)
		{
			if (fromProperty.PropertyType == typeof(DateTime))
			{
				return AutoConvertDateTime(fromProperty, toProperty, (DateTime)fromValue);
			}
			if (fromProperty.PropertyType == typeof(DateTime?))
			{
				var nullableDate = (DateTime?)fromValue;
				if (nullableDate.HasValue)
				{
					return AutoConvertDateTime(fromProperty, toProperty, nullableDate.Value);
				}
			}
			var encryptionKey = GetEncryptionKey(fromProperty.GetEncryptionAttribute());
			if (encryptionKey != null)
			{
				return productionCipher.Decrypt(fromValue.ToString(), encryptionKey);
			}
			encryptionKey = GetEncryptionKey(toProperty.GetEncryptionAttribute());
			if (encryptionKey != null)
			{
				return productionCipher.Encrypt(fromValue.ToString(), encryptionKey);
			}

			return fromValue;
		}

		private static object AutoConvertDateTime(PropertyInfo fromProperty, PropertyInfo toProperty, DateTime fromValue)
		{
			if (fromProperty.HasUtcDateTimeAttribute())
			{
				return fromValue.GetViewDateTimeFormat();
			}
			else if (toProperty.HasUtcDateTimeAttribute())
			{
				return fromValue.GetRepositoryDateTimeFormat();
			}

			return fromValue;
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
