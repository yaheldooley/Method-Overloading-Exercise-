using System.ComponentModel;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 4, true)); ;
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
		public static string Add(int a, int b, bool addDollar)
		{
            int sum = a + b;
            if (addDollar)
            {
                string suffix = sum == 1 ? "dollar" : "dollars";
                return $"{sum} {suffix}";
            }
            else
            {
                return $"{sum}";
            }
		}

	}
}
