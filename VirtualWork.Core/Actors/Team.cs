using System.Collections.Generic;

namespace VirtualWork.Core.Actors
{
	public class Team : Actor
	{
		public IEnumerable<User> Workers { get; set; }
	}
}