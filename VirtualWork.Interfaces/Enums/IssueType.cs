using VirtualWork.Interfaces.Attributes;

namespace VirtualWork.Interfaces.Enums
{
	public enum IssueType
	{
		[TitleBarColoring(225, 90)]
		[BackgroundColoring(255, 127, 39)]
		[FontColoring()]
		Epic,

		[TitleBarColoring(255, 242)]
		[BackgroundColoring(255, 245, 70)]
		[FontColoring()]
		Story,

		[TitleBarColoring(0, 162, 232)]
		[BackgroundColoring(153, 217, 234)]
		[FontColoring()]
		Task,

		[TitleBarColoring(34, 177, 76)]
		[BackgroundColoring(79, 221, 121)]
		[FontColoring()]
		Test,

		[TitleBarColoring(128)]
		[BackgroundColoring(237, 28, 36)]
		[FontColoring(255, 255, 255)]
		Bug
	}
}