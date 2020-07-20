namespace VirtualWork.Persistence.Converters
{
	public interface IConverter<TDtoType, TEntityType>
	{
		TEntityType ToEntity(TDtoType dto);

		TDtoType ToDto(TEntityType entity);
	}
}
