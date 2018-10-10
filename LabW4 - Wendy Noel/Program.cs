using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW4___Wendy_Noel
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dAmount1;
            decimal dAmount2;
            decimal dResult;

            //dAmount1 = 10;
            //dAmount2 = 20;

            // User enters 1st number
            Console.WriteLine("Enter the amount for the first number:");
            dAmount1 = decimal.Parse(Console.ReadLine());
           
            // User enters 2nd number
            Console.WriteLine("Enter the amount for the second number:");
            dAmount2 = decimal.Parse(Console.ReadLine());

            // Display result
            dResult = dAmount1 + dAmount2;
            Console.WriteLine("The result of {0} + {1} is {2}", dAmount1, dAmount2, dResult);
            Console.ReadLine();

            int x = 7;
            int y = 10;
            int z = 15;
            int result = (x + y) * (z + 10);

            Console.WriteLine("The value of x is 7");
            Console.ReadLine();

            Console.WriteLine("The value of y is 10");
            Console.ReadLine();

            Console.WriteLine("The value of z is 15");
            Console.ReadLine();

            result = (x + y) * (z + 10);
            Console.WriteLine("The product of {0} + {1} * {2} + {3} is {4}", x, y, z, 10, result);
            Console.ReadLine();

            Console.WriteLine("Hello\tWorld!");
            Console.ReadLine();
            Console.WriteLine("Hello\nWorld!");
            Console.ReadLine();
            Console.WriteLine("\"Hello World!\"");
            Console.ReadLine();
            Console.WriteLine("Hello\\World!");
        }
    }
}
