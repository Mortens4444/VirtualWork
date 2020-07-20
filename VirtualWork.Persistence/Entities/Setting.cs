using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;

namespace VirtualWork.Persistence.Entities
{
    public abstract class Setting : IHaveIdentifier
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfStrings)]
		public string Name { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfStrings)]
		public string Value { get; set; }

		public override string ToString()
        {
            return $"{Name} = {Value}";
        }
    }
}
