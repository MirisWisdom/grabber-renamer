using Newtonsoft.Json;
using System.IO;

namespace SharpGrabber.Library
{
	public class Json<T>
	{
		public Location Location { get; private set; }

		public Json(Location location)
		{
			Location = location;
		}

		public T Deserialise()
		{
			T deserialised;

			using (StreamReader file = File.OpenText(Location.Value)) {
				JsonSerializer serializer = new JsonSerializer();
				deserialised = (T)serializer.Deserialize(file, typeof(T));
			}

			return deserialised;
		}

		public void Serialise(T serialisableObject)
		{
			using (StreamWriter writer = new StreamWriter(Location.Value)) {
				writer.WriteLine(JsonConvert.SerializeObject(serialisableObject, Formatting.Indented));
			}
		}
	}
}
