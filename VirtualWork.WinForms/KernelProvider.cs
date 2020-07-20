using Ninject;
using VirtualWork.Persistence;
using VirtualWork.Service;

namespace VirtualWork.WinForms
{
	class KernelProvider
	{
		private static readonly IKernel kernel;

		static KernelProvider()
		{
			kernel = new StandardKernel();
			kernel.Load(
				new ServiceInjectionModule(),
				new PersistenceInjectionModule(),
				new WinFormsNinjectModule()
			);
		}

		public static IKernel Get()
		{
			return kernel;
		}
	}
}
