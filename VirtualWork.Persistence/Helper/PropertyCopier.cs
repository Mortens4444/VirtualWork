using System.Linq;

namespace VirtualWork.Persistence.Helper
{
	public static class PropertyCopier
	{
		public static void CopyProperties(object from, object to)
		{
			var fromType = from.GetType();
			var toType = to.GetType();

			var fromProperties = fromType.GetProperties();
			var toProperties = toType.GetProperties().ToList();

			foreach (var fromProperty in fromProperties)
			{
				var toProperty = toProperties.FirstOrDefault(property => property.Name == fromProperty.Name);
				if (toProperty != null)
				{
					var fromValue = fromProperty.GetValue(from);
					if (fromProperty.PropertyType == toProperty.PropertyType)
					{
						toProperty.SetValue(to, fromValue);
					}
				}
			}
		}
	}
}
