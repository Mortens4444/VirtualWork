using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using LanguageService;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Infrastructure;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork.WinForms
{
	public partial class AddCameraForm : Form
	{
		private readonly CameraRepository cameraRepository;
		private readonly ServerRepository serverRepository;
		private Camera camera;

		public AddCameraForm(CameraRepository cameraRepository,
			ServerRepository serverRepository)
		{
			this.cameraRepository = cameraRepository;
			this.serverRepository = serverRepository;

			InitializeComponent();
			Translator.Translate(this);
		}

		private void AddCameraForm_Shown(object sender, EventArgs e)
		{
			var servers = serverRepository.GetAll();
			cbServer.Items.Clear();
			cbServer.Items.AddRange(servers.ToArray());

			if (camera == null)
			{
				tbUri.Text = String.Empty;
				rtbDescription.Text = String.Empty;
				tbName.Text = String.Empty;
				tbUsername.Text = String.Empty;
				tbPassword.Text = String.Empty;
				cbServer.SelectedIndex = -1;
			}
			else
			{
				Text = Lng.Elem("Modify camera");
				btnAdd.Text = Lng.Elem("Modify");

				tbUri.Text = camera.Uri;
				rtbDescription.Text = camera.Desription;
				tbName.Text = camera.Name;
				tbUsername.Text = camera.Username;
				tbPassword.Text = camera.Password;

				if (camera.ServerId != null)
				{
					foreach (Server server in cbServer.Items)
					{
						if (server.Id == camera.ServerId)
						{
							cbServer.SelectedItem = server;
							break;
						}
					}
				}
			}
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			bool add = camera == null;
			if (add)
			{
				camera = new Camera();
			}

			camera.Desription = rtbDescription.Text;
			camera.Name = tbName.Text;
			camera.Password = tbPassword.Text;
			camera.Uri = tbUri.Text;
			camera.Username = tbUsername.Text;
			camera.ServerId = ((Server)cbServer.SelectedItem)?.Id;

			cameraRepository.AddOrUpdate(camera);
			camera = null;
		}

		public DialogResult ShowDialog(Camera camera = null)
		{
			this.camera = camera;
			return base.ShowDialog();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}
	}
}
