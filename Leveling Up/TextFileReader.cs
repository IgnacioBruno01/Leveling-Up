using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Leveling_Up
{
    class TextFileReader
    {
		public static class TextFileReader
		{
			public static List<string> ReadTextFile(string filePath)
			{
				List<string> outputs = new List<string>();
				outputs.AddRange(File.ReadAllLines(filePath));
				return outputs;
			}
		}
	}
}
