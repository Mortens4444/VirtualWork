using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using VirtualWork.Core.Extensions;
using VirtualWork.Core.Security;
using VirtualWork.Interfaces.Actors;

namespace VirtualWork.Core.Actors
{
	public class User : Actor, IUser
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

		public bool IsInRole(string role)
		{
			if (String.IsNullOrEmpty(role))
			{
				return true;
			}
			return Thread.CurrentPrincipal.IsInRole(role);
		}

		public bool IsMatchingPattern(string pattern)
		{
			return Name.ContainsIgnoreCase(pattern) || FullName.ContainsIgnoreCase(pattern);
		}
	}
}