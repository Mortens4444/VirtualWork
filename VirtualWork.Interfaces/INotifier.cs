using System;
using System.Threading;

namespace VirtualWork.Interfaces
{
	public interface INotifier
	{
		void NotifyAt(DateTime targetDateTime, Action action, CancellationToken cancellationToken);
	}
}
