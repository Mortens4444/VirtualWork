using System.Linq;
using System.Windows.Forms;
using LanguageService;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork.WinForms.Providers
{
	public class PasswordManagerGroupsProvider
	{
		private readonly CredentialsRepository credentialsRepository;

		public PasswordManagerGroupsProvider(CredentialsRepository credentialsRepository)
		{
			this.credentialsRepository = credentialsRepository;
		}

		public void GetGroups(ComboBox comboBox)
		{
			comboBox.Items.Clear();
			var groups = credentialsRepository.GetGroups(credentials =>
					(credentials.ActorType == (int)ActorType.User && credentials.ActorId == Initializer.LoggedInUser.Id) ||
					(credentials.ActorType == (int)ActorType.Group && Initializer.LoggedInUser.Groups.Any(group => group.Id == credentials.ActorId)));
			comboBox.Items.Add(Lng.Elem("All"));
			foreach (var group in groups)
			{
				comboBox.Items.Add(group);
			}
		}
	}
}
