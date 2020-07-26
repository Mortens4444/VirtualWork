using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Core.Extensions;
using VirtualWork.Interfaces;

namespace VirtualWork.Persistence.Entities
{
	public class Actor : IHaveIdentifier, IHaveName
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(PersistenceConstants.MaxLengthOfStrings)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

		[StringLength(PersistenceConstants.MaxLengthMediumOfStrings)]
		public string FullName { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfLongStrings)]
		public string OtherInformation { get; set; }

		public bool IsActive { get; set; }

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
