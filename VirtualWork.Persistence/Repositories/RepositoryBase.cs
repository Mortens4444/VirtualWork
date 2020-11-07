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
			var entity = Get(expression);
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

		public TDtoType Get(Expression<Func<TEntityType, bool>> predicate)
		{
			var result = DatabaseTable.AsNoTracking().FirstOrDefault(predicate);
			return Converter.ToDto(result);
		}

		private IEnumerable<TDtoType> Order(IEnumerable<TDtoType> elements)
		{
			if (TypeUtils.IsImplementingInterface<TDtoType, IHaveName>())
			{
				var orderableElements = elements.Cast<IHaveName>();
				return orderableElements.OrderBy(orderableElement => orderableElement.Name)
					.Cast<TDtoType>();
			}
			else if (TypeUtils.IsImplementingInterface<TDtoType, IHaveTitle>())
			{
				var orderableElements = elements.Cast<IHaveTitle>();
				return orderableElements.OrderBy(orderableElement => orderableElement.Title)
					.Cast<TDtoType>();
			}
			else if (TypeUtils.IsImplementingInterface<TDtoType, IResource>())
			{
				var orderableElements = elements.Cast<IResource>();
				return orderableElements.OrderBy(orderableElement => orderableElement.ResourceType)
					.ThenBy(orderableElement => orderableElement.Key)
					.Cast<TDtoType>();
			}

			return elements;
		}

		private IEnumerable<TDtoType> Convert(IQueryable<TEntityType> entities)
		{
			var elements = entities.Select(Converter.ToDto);
			return Order(elements);
		}

		public IEnumerable<TDtoType> GetMany(Expression<Func<TEntityType, bool>> predicate)
		{
			var entities = DatabaseTable.AsNoTracking().Where(predicate);
			return Convert(entities);
		}

		public IEnumerable<TDtoType> GetAll()
		{
			var entities = DatabaseTable.AsNoTracking();
			return Convert(entities);
		}

		public IEnumerable<TDtoType> GetAll(Expression<Func<TEntityType, bool>> predicate)
		{
			if (predicate == null)
			{
				return GetAll();
			}
			return GetMany(predicate);
		}

		public TDtoType GetSingle(Expression<Func<TEntityType, bool>> predicate)
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

		public void Remove(Expression<Func<TEntityType, bool>> predicate)
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
