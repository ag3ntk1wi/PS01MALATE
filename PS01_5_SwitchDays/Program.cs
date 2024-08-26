using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_5_SwitchDays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PI = 3.14;

            Console.Write("Enter Radius: ");
            int rad = Convert.ToInt32(Console.ReadLine());
            Console.Write("P : Perimeter ; A : Area ; X : Exit");
            char compute = Convert.ToChar(Console.ReadLine());

            switch(compute)
            {
                case 'P':
                    double pmeter = 2 * PI * rad;
                    Console.WriteLine("The Perimeter is " + pmeter);
                    break;
                case 'A':
                    double area = PI * (rad ** 2);
                    Console.WriteLine("The Area is " + area);
                    break;
                case 'X':
                    Console.WriteLine("Thank You.");
                    break;
                default:
                    Console.WriteLine("Invalid Option.");
                    break;
            }
        }
    }
}
