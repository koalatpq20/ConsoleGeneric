using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Operator<int> operatorInt = new Operator<int>();
            operatorInt.Display(100);

            Operator<double> operatorDouble = new Operator<double>();
            operatorDouble.Display(50.25);

            Operator<string> operatorString = new Operator<string>();
            operatorString.Display("Hello...");

            Console.ReadLine();
        }
    }
}
