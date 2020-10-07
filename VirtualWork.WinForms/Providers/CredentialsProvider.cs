using System;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using VirtualWork.Core.Extensions;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Entities;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Extensions;

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
			Expression<Func<Credentials, bool>> resultExpression = credentials =>
				(credentials.ActorType == (int)ActorType.User && credentials.ActorId == Initializer.LoggedInUser.Id) ||
				(credentials.ActorType == (int)ActorType.Group && Initializer.LoggedInUser.Groups.Any(group => group.Id == credentials.ActorId));
			Expression<Func<Credentials, bool>> groupFilter = credentials => credentials.Group == selectedGroup;
			Expression<Func<Credentials, bool>> searchPatternFilter = credentials => credentials.Name.ToLower().Contains(searchPattern.ToLower());

			if (!String.IsNullOrEmpty(selectedGroup))
			{
				resultExpression = resultExpression.And(groupFilter);
			}
			if (!String.IsNullOrEmpty(searchPattern))
			{
				resultExpression = resultExpression.And(searchPatternFilter);
			}
			listView.Items.Clear();
			var allCredentials = credentialsRepository.GetAll(resultExpression.Compile());

			int i = 0;
			foreach (var credentials in allCredentials)
			{
				var backColor = i % 2 == 0 ? listView.BackColor : Color.LightBlue;
				var item = credentials.ToListViewItem(backColor);
				listView.Items.Add(item);
				i++;
			}
		}
	}
}
