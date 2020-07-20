using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Entities;
using VirtualWork.Persistence.Helper;

namespace VirtualWork.Tests.Persistence.Helper
{
	[TestClass]
	public class PropertyCopierTest
	{
		[TestMethod]
		public void CopyPropertiesBetweenDifferentTypes()
		{
			var systemSetting = new SystemSetting
			{
				Id = 1,
				Name = "2",
				Value = "3"
			};
			var userSetting = new UserSetting();

			PropertyCopier.CopyProperties(systemSetting, userSetting);

			Assert.AreEqual(systemSetting.Id, userSetting.Id);
			Assert.AreEqual(systemSetting.Name, userSetting.Name);
			Assert.AreEqual(systemSetting.Value, userSetting.Value);
		}

		[TestMethod]
		public void DoNotCopyPropertiesWhenThereIsPropertyTypeMismatch()
		{
			var user = new User
			{
				Id = 1,
				Groups = new List<Group> { new Group { Name = "Administrators" } }
			};
			var userDto = new Core.Actors.User();

			PropertyCopier.CopyProperties(user, userDto);

			Assert.AreEqual(user.Id, userDto.Id);
			Assert.IsNotNull(user.Groups);
			Assert.IsNull(userDto.Groups);
		}

		[TestMethod]
		public void DoNotCopyPropertiesWhenThereIsPropertyTypeMismatchII()
		{
			var address = new Address
			{
				Id = 1,
				PublicAreaKind = 1
			};
			var addressDto = new Core.Contacts.Address();

			PropertyCopier.CopyProperties(address, addressDto);

			Assert.AreEqual(address.Id, addressDto.Id);
			Assert.AreEqual((PublicAreaKind)0, addressDto.PublicAreaKind);
		}
	}
}
