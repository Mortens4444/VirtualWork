using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Core.Extensions;
using VirtualWork.Interfaces;

namespace VirtualWork.Persistence.Entities
{
    public class User : IHaveIdentifier, IHaveName
	{
		public User()
		{
			Groups = new List<Group>();
		}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(PersistenceConstants.MaxLengthOfStrings)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfPasswordHash)]
		public string PasswordHash { get; set; }

		[StringLength(PersistenceConstants.MaxLengthMediumOfStrings)]
		public string FullName { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfLongStrings)]
		public string OtherInformation { get; set; }

		public bool IsActive { get; set; }

		public virtual ICollection<Comment> Comments { get; set; }

		public virtual ICollection<Address> Addresses { get; set; }

		public virtual ICollection<TelephoneNumber> TelephoneNumbers { get; set; }

		public virtual ICollection<Email> Emails { get; set; }

		public virtual ICollection<License> Licenses { get; set; }

		public virtual ICollection<Issue> FollowedIssues { get; set; }

		public virtual ICollection<IssueHistory> IssueHistoryEntries { get; set; }

		public virtual ICollection<UserImage> UserImages { get; set; }

		public virtual ICollection<Group> Groups { get; set; }

		public virtual ICollection<UserSetting> UserSettings { get; set; }

		public bool IsMatchingPattern(string pattern)
		{
			return Name.ContainsIgnoreCase(pattern) || FullName.ContainsIgnoreCase(pattern);
		}

		public override string ToString()
        {
            return Name;
        }
    }
}
