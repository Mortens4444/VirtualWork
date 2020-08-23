using System;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.WinForms.Creators;

namespace VirtualWork.WinForms
{
	public partial class DatabaseSettingsForm : Form
	{
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

			var connectionString = ConfigurationManager.ConnectionStrings["VirtualWorkDbConnectionString"].ConnectionString;
			if (!String.IsNullOrEmpty(connectionString))
			{
				tbSqlServerConnectionString.Text = connectionString;
			}
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
			connectionStringsSection.ConnectionStrings["VirtualWorkDbConnectionString"].ConnectionString = ConnectionString;
			config.Save();
			ConfigurationManager.RefreshSection("connectionStrings");

			if (adminGroupCreator.CheckExistence())
			{
				if (adminUserCreator.CheckExistence())
				{
					btnSave.DialogResult = DialogResult.OK;
				}
			}
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}
	}
}
