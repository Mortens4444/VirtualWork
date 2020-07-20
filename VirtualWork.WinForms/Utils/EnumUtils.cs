using System;
using LanguageService;

namespace VirtualWork.WinForms.Utils
{
	class EnumUtils
	{
		public static TEnumType Get<TEnumType>(string text)
		{
			return (TEnumType)Enum.Parse(typeof(TEnumType), Lng.Translate(Lng.DefaultLanguage, text, Language.English));
		}
	}
}
