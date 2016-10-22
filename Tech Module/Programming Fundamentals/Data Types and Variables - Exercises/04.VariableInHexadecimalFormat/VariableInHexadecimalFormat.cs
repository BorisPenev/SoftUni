using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            string hexNumber = Console.ReadLine();

            int num1 = Convert.ToInt32(hexNumber, 16);
            Console.WriteLine(num1);
        }
    }
}
