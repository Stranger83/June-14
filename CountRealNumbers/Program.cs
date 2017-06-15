using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

			var dict = new SortedDictionary<double, int>();
			foreach (var num in nums)
			{
				if (dict.ContainsKey(num))
				{
					dict[num]++;
				}
				else
				{
					dict[num] = 1;
				}
			}
			foreach (var item in dict.Keys)
			{
				Console.WriteLine($"{item} -> {dict[item]}");
			}
		}
	}
}
