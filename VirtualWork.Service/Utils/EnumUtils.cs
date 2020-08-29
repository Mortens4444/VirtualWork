using System;
using LanguageService;

namespace VirtualWork.Service.Utils
{
	public class EnumUtils
	{
		public static TEnumType GetByDescription<TEnumType>(string description)
		{
			var englishDescription = Lng.Translate(Lng.DefaultLanguage, description, Language.English);
			var values = Enum.GetValues(typeof(TEnumType));
			foreach (TEnumType value in values)
			{
				if (englishDescription == Core.Utils.EnumUtils.GetDescription(value as Enum))
				{
					return value;
				}
			}

			return Parse<TEnumType>(englishDescription);
		}

		public static TEnumType Parse<TEnumType>(string value)
		{
			return (TEnumType)Enum.Parse(typeof(TEnumType), value);
		}
	}
}
