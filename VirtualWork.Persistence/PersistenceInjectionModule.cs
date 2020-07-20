using Ninject.Modules;

namespace VirtualWork.Persistence
{
	public class PersistenceInjectionModule : NinjectModule
	{
		public override void Load()
		{
			Bind<VirtualWorkDatabaseContext>().ToSelf().InSingletonScope();
		}
	}
}
