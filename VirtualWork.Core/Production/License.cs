using System;
using VirtualWork.Core.Actors;
using VirtualWork.Interfaces;

namespace VirtualWork.Core.Production
{
	public class License : IHaveIdentifier
	{
		public int Id { get; set; }

		public string Code { get; set; }

		public string Description { get; set; }

		public string Name { get; set; }

		public DateTime OrderDate { get; set; }

		public DateTime? RenewalDate { get; set; }

		public User User { get; set; }
	}
}