using System;
using System.Diagnostics;
using System.Windows.Forms;
using LanguageService;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Infrastructure;
using VirtualWork.Service.Network;
using VirtualWork.Service.Utils;
using ServerRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Infrastructure.Server, VirtualWork.Persistence.Entities.Server>;

namespace VirtualWork.WinForms
{
	public partial class AddServerForm : Form
	{
		private readonly ServerRepository serverRepository;
		private readonly HostnameProvider hostnameProvider;
		private readonly WindowsMacAddressProvider windowsMacAddressProvider;
		private readonly ErrorBoxHelper errorBoxHelper;

		private Server server;

		public AddServerForm(ServerRepository serverRepository,
			HostnameProvider hostnameProvider,
			WindowsMacAddressProvider windowsMacAddressProvider,
			ErrorBoxHelper errorBoxHelper)
		{
			this.errorBoxHelper = errorBoxHelper;
			this.serverRepository = serverRepository;
			this.hostnameProvider = hostnameProvider;
			this.windowsMacAddressProvider = windowsMacAddressProvider;

			InitializeComponent();
			Translator.Translate(this);
		}

		private void AddServerForm_Shown(object sender, EventArgs e)
		{
			if (server == null)
			{
				Text = Lng.Elem("Create server");
				btnAdd.Text = Lng.Elem("Add");

				tbIpAddress.Text = String.Empty;
				tbMacAddress.Text = String.Empty;
				tbName.Text = String.Empty;
				tbUsername.Text = String.Empty;
				tbPassword.Text = String.Empty;
			}
			else
			{
				Text = Lng.Elem("Modify server");
				btnAdd.Text = Lng.Elem("Modify");

				tbIpAddress.Text = server.IpAddress;
				tbMacAddress.Text = server.MacAddress;
				tbName.Text = server.Name;
				tbUsername.Text = server.Username;
				tbPassword.Text = server.Password;
			}
		}

		private void BtnRemoteConnection_Click(object sender, EventArgs e)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "mstsc",
				Arguments = $"/console /V:{tbIpAddress.Text}"
			});
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			server = server ?? new Server();
			server.Name = tbName.Text;
			server.IpAddress = tbIpAddress.Text;
			server.MacAddress = tbMacAddress.Text;
			server.Password = tbPassword.Text;
			server.Username = tbUsername.Text;
			serverRepository.AddOrUpdate(server);
			server = null;
		}

		private void TbIpAddress_Leave(object sender, EventArgs e)
		{
			try
			{
				if (String.IsNullOrEmpty(tbName.Text))
				{
					tbName.Text = hostnameProvider.GetHostName(tbIpAddress.Text);
				}
				if (String.IsNullOrEmpty(tbMacAddress.Text))
				{
					tbMacAddress.Text = windowsMacAddressProvider.GetMacAddress(tbIpAddress.Text);
				}
			}
			catch (Exception ex)
			{
				errorBoxHelper.Show(ex);
			}
		}

		public DialogResult ShowDialog(Server server = null)
		{
			this.server = server;
			return base.ShowDialog();
		}
	}
}
