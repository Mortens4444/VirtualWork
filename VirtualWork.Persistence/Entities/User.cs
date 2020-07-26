using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VirtualWork.Persistence.Entities
{
	public class User : Actor
	{
		public User()
		{
			Groups = new List<Group>();
		}

		[StringLength(PersistenceConstants.MaxLengthOfPasswordHash)]
		public string PasswordHash { get; set; }

		public virtual ICollection<Issue> FollowedIssues { get; set; }

		public virtual ICollection<IssueHistory> IssueHistoryEntries { get; set; }

		public virtual ICollection<Group> Groups { get; set; }

		public virtual ICollection<UserSetting> UserSettings { get; set; }
    }
}
