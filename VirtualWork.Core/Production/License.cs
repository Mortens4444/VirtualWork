using System;
using VirtualWork.Core.Actors;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Enums;

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

		public Actor Actor { get; set; }

		public ActorType ActorType { get; set; }
	}
}