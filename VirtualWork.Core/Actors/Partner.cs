using System.Collections.Generic;
using System.Linq;
using VirtualWork.Core.Security;

namespace VirtualWork.Core.Actors
{
	public class Partner : Actor
	{
		public string FullName { get; set; }

		public override string ToString()
		{
			return FullName ?? Name;
		}
	}
}