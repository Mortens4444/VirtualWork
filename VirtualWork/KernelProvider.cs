using Ninject;
using VirtualWork.Persistence;
using VirtualWork.Service;

namespace VirtualWork
{
	class KernelProvider
	{
		private static readonly IKernel kernel;

		static KernelProvider()
		{
			kernel = new StandardKernel();
			kernel.Load(
				new ServiceInjectionModule(),
				new PersistenceInjectionModule()
			);
		}

		public static IKernel Get()
		{
			return kernel;
		}
	}
}
