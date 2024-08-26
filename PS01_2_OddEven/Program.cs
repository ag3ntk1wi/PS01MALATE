using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_2_OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("The number " + num + " is Positive.");
            }

            else 
            {
                Console.WriteLine("The number " + num + " is Negative.");
            }
        }
    }
}
