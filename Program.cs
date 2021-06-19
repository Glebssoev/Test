using System;
using System.Net.Http;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 8.9;
            double c = 9.2;
            int sum = Convert.ToInt32(a + c);
            Console.WriteLine(sum);
            if (sum >= 18.1)
            {
                Console.WriteLine(typeof(MessageProcessingHandler));
            }
        }
    }
}
