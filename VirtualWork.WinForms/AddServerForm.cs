using System;
using System.Diagnostics;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using MessageBoxes;
using VirtualWork.Core.Infrastructure;
using VirtualWork.Persistence.Repositories;
using VirtualWork.Service.Network;

namespace VirtualWork.WinForms
{
	public partial class AddServerForm : Form
	{
		private readonly ServerRepository serverRepository;
		private readonly HostnameProvider hostnameProvider;
		private readonly WindowsMacAddressProvider windowsMacAddressProvider;

		public AddServerForm(ServerRepository serverRepository,
			HostnameProvider hostnameProvider,
			WindowsMacAddressProvider windowsMacAddressProvider)
		{
			InitializeComponent();
			Translator.Translate(this);

			this.serverRepository = serverRepository;
			this.hostnameProvider = hostnameProvider;
			this.windowsMacAddressProvider = windowsMacAddressProvider;
		}

		private void AddServerForm_Shown(object sender, EventArgs e)
		{
			tbIpAddress.Text = String.Empty;
			tbMacAddress.Text = String.Empty;
			tbName.Text = String.Empty;
			tbUsername.Text = String.Empty;
			tbPassword.Text = String.Empty;
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
			var server = new Server
			{
				Name = tbName.Text,
				IpAddress = tbIpAddress.Text,
				MacAddress = tbMacAddress.Text,
				Password = tbPassword.Text,
				Username = tbUsername.Text
			};
			serverRepository.Add(server);
		}

		private void TbIpAddress_Leave(object sender, EventArgs e)
		{
			try
			{
				tbName.Text = hostnameProvider.GetHostName(tbIpAddress.Text);
				tbMacAddress.Text = windowsMacAddressProvider.GetMacAddress(tbIpAddress.Text);
			}
			catch (Exception ex)
			{
				ErrorBox.Show(ex);
			}
		}
	}
}
