using System.Collections.Generic;
using System.Drawing;

namespace VirtualWork.Core.Production
{
	public class Product
	{
		public int Id { get; set; }

		public string Code { get; set; }

		public string Description { get; set; }

		//public IEnumerable<Image> Images { get; set; }

		public string Name { get; set; }

		public decimal NetPrice { get; set; }

		public int Quantity { get; set; }

		public decimal VatKey { get; set; }
	}
}