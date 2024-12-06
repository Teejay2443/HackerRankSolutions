using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public static class HackerRank
    {
        public static int sum(int a,int b)
        {
            int sum = a + b;
			return sum;
        }
        public static int simpleArraySum(List<int> array)
        {
            int i = 0;
            foreach (int sums in array)
            {
                i += sums;
            }
            return i;
        }
        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0;
            foreach (var num in ar)
            {
                sum += num;
            }
            return sum;
        }
        public static int diagonalDifference(List<List<int>> arr)
        {
            int n = arr.Count;
            int Sum = 0;
            int Sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                Sum += arr[i][i];
                Sum2 += arr[i][n - i - 1];
            }
            return Math.Abs(Sum2 - Sum);
        }
        public static void plusMinus(List<int> arr)
        {
            int n = arr.Count;
            int positive = 0;
            int negative = 0;
            int zero = 0;
            foreach (int number in arr)
            {
                if (number > 0)
                {
                    positive++;
                }
                else if (number < 0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }
            }
            double hhh = (double)positive / n;
            double hh = (double)negative / n;
            double h = (double)zero / n;
            Console.WriteLine(hhh);
            Console.WriteLine(hh);
            Console.WriteLine(h);
        }
		public static void miniMaxSum(List<int> arr)
		{
			arr.Sort();
			long minSum = (long)arr[0] + arr[1] + arr[2] + arr[3];
			long maxSum = (long)arr[1] + arr[2] + arr[3] + arr[4];
			Console.WriteLine(minSum + " " + maxSum);
		}
		public static int birthdayCakeCandles(List<int> candles)
		{
			var num = candles.Max();
			int count = candles.Count(x => x == num);
			return count;
		}
		public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
		{

			int ap = apples.Count(apple => a + apple >= s && a + apple <= t);
			int og = oranges.Count(orange => b + orange >= s && b + orange <= t);
			Console.WriteLine(ap);
			Console.WriteLine(og);
		}
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {

            if ((x1 < x2 && v1 <= v2) || (x2 < x1 && v2 <= v1))
            {
                return "NO";
            }

            if ((x2 - x1) % (v1 - v2) == 0)
            {
                return "YES";
            }
            return "NO";
        }
        public static int getTotalX(List<int> a, List<int> b)
        {
            int start = a.Max();
            int end = b.Min();
            int count = 0;

            for (int candidate = start; candidate <= end; candidate++)
            {
                bool Candidate = a.All(x => candidate % x == 0);

                bool B = b.All(x => x % candidate == 0);

                if (Candidate && B)
                {
                    count++;
                }
            }
            return count;
        }

    }
    public static class codechallenge
    {
        public static int basketBall(string[] input)
        {
			try
            {
				List<int> points = new List<int>();

                foreach (var point in input)
                {

                    if (point == "+")
                    {
                        int sum = points[points.Count - 1] + points[points.Count - 2];
                        points.Add(sum);
                    }
                    else if (point == "D")
                    {
                        int Dpoint = 2 * points[points.Count - 1];
                        points.Add(Dpoint);
                    }
                    else if (point == "C")
                    {
                        int Cpoint = points[points.Count - 1];
                        points.Remove(Cpoint);
                    }
                    else
                    {
                        points.Add(Convert.ToInt32(point));
                    }
                }
                int Sumtoatal = 0;
                foreach (var score in points)
                {
                    Sumtoatal += score;
                }
                return Sumtoatal;
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            return 0;
        }
    }  

}
