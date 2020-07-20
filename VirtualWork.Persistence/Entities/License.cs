﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;

namespace VirtualWork.Persistence.Entities
{
	public class License : IHaveIdentifier
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey(nameof(User))]
		[Required]
		public int UserId { get; set; }
		public virtual User User { get; set; }

		public string Code { get; set; }

		public string Description { get; set; }

		public string Name { get; set; }

		public DateTime OrderDate { get; set; }

		public DateTime? RenewalDate { get; set; }
	}
}
