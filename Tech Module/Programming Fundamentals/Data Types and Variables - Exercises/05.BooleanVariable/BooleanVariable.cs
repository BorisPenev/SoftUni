using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            bool isBoolean = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(isBoolean? "Yes":"No");
        }
    }
}
