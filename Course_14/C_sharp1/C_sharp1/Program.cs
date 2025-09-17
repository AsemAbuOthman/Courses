using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp1
{
    internal class Program
    {
        static void Main(string[] args) {

            double num1, num2;

            Console.Write("Enter two numbers to sum it : ");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));

            Console.ReadKey();
        }
    }
}
