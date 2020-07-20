using System.Linq;
using VirtualWork.Persistence.Repositories;
using VirtualWork.Service.Cryptography;
using DtoType = VirtualWork.Core.Infrastructure.Server;
using EntityType = VirtualWork.Persistence.Entities.Server;

namespace VirtualWork.Persistence.Converters
{
	public class ServerConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly CameraConverter cameraConverter;
		private readonly CaesarCypher caesarCypher;
		private readonly RotateCypher rotateCypher;
		private readonly XorCypher xorCypher;

		public ServerConverter(EntityProvider<EntityType> entityProvider,
			CameraConverter cameraConverter,
			CaesarCypher caesarCypher,
			RotateCypher rotateCypher,
			XorCypher xorCypher,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, virtualWorkDatabaseContext)
		{
			this.cameraConverter = cameraConverter;
			this.caesarCypher = caesarCypher;
			this.rotateCypher = rotateCypher;
			this.xorCypher = xorCypher;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.Cameras = dto.Cameras?.Select(cameraConverter.ToEntity).ToList();
			entity.Username = xorCypher.Encrypt(rotateCypher.Encrypt(caesarCypher.Encrypt(dto.Username, 9), 4), "f[6/95*e2jDeTgb");
			entity.Password = xorCypher.Encrypt(rotateCypher.Encrypt(caesarCypher.Encrypt(dto.Password, 5), 15), "j7$dE4.tRd3X#");
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Cameras = entity.Cameras?.Select(cameraConverter.ToDto).ToList();
			//dto.Cameras = cameraRepository.GetMany(camera => camera.ServerId == entity.Id);
			dto.Username = caesarCypher.Encrypt(rotateCypher.Encrypt(xorCypher.Encrypt(entity.Username, "f[6/95*e2jDeTgb"), -4), -9);
			dto.Password = caesarCypher.Encrypt(rotateCypher.Encrypt(xorCypher.Encrypt(entity.Password, "j7$dE4.tRd3X#"), -15), -5);
		}
	}
}
