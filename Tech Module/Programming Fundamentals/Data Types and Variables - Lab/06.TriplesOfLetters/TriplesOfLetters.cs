using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriplesOfLetters
{
    class TriplesOfLetters
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int l1 = 0; l1 < num; l1++)
            {
                for (int l2 = 0; l2 < num; l2++)
                {
                    for (int l3 = 0; l3 < num; l3++)
                    {
                        char symbol = 'a';
                        Console.WriteLine("{0}{1}{2}",
                            (char)(symbol +l1),
                            (char)(symbol + l2),
                            (char)(symbol + l3));

                    }
                }
            }
        }
    }
}
