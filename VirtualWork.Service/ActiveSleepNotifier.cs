using System;
using System.Threading;
using System.Threading.Tasks;
using VirtualWork.Interfaces;

namespace VirtualWork.Service
{
	public class ActiveSleepNotifier : INotifier
	{
		public async void NotifyAt(DateTime targetDateTime, Action action, CancellationToken cancellationToken)
		{
			await Task.Factory.StartNew(() =>
			{
				while (DateTime.Now < targetDateTime && !cancellationToken.IsCancellationRequested)
				{
					Thread.Sleep(100);
				}
				if (!cancellationToken.IsCancellationRequested)
				{
					action();
				}
			}, cancellationToken);
		}
	}
}
