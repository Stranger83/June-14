using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrances
{
	class Program
	{
		static void Main(string[] args)
		{
			var words = Console.ReadLine().ToLower().Split(' ').ToArray();
			var dict = new Dictionary<string, int>();
			foreach (var word in words)
			{
				if (dict.ContainsKey(word))
				{
					dict[word]++;
				}
				else
				{
					dict[word] = 1;
				}
			}
			var output = new List<string>();
			foreach (var item in dict)
			{
				if (item.Value % 2 == 1)
				{
					output.Add(item.Key);
				}
			}
			Console.WriteLine(string.Join(", ", output));
		}
	}
}
