//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using LanguageService.Extensions;

//namespace VirtualWork.Core.Utils
//{
//	public static class EnumUtils
//	{
//		public static HashSet<string>GetDisctintDescriptions<TEnumType>()
//			where TEnumType : struct, IConvertible
//		{
//			var type = typeof(TEnumType);
//			if (!type.IsEnum)
//			{
//				throw new ArgumentException("TEnumType must be an enum type");
//			}

//			var result = new HashSet<string>();
//			var values = (TEnumType[])Enum.GetValues(type);
//			foreach (var value in values)
//			{
//				var attributes = (value as Enum).GetEnumAttribute<DescriptionAttribute>("Description").Select(element => element.ToString());
//				foreach (var attribute in attributes)
//				{
//					result.Add(attribute);
//				}
//			}
//			return result;
//		}
//	}
//}
