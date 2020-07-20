using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using VirtualWork.Interfaces.Attributes;

namespace VirtualWork.Core.Utils
{
	public static class EnumUtils
	{
		public static string GetDescription(this Enum value)
		{
			var descriptionAttribute = value.GetAttribute<DescriptionAttribute>();
			return descriptionAttribute?.Description ?? value.ToString();
		}

		public static Color GetColoring<TColoringType>(this Enum value)
			where TColoringType : Coloring
		{
			var coloringAttribute = value.GetAttribute<TColoringType>();
			if (coloringAttribute == null)
			{
				return Color.Empty;
			}
			return Color.FromArgb(coloringAttribute.Alpha, coloringAttribute.Red, coloringAttribute.Green, coloringAttribute.Blue);
		}

		public static TAttributeType GetAttribute<TAttributeType>(this Enum value)
		{
			if (value == null)
			{
				throw new ArgumentNullException(nameof(value));
			}

			var enumType = value.GetType();
			var fieldInfo = enumType.GetField(value.ToString());
			var attributes = fieldInfo.GetCustomAttributes(typeof(TAttributeType), false);
			return (TAttributeType)attributes.FirstOrDefault();
		}

		//public static HashSet<string> GetDisctintDescriptions<TEnumType>()
		//	where TEnumType : struct, IConvertible
		//{
		//	var type = typeof(TEnumType);
		//	if (!type.IsEnum)
		//	{
		//		throw new ArgumentException("TEnumType must be an enum type");
		//	}

		//	var result = new HashSet<string>();
		//	var values = (TEnumType[])Enum.GetValues(type);
		//	foreach (var value in values)
		//	{
		//		var attributes = (value as Enum).GetEnumAttribute<DescriptionAttribute>("Description").Select(element => element.ToString());
		//		foreach (var attribute in attributes)
		//		{
		//			result.Add(attribute);
		//		}
		//	}
		//	return result;
		//}
	}
}
