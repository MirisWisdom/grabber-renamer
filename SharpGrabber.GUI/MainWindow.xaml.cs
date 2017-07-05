using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;
using SharpGrabber.Library;

namespace SharpGrabber.GUI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private string metadataPath;
		private string episodesPath;

		public MainWindow()
		{
			InitializeComponent();
			RenameButton.IsEnabled = false;
		}

		void OpenLink(object sender, RequestNavigateEventArgs e)
		{
			Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
			e.Handled = true;
		}

		void SelectJson(object sender, RoutedEventArgs e)
		{
			Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

			dlg.DefaultExt = ".json";
			dlg.Filter = "JSON Grabber Metadata|metadata.json";

			bool? result = dlg.ShowDialog();

			if (result == true) {
				metadataPath = dlg.FileName;
				LogMessage($"Selected Metadata: \"{metadataPath}\"");
				EnableRename();
			}
		}

		void SelectFolder(object sender, RoutedEventArgs e)
		{
			var dialog = new System.Windows.Forms.FolderBrowserDialog();

			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				episodesPath = dialog.SelectedPath;
				LogMessage($"Episodes Path: \"{episodesPath}\"");
			}

			if (episodesPath == null) return;

			EnableRename();
		}

		void RenameEpisodes(object sender, RoutedEventArgs e)
		{
			Anime anime = new Json<Anime>(new Location(metadataPath)).Deserialise();
			anime.RenameEpisodes(new Folder(new Location(episodesPath)));
			LogMessage("Done!");
		}

		void EnableRename()
		{
			if (episodesPath != null && metadataPath != null) {
				RenameButton.IsEnabled = true;
				LogMessage("Ready to rename!");
			}
		}

		void LogMessage(string logData)
		{
			string breakLine = string.IsNullOrWhiteSpace(LogTextBox.Text) ? "" : "\n";
			string date = DateTime.Now.ToString();
			LogTextBox.Text = $"{LogTextBox.Text}{breakLine}{date}:\n{logData}\n";
		}
	}
}
