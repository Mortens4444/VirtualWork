using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Actors;

namespace VirtualWork.Persistence.Entities
{
	public class Meeting : Repeatable, IHaveIdentifier
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey(nameof(Owner))]
		[Required]
		public int OwnerId { get; set; }
		public virtual User Owner { get; set; }

		public string Description { get; set; }

		public string Title { get; set; }

		public DateTime CreationDate { get; set; }

		public DateTime MeetingDate { get; set; }

		public HashSet<INotifiable> Followers { get; set; }
	}
}
