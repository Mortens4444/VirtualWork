using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;

namespace VirtualWork.Persistence.Entities
{
    public class Permission : IHaveIdentifier
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(PersistenceConstants.MaxLengthOfStrings)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

		public string Description { get; set; }

		public virtual ICollection<Group> Groups { get; set; }

		public override string ToString()
        {
            return Name;
        }
    }
}
