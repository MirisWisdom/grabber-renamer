using Newtonsoft.Json;

namespace SharpGrabber.Library
{
	public class Episode
	{
		[JsonProperty(PropertyName = "original")]
		public string OriginalName { get; set; }

		[JsonProperty(PropertyName = "real")]
		public string RealName { get; set; }

		public Episode(string originalName, string realName)
		{
			OriginalName = originalName;
			RealName = realName;
		}
	}
}
