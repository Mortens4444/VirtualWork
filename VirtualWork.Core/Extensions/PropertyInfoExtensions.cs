using System.Linq;
using System.Reflection;
using VirtualWork.Interfaces.Attributes;

namespace VirtualWork.Core.Extensions
{
	public static class PropertyInfoExtensions
	{
		public static EncryptionAttribute GetEncryptionAttribute(this PropertyInfo propertyInfo)
		{
			return propertyInfo.GetCustomAttributes(typeof(EncryptionAttribute), false).FirstOrDefault() as EncryptionAttribute;
		}
	}
}
