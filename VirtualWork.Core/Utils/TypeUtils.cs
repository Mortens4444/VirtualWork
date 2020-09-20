using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace VirtualWork.Core.Utils
{
	public static class TypeUtils
	{
		public static bool IsImplementingInterface<TTestType, TInterfaceType>()
		{
			return typeof(TTestType).GetInterfaces().Contains(typeof(TInterfaceType));
		}

		public static IEnumerable<Type> GetClassesInNamespace(Assembly assembly, string @namespace)
		{
			return assembly.GetTypes().Where(type => !type.IsInterface && String.Equals(type.Namespace, @namespace, StringComparison.Ordinal));
		}

		public static MethodInfo GetFirstGenericFunctionWithNameAndOneTypeParameter(this Type type, string functionName)
		{
			return type.GetMethods().First(method => method.Name == functionName && method.GetGenericArguments().Length == 1);
		}
		
	}
}
