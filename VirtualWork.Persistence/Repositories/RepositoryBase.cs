using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using VirtualWork.Interfaces;
using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Helper;

namespace VirtualWork.Persistence.Repositories
{
	public abstract class RepositoryBase<TDtoType, TEntityType> : EntityProvider<TEntityType>
		where TDtoType : class, IHaveIdentifier
		where TEntityType : class, IHaveIdentifier
	{
        protected VirtualWorkDatabaseContext VirtualWorkDatabase;
		protected IConverter<TDtoType, TEntityType> Converter;
		protected DbSet<TEntityType> DatabaseTable;

		public RepositoryBase(VirtualWorkDatabaseContext mtfDatabase,
			IConverter<TDtoType, TEntityType> converter,
			DbSet<TEntityType> databaseTable) : base()
        {
            VirtualWorkDatabase = mtfDatabase;
			Converter = converter;
			DatabaseTable = databaseTable;
		}

		public TDtoType Add(TDtoType dto)
		{
			var entity = Converter.ToEntity(dto);
			var addedEntity = DatabaseTable.Add(entity);
			VirtualWorkDatabase.SaveChanges();
			return Converter.ToDto(addedEntity);
		}

		protected virtual Expression<Func<TEntityType, bool>> EntitySearchPredicate(object value)
		{
			return dbEntity => dbEntity.Id == (int)value;
		}

		public TDtoType AddOrUpdate(TDtoType dto)
		{
			var expression = EntitySearchPredicate(dto.Id);
			var entity = Get(expression.Compile());
			if (entity == null)
			{
				return Add(dto);
			}
			else
			{
				return Update(dto);
			}
		}

		public bool HasAny()
		{
			return DatabaseTable.AsNoTracking().Any();
		}

		public TDtoType Get(int? id)
		{
			if (id.HasValue)
			{
				return Get(id.Value);
			}

			return null;
		}

		public TDtoType Get(int id)
		{
			var result = GetEntity(id, DatabaseTable);
			return Converter.ToDto(result);
		}

		public TDtoType Get(Func<TEntityType, bool> predicate)
		{
			var result = DatabaseTable.AsNoTracking().FirstOrDefault(predicate);
			return Converter.ToDto(result);
		}

		public IEnumerable<TDtoType> GetMany(Func<TEntityType, bool> predicate)
		{
			return DatabaseTable.AsNoTracking().Where(predicate).Select(Converter.ToDto);
		}

		public IEnumerable<TDtoType> GetMatchings(string pattern, Func<TEntityType, bool> predicate)
		{
			return String.IsNullOrEmpty(pattern) ? GetAll() : GetAll(predicate);
		}

		public IEnumerable<TDtoType> GetAll()
		{
			return GetAll((_) => { return true; });
		}

		public IEnumerable<TDtoType> GetAll(Func<TEntityType, bool> predicate)
		{
			if (predicate == null)
			{
				return GetAll();
			}
			var entities = DatabaseTable.AsNoTracking().Where(predicate);
			return entities.Select(entity => Converter.ToDto(entity));
		}

		public TDtoType GetSingle(Func<TEntityType, bool> predicate)
		{
			var result = DatabaseTable.AsNoTracking().SingleOrDefault(predicate);
			return Converter.ToDto(result);
		}

		public TDtoType Update(TDtoType dto)
		{
			var updatedEntity = Converter.ToEntity(dto);
			VirtualWorkDatabase.SaveChanges();
			return Converter.ToDto(updatedEntity);
		}

		public void Remove(int id)
		{
			var entity = DatabaseTable.Find(id);
			Remove(entity);
		}

		public void Remove(Func<TEntityType, bool> predicate)
		{
			var entity = DatabaseTable.SingleOrDefault(predicate);
			Remove(entity);
		}

		public void Remove(TEntityType entity)
		{
			if (entity != null)
			{
				DatabaseTable.Remove(entity);
				VirtualWorkDatabase.SaveChanges();
			}
		}
	}
}
