using System.Data.Entity;
using VirtualWork.Interfaces;

namespace VirtualWork.Persistence.Repositories
{
	public class EntityProvider<TEntityType>
		where TEntityType : class, IHaveIdentifier
	{
		public TEntityType GetEntity(int? id, DbSet<TEntityType> databaseTable)
		{
			if (!id.HasValue)
			{
				return null;
			}

			return GetEntity(id.Value, databaseTable);
		}

		public TEntityType GetEntity(int id, DbSet<TEntityType> databaseTable)
		{
			return databaseTable.Find(id);
		}
	}
}
