using System;
using VirtualWork.Interfaces.Actors;

namespace VirtualWork.Interfaces.Log
{
	public interface ILogger
	{
		void Info(string logInfo, IUser user = null);

		void Warning(string logInfo, IUser user = null);

		void Error(string logInfo, IUser user = null);

		void Error(Exception exception, IUser user = null);

		void Debug(string logInfo, IUser user = null);
	}
}
