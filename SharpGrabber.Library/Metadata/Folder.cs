namespace SharpGrabber.Library
{
	public class Folder
	{
		public Location Location { get; private set; }

		public Folder(Location location)
		{
			Location = location;
		}
	}
}
