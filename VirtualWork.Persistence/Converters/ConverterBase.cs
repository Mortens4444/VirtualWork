using System.Data.Entity;
using System.Linq;
using VirtualWork.Interfaces;
using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork.Persistence.Converters
{
	public abstract class ConverterBase<TDtoType, TEntityType> : IConverter<TDtoType, TEntityType>
		where TDtoType : class, IHaveIdentifier, new()
		where TEntityType : class, IHaveIdentifier, new()
	{
		protected readonly VirtualWorkDatabaseContext VirtualWorkDatabaseContext;
		protected readonly EntityProvider<TEntityType> entityProvider;
		protected readonly DbSet<TEntityType> dataTable;

		public ConverterBase(EntityProvider<TEntityType> entityProvider,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
		{
			this.entityProvider = entityProvider;
			VirtualWorkDatabaseContext = virtualWorkDatabaseContext;

			var tables = virtualWorkDatabaseContext.GetType().GetProperties();
			var tableInfo = tables.Single(table => table.PropertyType == typeof(DbSet<TEntityType>));
			dataTable = tableInfo.GetValue(virtualWorkDatabaseContext) as DbSet<TEntityType>;
		}

		public virtual TDtoType ToDto(TEntityType entity)
		{
			if (entity == null)
			{
				return null;
			}

			var result = new TDtoType();
			PropertyCopier.CopyProperties(entity, result);
			CopyTypeMismatchingEntityParameters(entity, result);
			return result;
		}

		protected virtual void CopyTypeMismatchingEntityParameters(TEntityType entity, TDtoType dto)
		{
		}

		public virtual TEntityType ToEntity(TDtoType dto)
		{
			if (dto == null)
			{
				return null;
			}

			var result = entityProvider.GetEntity(dto.Id, dataTable) ?? new TEntityType();
			PropertyCopier.CopyProperties(dto, result);
			CopyTypeMismatchingDtoParameters(dto, result);
			return result;
		}

		protected virtual void CopyTypeMismatchingDtoParameters(TDtoType dto, TEntityType entity)
		{
		}
	}
}
