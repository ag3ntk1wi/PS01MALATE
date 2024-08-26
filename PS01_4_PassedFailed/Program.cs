using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_4_PassedFailed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Exam Score: ");
            int examScore = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((examScore >= 50) ? "Passed." : "Failed." ;);
        }
    }
}
