using System.Data.Entity;
using VirtualWork.Interfaces;

namespace VirtualWork.Persistence.Repositories
{
	public class EntityProvider<TEntityType>
		where TEntityType : class, IHaveIdentifier
	{
		protected readonly DbSet<TEntityType> DatabaseTable;

		public EntityProvider(DbSet<TEntityType> databaseTable)
		{
			DatabaseTable = databaseTable;
		}

		public TEntityType GetEntity(int? id)
		{
			if (!id.HasValue)
			{
				return null;
			}

			return GetEntity(id.Value);
		}

		public TEntityType GetEntity(int id)
		{
			return DatabaseTable.Find(id);
		}
	}
}
