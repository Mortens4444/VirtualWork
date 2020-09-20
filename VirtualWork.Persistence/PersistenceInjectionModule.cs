using System;
using System.Linq;
using System.Reflection;
using Ninject;
using Ninject.Modules;
using Ninject.Syntax;
using VirtualWork.Core.Utils;

namespace VirtualWork.Persistence
{
	public class PersistenceInjectionModule : NinjectModule
	{
		public override void Load()
		{
			var binding = Bind<VirtualWorkDatabaseContext>().ToSelf().InSingletonScope();
			var virtualWorkDatabaseContext = binding.Kernel.Get<VirtualWorkDatabaseContext>();
			var properties = typeof(VirtualWorkDatabaseContext).GetProperties();
			var bindMethod = GetType().GetFirstGenericFunctionWithNameAndOneTypeParameter("Bind");
			foreach (var property in properties)
			{
				dynamic bindingToSyntax = bindMethod.MakeGenericMethod(property.PropertyType).Invoke(this, null);
				var value = DynamicCast(property.GetValue(virtualWorkDatabaseContext), property.PropertyType);
				bindingToSyntax.ToConstant(value).InSingletonScope();
			}

			var converters = TypeUtils.GetClassesInNamespace(Assembly.GetAssembly(GetType()), "VirtualWork.Persistence.Converters").
				Where(type => type.BaseType.Name == "ConverterBase`2");
			foreach (var converter in converters)
			{
				var targetToBind = typeof(IBindingToSyntax<>).MakeGenericType(converter.BaseType);
				var bindingToSyntax = bindMethod.MakeGenericMethod(converter.BaseType).Invoke(this, null);
				var toMethod = targetToBind.GetFirstGenericFunctionWithNameAndOneTypeParameter("To");
				var genericToMethod = toMethod.MakeGenericMethod(converter);
				genericToMethod.Invoke(bindingToSyntax, null);
			}
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
