using System;

namespace _01.BlankReceipt
{
    class BlankReceipt
    {
        static void Main(string[] args)
        {
            //string header = Console.ReadLine();
            //string body = Console.ReadLine();
            //string footer = Console.ReadLine();

            PrintReceipt();

        }
        public static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        public static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("{0} SoftUni", "\u00A9");
        }
    }
}
