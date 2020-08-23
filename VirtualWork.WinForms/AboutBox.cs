using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using LanguageService;
using VirtualWork.Service.Utils;

namespace VirtualWork.WinForms
{
	public partial class AboutBox : Form
	{
		private readonly ErrorBoxHelper errorBoxHelper;

		public AboutBox(ErrorBoxHelper errorBoxHelper)
		{
			this.errorBoxHelper = errorBoxHelper;

			InitializeComponent();
			Text = $"{Lng.Elem("About")} {AssemblyTitle}";
			labelProductName.Text = AssemblyTitle;
			labelVersion.Text = $"{Lng.Elem("Version")} {AssemblyVersion}";
			labelCopyright.Text = AssemblyCopyright;
			labelCompanyName.Text = AssemblyCompany;
			try
			{
				textBoxDescription.Text = File.ReadAllText(".\\LICENSE.TXT");
			}
			catch (Exception ex)
			{
				errorBoxHelper.Show(ex);
			}
		}

		public string AssemblyTitle => "VIRtual Work";

		public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

		public string AssemblyDescription => GetFirstAttirute<AssemblyDescriptionAttribute>()?.Description ?? String.Empty;

		public string AssemblyCopyright => GetFirstAttirute<AssemblyCopyrightAttribute>()?.Copyright ?? String.Empty;

		public string AssemblyCompany => GetFirstAttirute<AssemblyCompanyAttribute>()?.Company ?? String.Empty;

		private static TAttributeType GetFirstAttirute<TAttributeType>()
		{
			var assembly = Assembly.GetExecutingAssembly();
			var attributes = assembly.GetCustomAttributes(typeof(TAttributeType), false);
			if (attributes.Length == 0)
			{
				return default(TAttributeType);
			}
			return (TAttributeType)attributes[0];
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}
	}
}
