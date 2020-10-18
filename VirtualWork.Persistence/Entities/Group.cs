using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;

namespace VirtualWork.Persistence.Entities
{
    public class Group : IHaveIdentifier, IHaveName
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(PersistenceConstants.MaxLengthOfStrings)]
        [Index(IsUnique = true)]
		[Required]
		public string Name { get; set; }

		public string Description { get; set; }

		public bool IsActive { get; set; }

		public virtual ICollection<Permission> Permissions { get; set; }

		public virtual ICollection<User> Users { get; set; }

		public override string ToString()
        {
            return Name;
        }
    }
}
