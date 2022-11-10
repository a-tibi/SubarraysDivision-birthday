using System;
using System.Collections.Generic;
using System.Linq;

namespace SubarraysDivision_birthday
{
	class Result
	{

		/*
		 * Complete the 'birthday' function below.
		 *
		 * The function is expected to return an INTEGER.
		 * The function accepts following parameters:
		 *  1. INTEGER_ARRAY s
		 *  2. INTEGER d
		 *  3. INTEGER m
		 */

		public static int birthday(List<int> s, int d, int m)
		{
			int result = 0;

			for (int i = 0; i < s.Count-m; i++)
			{
				if (s.GetRange(i, m).Sum() == d)
					result++;
			}

			return result;
		}

	}

	class Program
	{
		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine().Trim());

			List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

			string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

			int d = Convert.ToInt32(firstMultipleInput[0]);

			int m = Convert.ToInt32(firstMultipleInput[1]);

			int result = Result.birthday(s, d, m);

			Console.WriteLine(result);
			Console.ReadKey();
		}
	}
}
