using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num %2 == 0)
            {
                Console.WriteLine("The number " + num + " is Even.");
            }
        }
    }
}
