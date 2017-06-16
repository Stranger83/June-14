using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] separators = new char[]
			{'.', ',', ':', ';', '(', ')','[', ']', '"', '\'', '\\', '/', '!', '?', ' '};

			string sentence = Console.ReadLine().ToLower();
			string[] words = sentence.Split(separators).ToArray();
			var result = words.Where(word => word != "").Where(word => word.Length < 5).Distinct()
				.OrderBy(w => w);

			Console.WriteLine(string.Join(", ", result));
		}
	}
}
