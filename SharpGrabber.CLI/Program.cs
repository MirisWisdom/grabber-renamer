/*
	The MIT License (MIT)

	Copyright (c) 2017 Roman Emilian

	Permission is hereby granted, free of charge, to any person obtaining a copy
	of this software and associated documentation files (the "Software"), to deal
	in the Software without restriction, including without limitation the rights
	to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
	copies of the Software, and to permit persons to whom the Software is
	furnished to do so, subject to the following conditions:

	The above copyright notice and this permission notice shall be included in
	all copies or substantial portions of the Software.

	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
	THE SOFTWARE.
*/

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