using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
			nums.Sort();
			nums.Reverse();
			var largest = nums.Take(3);
			Console.WriteLine($"{string.Join(" ", largest)}");
		}
	}
}
