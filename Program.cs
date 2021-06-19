using System;
using System.Net.Http;

namespace TestGit
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number");
            double b = double.Parse(Console.ReadLine());
            double c = 6.2;
            int sum = Convert.ToInt32(b + c);
            Console.WriteLine(sum);
            int[] what = new int[sum];
            if (what.Length >= 18)
            {
                Console.WriteLine($"{sum} :)");
            }
            else
            {
                Main();
            }
        }

        static void Meh()
        {
            
        }
    }
}
