using System;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Persistence;
using VirtualWork.WinForms.Creators;

namespace VirtualWork.WinForms
{
	public partial class DatabaseSettingsForm : Form
	{
		private const string ConnectionStrings = "connectionStrings";

		public string ConnectionString => tbSqlServerConnectionString.Text;
		private readonly AdminGroupCreator adminGroupCreator;
		private readonly AdminUserCreator adminUserCreator;

		public DatabaseSettingsForm(AdminGroupCreator adminGroupCreator,
			AdminUserCreator adminUserCreator)
		{
			this.adminGroupCreator = adminGroupCreator;
			this.adminUserCreator = adminUserCreator;

			InitializeComponent();
			Translator.Translate(this);

			var connectionString = ConfigurationManager.ConnectionStrings[PersistenceConstants.VirtualWorkDbConnectionString].ConnectionString;
			if (!String.IsNullOrEmpty(connectionString))
			{
				tbSqlServerConnectionString.Text = connectionString;
			}
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			var connectionStringsSection = (ConnectionStringsSection)config.GetSection(ConnectionStrings);
			connectionStringsSection.ConnectionStrings[PersistenceConstants.VirtualWorkDbConnectionString].ConnectionString = ConnectionString;
			config.Save();
			ConfigurationManager.RefreshSection(ConnectionStrings);

			if (adminGroupCreator.CheckExistence())
			{
				if (adminUserCreator.CheckExistence())
				{
					btnSave.DialogResult = DialogResult.OK;
				}
			}
		}
	}
}
