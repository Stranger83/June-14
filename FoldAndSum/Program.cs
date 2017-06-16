using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
	class Program
	{
		static void Main(string[] args)
		{
			var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int k = arr.Length / 4;
			var row1left = arr.Take(k).Reverse().ToArray();
			var row1right = arr.Reverse().Take(k).ToArray();
			var row1 = row1left.Concat(row1right).ToArray();
			var row2 = arr.Skip(k).Take(2 * k).ToArray();
			var sumArr = new int[row1.Length];
			for (int i = 0; i < row1.Length; i++)
			{
				sumArr[i] = row1[i] + row2[i];
			}
			Console.WriteLine(string.Join(" ", sumArr));
		}
	}
}
