using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Entities;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork.WinForms.Providers
{
	public class CredentialsProvider
	{
		private readonly CredentialsRepository credentialsRepository;

		public CredentialsProvider(CredentialsRepository credentialsRepository)
		{
			this.credentialsRepository = credentialsRepository;
		}

		public void GetCredentials(ListView listView, string searchPattern, string selectedGroup)
		{
			Func<Credentials, bool> predicate;
			if (String.IsNullOrEmpty(searchPattern))
			{
				predicate = String.IsNullOrEmpty(selectedGroup) ?

					(Func<Credentials, bool>)(credentials =>
					(credentials.ActorType == (int)ActorType.User && credentials.ActorId == Initializer.LoggedInUser.Id) ||
					(credentials.ActorType == (int)ActorType.Group && Initializer.LoggedInUser.Groups.Any(group => group.Id == credentials.ActorId))) :

					credentials => ((credentials.ActorType == (int)ActorType.User && credentials.ActorId == Initializer.LoggedInUser.Id) ||
					(credentials.ActorType == (int)ActorType.Group && Initializer.LoggedInUser.Groups.Any(group => group.Id == credentials.ActorId))) &&
					credentials.Group == selectedGroup;
			}
			else
			{
				predicate = String.IsNullOrEmpty(selectedGroup) ?

					(Func<Credentials, bool>)(credentials => ((credentials.ActorType == (int)ActorType.User && credentials.ActorId == Initializer.LoggedInUser.Id) ||
					(credentials.ActorType == (int)ActorType.Group && Initializer.LoggedInUser.Groups.Any(group => group.Id == credentials.ActorId))) &&
					credentials.Name.ToLower().Contains(searchPattern.ToLower())) :

					credentials => ((credentials.ActorType == (int)ActorType.User && credentials.ActorId == Initializer.LoggedInUser.Id) ||
					(credentials.ActorType == (int)ActorType.Group && Initializer.LoggedInUser.Groups.Any(group => group.Id == credentials.ActorId))) &&
					credentials.Name.ToLower().Contains(searchPattern.ToLower()) && credentials.Group == selectedGroup;
			}
			listView.Items.Clear();
			var allCredentials = credentialsRepository.GetAll(predicate);

			var random = new Random();
			int i = 0;
			foreach (var credential in allCredentials)
			{
				var item = new ListViewItem(credential.Name)
				{
					Tag = credential,
					BackColor = i % 2 == 0 ? listView.BackColor : Color.LightBlue
				};
				item.SubItems.Add(credential.Group);
				item.SubItems.Add(credential.Username);
				var fakePasswordLength = random.Next(5, 12);
				var stars = new char[fakePasswordLength];
				for (int j = 0; j < stars.Length; j++)
				{
					stars[j] = '*';
				}
				item.SubItems.Add(new String(stars));
				item.SubItems.Add(credential.Link);
				item.SubItems.Add(credential.AlternativeLink);
				item.SubItems.Add(credential.ExtraInformation);
				listView.Items.Add(item);
				i++;
			}
		}
	}
}
