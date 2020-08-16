namespace VirtualWork.Core.Extensions
{
	public class IntExtensions
	{
		public static void Swap(ref int a, ref int b)
		{
			a ^= b;
			b ^= a;
			a ^= b;
		}
	}
}
