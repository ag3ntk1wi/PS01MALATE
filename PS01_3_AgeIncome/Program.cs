using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_3_AgeIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Monthly Income: ");
            int income = Convert.ToInt32(Console.ReadLine());

            if (age >= 25 && age <= 35 && income > 50000)
            {
                Console.WriteLine("Young Professional.");
            }
            else if (age >= 36 && age <= 55 && income > 70000)
            {
                Console.WriteLine("Middle-Aged Professional.");
            }
            else if (age >= 56 && income < 30000)
            {
                Console.WriteLine("Senior Citizen.");
            }
            else 
            {
                Console.WriteLine("Others.");
            }
        }
    }
}
