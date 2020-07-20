using System.Collections.Generic;
using VirtualWork.Core.Security;

namespace VirtualWork.WinForms.Providers
{
	public class ActualUserGroupsProvider
	{
		private IList<Group> actualUserGroups;

		public IList<Group> Get()
		{
			return actualUserGroups;
		}

		public void Set(IList<Group> groups)
		{
			actualUserGroups = groups;
		}
	}
}
