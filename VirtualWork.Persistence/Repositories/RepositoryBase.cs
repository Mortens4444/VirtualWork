using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using VirtualWork.Core.Utils;
using VirtualWork.Interfaces;
using VirtualWork.Persistence.Converters;

namespace VirtualWork.Persistence.Repositories
{
	public class RepositoryBase<TDtoType, TEntityType> : EntityProvider<TEntityType>
		where TDtoType : class, IHaveIdentifier, new()
		where TEntityType : class, IHaveIdentifier, new()
	{
        protected VirtualWorkDatabaseContext VirtualWorkDatabase;
		protected IConverter<TDtoType, TEntityType> Converter;

		public RepositoryBase(VirtualWorkDatabaseContext mtfDatabase,
			ConverterBase<TDtoType, TEntityType> converter,
			DbSet<TEntityType> databaseTable) : base(databaseTable)
        {
            VirtualWorkDatabase = mtfDatabase;
			Converter = converter;
		}

		public TDtoType Add(TDtoType dto)
		{
			var entity = Converter.ToEntity(dto);
			var addedEntity = DatabaseTable.Add(entity);
			VirtualWorkDatabase.SaveChanges();
			return Converter.ToDto(addedEntity);
		}

		protected virtual Expression<Func<TEntityType, bool>> EntitySearchPredicate(TDtoType dto)
		{
			return dbEntity => dbEntity.Id == dto.Id;
		}

		protected virtual Expression<Func<TEntityType, bool>> EntitySearchPredicate(IHaveActorOwner dto)
		{
			return dbEntity => ((IEntityHaveActorOwner)dbEntity).ActorId == dto.ActorId && ((IEntityHaveActorOwner)dbEntity).ActorType == (int)dto.ActorType;
		}

		protected virtual Expression<Func<TEntityType, bool>> EntitySearchPredicate(IHaveEntityOwner dto)
		{
			return dbEntity => ((IEntityHaveEntityOwner)dbEntity).EntityId == dto.EntityId && ((IEntityHaveEntityOwner)dbEntity).EntityType == (int)dto.EntityType;
		}

		public TDtoType AddOrUpdate(TDtoType dto)
		{
			var expression = EntitySearchPredicate(dto);
			var entity = Get(expression.Compile());
			if (entity == null)
			{
				return Add(dto);
			}
			else
			{
				dto.Id = entity.Id;
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
			var result = GetEntity(id);
			return Converter.ToDto(result);
		}

		public TDtoType Get(Func<TEntityType, bool> predicate)
		{
			var result = DatabaseTable.AsNoTracking().FirstOrDefault(predicate);
			return Converter.ToDto(result);
		}

		public IEnumerable<TDtoType> GetMany(Func<TEntityType, bool> predicate)
		{
			var entities = DatabaseTable.AsNoTracking().Where(predicate);

			if (TypeUtils.IsImplementingInterface<TEntityType, IHaveName>())
			{
				var orderableEntities = entities.Cast<IHaveName>();
				return orderableEntities.OrderBy(orderableEntity => orderableEntity.Name)
					.Cast<TEntityType>()
					.Select(Converter.ToDto);
			}
			else if (TypeUtils.IsImplementingInterface<TEntityType, IHaveTitle>())
			{
				var orderableEntities = entities.Cast<IHaveTitle>();
				return orderableEntities.OrderBy(orderableEntity => orderableEntity.Title)
					.Cast<TEntityType>()
					.Select(Converter.ToDto);
			}
			else if (TypeUtils.IsImplementingInterface<TEntityType, IResource>())
			{
				var orderableEntities = entities.Cast<IResource>();
				return orderableEntities.OrderBy(orderableEntity => orderableEntity.ResourceType)
					.ThenBy(orderableEntity => orderableEntity.Key)
					.Cast<TEntityType>()
					.Select(Converter.ToDto);
			}
			return entities.Select(Converter.ToDto);
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
			return GetMany(predicate);
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
