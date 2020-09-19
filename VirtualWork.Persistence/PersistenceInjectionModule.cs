using System;
using System.Linq;
using System.Reflection;
using Ninject;
using Ninject.Modules;
using VirtualWork.Persistence.Converters;

namespace VirtualWork.Persistence
{
	public class PersistenceInjectionModule : NinjectModule
	{
		public override void Load()
		{
			var binding = Bind<VirtualWorkDatabaseContext>().ToSelf().InSingletonScope();
			var virtualWorkDatabaseContext = binding.Kernel.Get<VirtualWorkDatabaseContext>();
			var properties = typeof(VirtualWorkDatabaseContext).GetProperties();
			var bindMethod = GetType().GetMethods().First(method => method.Name == "Bind" && method.GetGenericArguments().Length == 1);
			foreach (var property in properties)
			{
				dynamic bindingToSyntax = bindMethod.MakeGenericMethod(property.PropertyType).Invoke(this, null);
				var value = DynamicCast(property.GetValue(virtualWorkDatabaseContext), property.PropertyType);
				bindingToSyntax.ToConstant(value).InSingletonScope();
			}

			Bind<ConverterBase<Core.Other.Comment, Entities.Comment>>().To<CommentConverter>();
			Bind<ConverterBase<Core.Media.EntityImage, Entities.EntityImage>>().To<EntityImageConverter>();
			Bind<ConverterBase<Core.Appointment.Event, Entities.Event>>().To<EventConverter>();
			Bind<ConverterBase<Core.Job.Issue, Entities.Issue>>().To<IssueConverter>();
			Bind<ConverterBase<Core.Job.IssueHistory, Entities.IssueHistory>>().To<IssueHistoryConverter>();
			Bind<ConverterBase<Core.Production.License, Entities.License>>().To<LicenseConverter>();
			Bind<ConverterBase<Core.Log.LogEntry, Entities.LogEntry>>().To<LogEntryConverter>();
			Bind<ConverterBase<Core.Appointment.Meeting, Entities.Meeting>>().To<MeetingConverter>();
			Bind<ConverterBase<Core.Infrastructure.Resource, Entities.Resource>>().To<ResourceConverter>();
			Bind<ConverterBase<Core.Infrastructure.Server, Entities.Server>>().To<ServerConverter>();
			Bind<ConverterBase<Core.Actors.User, Entities.User>>().To<UserConverter>();
			Bind<ConverterBase<Core.Settings.UserSetting, Entities.UserSetting>>().To<UserSettingConverter>();
		}

		private dynamic DynamicCast(object obj, Type to)
		{
			var openCast = GetType().GetMethod("Cast", BindingFlags.Static | BindingFlags.NonPublic);
			var closeCast = openCast.MakeGenericMethod(to);
			return closeCast.Invoke(obj, new[] { obj });
		}

		private static T Cast<T>(object obj)
		{
			return (T)obj;
		}
	}
}
