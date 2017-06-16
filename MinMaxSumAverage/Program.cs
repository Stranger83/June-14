using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumAverage
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var nums = new List<double>();
			for (int i = 0; i < n; i++)
			{
				double num = double.Parse(Console.ReadLine());
				nums.Add(num);
			}
						
			var sum = nums.Sum();
			var min = nums.Min();
			var max = nums.Max();
			var av = nums.Average();
			Console.WriteLine($"Sum = {sum}");
			Console.WriteLine($"Min = {min}");
			Console.WriteLine($"Max = {max}");
			Console.WriteLine($"Average = {av}");
		}
	}
}
