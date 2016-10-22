using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string hexNumber = Convert.ToString(number, 16);
            string binaryNumber = Convert.ToString(number, 2);

            Console.WriteLine(hexNumber.ToUpper());
            Console.WriteLine(binaryNumber);
        }
    }
}
