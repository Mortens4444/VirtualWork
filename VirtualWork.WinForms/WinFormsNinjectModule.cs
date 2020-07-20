using Ninject.Modules;
using VirtualWork.WinForms.Providers;

namespace VirtualWork.WinForms
{
	class WinFormsNinjectModule : NinjectModule
	{
		public override void Load()
		{
			Bind<ActualUserGroupsProvider>().ToSelf().InSingletonScope();
		}
	}
}
