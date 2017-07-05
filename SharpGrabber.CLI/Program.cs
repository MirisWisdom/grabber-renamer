using SharpGrabber.Library;
using System;
using System.IO;

namespace SharpGrabber.CLI
{
	class Program
	{
		static void Main(string[] args)
		{
			string metadataPath;
			string episodesPath;

			if (!File.Exists(args[0]) || !args[0].Contains(".json")) {
				Console.WriteLine("Please select a valid JSON file!");
				Environment.Exit(1);
			}

			if (!Directory.Exists(args[1])) {
				Console.WriteLine("Please select a valid directory!");
				Environment.Exit(1);
			}

			metadataPath = args[0];
			episodesPath = args[1];

			Json<Anime> json = new Json<Anime>(new Location(metadataPath));
			Anime anime = json.Deserialise();
			anime.RenameEpisodes(new Folder(new Location(episodesPath)));

			Console.WriteLine("Finished!");
			Console.ReadLine();
		}
	}
}