using System.Linq;

namespace VirtualWork.Core.Utils
{
	public static class TypeUtils
	{
		public static bool IsImplementingInterface<TTestType, TInterfaceType>()
		{
			return typeof(TTestType).GetInterfaces().Contains(typeof(TInterfaceType));
		}
	}
}
