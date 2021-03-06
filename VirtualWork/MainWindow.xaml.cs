﻿using System.Diagnostics;
using System.IO;
using System.Windows;
using LanguageService;
using LanguageService.WPF;
using VirtualWork.Core.Directories;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow(UserRepository usersRepository)
		{
			InitializeComponent();
			Translator.Translate(this);
		}

		private void UserGuideMenuItem_Click(object sender, RoutedEventArgs e)
		{
			Process.Start(Path.Combine(DirectoryProvider.DocumentaionFolder, "VIRtual Work User Guide.pdf"));
		}

		private void SetGermanLanguageMenuItem_Click(object sender, RoutedEventArgs e)
		{
			Lng.DefaultLanguage = LanguageService.Language.German;
			Translator.Translate(this);
		}

		private void SetEnglishLanguageMenuItem_Click(object sender, RoutedEventArgs e)
		{
			Lng.DefaultLanguage = LanguageService.Language.English;
			Translator.Translate(this);
		}

		private void SetHungarianLanguageMenuItem_Click(object sender, RoutedEventArgs e)
		{
			Lng.DefaultLanguage = LanguageService.Language.Hungarian;
			Translator.Translate(this);
		}

		private void SetChineseLanguageMenuItem_Click(object sender, RoutedEventArgs e)
		{
			Lng.DefaultLanguage = LanguageService.Language.Chinese;
			Translator.Translate(this);
		}

		private void MenuItem_Click(object sender, RoutedEventArgs e)
		{

		}

		private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
		{
			var aboutWindow = new AboutWindow();
			aboutWindow.Show();
		}
	}
}
