using System.Collections.Generic;
using VirtualWork.Interfaces;

namespace VirtualWork.Core.Security
{
	public class Group : IHaveIdentifier, IHaveName
	{
		public int Id { get; set; }

		public string Description { get; set; }

		public string Name { get; set; }

		public bool IsActive { get; set; }

		public IList<Permission> Permissions { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}