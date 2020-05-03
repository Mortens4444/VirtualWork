
using System;
using System.Collections.Generic;

namespace VirtualWork.Core.Production
{
	public class Invoice
	{
		public int Id { get; set; }

		public DateTime CreationDate { get; set; }

		public DateTime DueDate { get; set; }

		public IEnumerable<Product> Products { get; set; }

		public int UserId { get; set; }
	}
}