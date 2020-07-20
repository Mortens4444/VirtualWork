using System.Collections.Generic;
using System.Linq;
using VirtualWork.Core.Security;

namespace VirtualWork.Core.Actors
{
	public class User : Actor
	{
		public bool IsActive { get; set; }

		public string PasswordHash { get; set; }

		public string FullName { get; set; }

		public Group Group
		{
			set
			{
				Groups = new[] { value };
			}
		}

		public IList<Group> Groups { get; set; }

		public bool IsAdmin()
		{
			return Groups.Any(group => group.Id == 1);
		}

		public override string ToString()
		{
			return FullName ?? Name;
		}
	}
}