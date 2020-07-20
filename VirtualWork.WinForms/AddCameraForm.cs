using System.Linq;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Infrastructure;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork.WinForms
{
	public partial class AddCameraForm : Form
	{
		private readonly CameraRepository cameraRepository;
		private readonly ServerRepository serverRepository;

		public AddCameraForm(CameraRepository cameraRepository,
			ServerRepository serverRepository)
		{
			InitializeComponent();
			Translator.Translate(this);

			this.cameraRepository = cameraRepository;
			this.serverRepository = serverRepository;
		}

		private void AddCameraForm_Shown(object sender, System.EventArgs e)
		{
			var servers = serverRepository.GetAll();
			cbServer.Items.AddRange(servers.ToArray());
		}

		private void BtnAdd_Click(object sender, System.EventArgs e)
		{
			var camera = new Camera
			{
				Desription = rtbDescription.Text,
				Name = tbName.Text,
				Password = tbPassword.Text,
				Uri = tbUri.Text,
				Username = tbUsername.Text,
				ServerId = ((Server)cbServer.SelectedItem)?.Id
			};
			cameraRepository.Add(camera);
		}
	}
}
