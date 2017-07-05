using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SharpGrabber.Library
{
	public class Anime
	{
		[JsonProperty(PropertyName = "animeName")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "animeUrl")]
		public string Address { get; set; }

		[JsonProperty(PropertyName = "files")]
		public List<Episode> Episodes { get; set; }

		[JsonProperty(PropertyName = "timestamp")]
		public DateTime Timestamp { get; set; }

		[JsonProperty(PropertyName = "server")]
		public string Server { get; set; }

		public void RenameEpisodes(Folder folder)
		{
			foreach (Episode episode in Episodes) {
				string oldPath = Path.Combine(folder.Location.Value, episode.OriginalName);
				string newPath = Path.Combine(folder.Location.Value, episode.RealName);

				if (File.Exists(oldPath)) {
					File.Move(oldPath, newPath);
				}
			}
		}
	}
}
