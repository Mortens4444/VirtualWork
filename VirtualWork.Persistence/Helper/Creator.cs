using System;
using MessageBoxes;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Windows;
using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using ExceptionDetails = VirtualWork.Core.Exceptions.ExceptionDetails;

namespace VirtualWork.WinForms
{
	public abstract class Creator<TDtoType, TEntityType>
		where TDtoType : class, IHaveIdentifier
		where TEntityType : class, IHaveIdentifier
	{
		private readonly IWindow window;

		protected readonly RepositoryBase<TDtoType, TEntityType> repository;
		protected abstract string ConnectionSuccessfulInfoTitle { get; }
		protected abstract string ConnectionSuccessfulInfoMessage { get; }
		protected abstract string CreateInfoTitle { get; }
		protected abstract string CreateInfoMessage { get; }
		protected abstract string CreationErrorTitle { get; }
		protected abstract string CreationErrorMessage { get; }

		public Creator(RepositoryBase<TDtoType, TEntityType> repository, IWindow window)
		{
			this.repository = repository;
			this.window = window;
		}

		public bool CheckExistence(NotificationSettings notificationSettings = NotificationSettings.ShowMessages)
		{
			try
			{
				if (repository.HasAny())
				{
					if (notificationSettings == NotificationSettings.ShowMessages)
					{
						InfoBox.Show(ConnectionSuccessfulInfoTitle, ConnectionSuccessfulInfoMessage);
					}
				}
				else
				{
					do
					{
#if DEBUG
						CreateDefaultEntity();
#else
						InfoBox.Show(CreateInfoTitle, CreateInfoMessage);
						window.ShowDialog();
#endif
					}
					while (!repository.HasAny());
				}
				return true;
			}
			catch (Exception ex)
			{
				var details = new ExceptionDetails(ex).Details;
				ErrorBox.Show(CreationErrorTitle, String.Concat(CreationErrorMessage, Environment.NewLine, details));
			}
			return false;
		}

		protected abstract void CreateDefaultEntity();
	}
}
