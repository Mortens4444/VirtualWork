using System.Windows;
using Ninject;
using VirtualWork.Core.Exceptions;

namespace VirtualWork
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private static readonly IKernel kernel = KernelProvider.Get();
		private static readonly ExceptionCatcher exceptionCatcher = kernel.Get<ExceptionCatcher>();

		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			//Current.MainWindow = kernel.Get<LoginWindow>();
			//Current.MainWindow.Show();

			Current.MainWindow = kernel.Get<MainWindow>();
			Current.MainWindow.Show();
		}

	}
}
