﻿using VirtualWork.Core.Extensions;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Appointment.Meeting;
using EntityType = VirtualWork.Persistence.Entities.Meeting;

namespace VirtualWork.Persistence.Converters
{
	public class MeetingConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly UserRepository userRepository;

		public MeetingConverter(EntityProvider<EntityType> entityProvider,
			UserRepository userRepository,
			PropertyCopier propertyCopier,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, propertyCopier, virtualWorkDatabaseContext)
		{
			this.userRepository = userRepository;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.OwnerId = dto.Owner.Id;
			entity.RepetitionType = (int)dto.RepetitionType;

			entity.CreationDate = dto.CreationDate.GetRepositoryDateTimeFormat();
			entity.MeetingDate = dto.MeetingDate.GetRepositoryDateTimeFormat();
			entity.ExpirationDate = dto.ExpirationDate?.GetRepositoryDateTimeFormat();
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Owner = userRepository.Get(entity.OwnerId);
			dto.RepetitionType = (RepetitionType)entity.RepetitionType;

			dto.CreationDate = entity.CreationDate.GetViewDateTimeFormat();
			dto.MeetingDate = entity.MeetingDate.GetViewDateTimeFormat();
			dto.ExpirationDate = entity.ExpirationDate?.GetViewDateTimeFormat();
		}
	}
}
