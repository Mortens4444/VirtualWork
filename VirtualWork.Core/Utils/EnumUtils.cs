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

		public static TEnum GetEnumValue<TEnum>(this string value)
		{
			return GetEnumValue<TEnum>(value, true);
		}

		public static TEnum GetEnumValue<TEnum>(this string value, bool ignoreCase = true)
		{
			return (TEnum)Enum.Parse(typeof(TEnum), value, ignoreCase);
		}
	}
}
