using System.ComponentModel;

namespace VirtualWork.Interfaces.Enums
{
	public enum ResourceType
	{
		[Description("Car")]
		Car,

		[Description("Desktop computer")]
		DesktopComputer,

		[Description("Laptop")]
		Laptop,

		[Description("Software license")]
		SoftwareLicense,

		[Description("Mobile phone")]
		MobilePhone,

		[Description("Display")]
		Display,

		[Description("Keyboard")]
		Keyboard,

		[Description("Mouse")]
		Mouse,

		[Description("Other")]
		Other
	}
}
