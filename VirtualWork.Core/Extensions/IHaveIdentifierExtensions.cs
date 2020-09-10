using System;
using VirtualWork.Core.Actors;
using VirtualWork.Core.Infrastructure;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Core.Extensions
{
	public static class IHaveIdentifierExtensions
	{
		public static EntityType GetEntityType(this IHaveIdentifier haveIdentifier)
		{
			if (haveIdentifier is Resource)
			{
				return EntityType.Resource;
			}
			if (haveIdentifier is User)
			{
				return EntityType.User;
			}
			throw new NotImplementedException();
		}
	}
}
