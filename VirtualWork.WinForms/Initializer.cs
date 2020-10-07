using System;
using System.Configuration;
using System.Windows.Forms;
using LanguageService;
using MessageBoxes;
using VirtualWork.Core.Actors;
using VirtualWork.Persistence;
using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Creators;

namespace VirtualWork.WinForms
{
	public class Initializer
	{
		private readonly AdminGroupCreator adminGroupCreator;
		private readonly AdminUserCreator adminUserCreator;
		private readonly DatabaseSettingsForm databaseSettingsForm;
		private readonly UserRepository userRepository;
		private readonly PermissionHandler permissionHandler;
		private readonly LoginForm loginForm;
		private readonly MainForm mainForm;
		public static User LoggedInUser;

		public Initializer(DatabaseSettingsForm databaseSettingsForm,
			AdminGroupCreator adminGroupCreator,
			AdminUserCreator adminUserCreator,
			UserRepository userRepository,
			PermissionHandler permissionHandler,
			LoginForm loginForm,
			MainForm mainForm)
		{
			this.adminGroupCreator = adminGroupCreator;
			this.adminUserCreator = adminUserCreator;
			this.databaseSettingsForm = databaseSettingsForm;
			this.userRepository = userRepository;
			this.permissionHandler = permissionHandler;
			this.loginForm = loginForm;
			this.mainForm = mainForm;
		}

		public void CreateDefaultInstancesAndLogin()
		{
			var connectionString = ConfigurationManager.ConnectionStrings[PersistenceConstants.VirtualWorkDbConnectionString].ConnectionString;
			if (String.IsNullOrEmpty(connectionString))
			{
				if (databaseSettingsForm.ShowDialog() == DialogResult.OK)
				{
					ShowLogin();
				}
			}
			else
			{
				if (adminGroupCreator.CheckExistence(NotificationSettings.HideMessages))
				{
					if (adminUserCreator.CheckExistence(NotificationSettings.HideMessages))
					{
#if DEBUG
						Login(userRepository.Get("Admin"));
#else
						ShowLogin();
#endif
					}
				}
			}
		}

		private void ShowLogin()
		{
			if (loginForm.ShowDialog() == DialogResult.OK)
			{
				Login(loginForm.LoggedInUser);
			}
			else
			{
				ErrorBox.Show(Lng.Elem("Credentials error"), Lng.Elem("Wrong user name or password"));
			}
		}

		private void Login(User user)
		{
			LoggedInUser = user;
			permissionHandler.SetPrincipals(LoggedInUser);
			Application.Run(mainForm);
		}
	}
}
