using System.Linq;
using VirtualWork.Core.Cryptography;
using VirtualWork.Core.Cryptography.Ciphers.Production;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Infrastructure.Server;
using EntityType = VirtualWork.Persistence.Entities.Server;

namespace VirtualWork.Persistence.Converters
{
	public class ServerConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly CameraConverter cameraConverter;
		private readonly ProductionCipher productionCipher;

		private readonly ProductionCipherKey userEncryptorKey;
		private readonly ProductionCipherKey passwordEncryptorKey;

		public ServerConverter(EntityProvider<EntityType> entityProvider,
			CameraConverter cameraConverter,
			ProductionCipher productionCipher,
			UserRepository userRepository,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, virtualWorkDatabaseContext)
		{
			this.cameraConverter = cameraConverter;
			this.productionCipher = productionCipher;

			userEncryptorKey = userRepository.GetSystemEncryptionPassword("f[6/95*e2jDeTgb");
			passwordEncryptorKey = userRepository.GetSystemEncryptionPassword("j7$dE4.tRd3X#");
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.Cameras = dto.Cameras?.Select(cameraConverter.ToEntity).ToList();
			entity.Username = productionCipher.Encrypt(dto.Username, userEncryptorKey);
			entity.Password = productionCipher.Encrypt(dto.Password, passwordEncryptorKey);
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Cameras = entity.Cameras?.Select(cameraConverter.ToDto).ToList();
			//dto.Cameras = cameraRepository.GetMany(camera => camera.ServerId == entity.Id);
			dto.Username = productionCipher.Decrypt(entity.Username, userEncryptorKey);
			dto.Password = productionCipher.Decrypt(entity.Password, passwordEncryptorKey);
		}
	}
}
