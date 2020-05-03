using System.Windows;
using Ninject;
using VirtualWork.Core.Exceptions;
using VirtualWork.Persistence;
using VirtualWork.Service;

namespace VirtualWork
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private static readonly IKernel kernel = GetKernel();
		private static readonly ExceptionCatcher exceptionCatcher = kernel.Get<ExceptionCatcher>();

		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			Current.MainWindow = kernel.Get<MainWindow>();
			Current.MainWindow.Show();
		}

		private static IKernel GetKernel()
		{
			var result = new StandardKernel();
			result.Load(
				new ServiceInjectionModule(),
				new PersistenceInjectionModule()
			);
			return result;
		}
	}
}
