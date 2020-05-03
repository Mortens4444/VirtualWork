using System.Collections.Generic;

namespace VirtualWork.Core.Actors
{
	public class Store : Actor
	{
		public IEnumerable<User> Workers { get; set; }
	}
}