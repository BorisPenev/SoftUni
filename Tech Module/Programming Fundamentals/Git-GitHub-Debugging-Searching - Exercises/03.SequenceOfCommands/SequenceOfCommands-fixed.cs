using System;
using System.Linq;

namespace _03.SequenceOfCommands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Contains("stop"))
            {
                int[] args = new int[2];
                string[] stringParams = command.Split(ArgumentsDelimiter);
                string action = stringParams[0];

                if (command.Contains("add") ||
                    command.Contains("subtract") ||
                    command.Contains("multiply"))
                {
                    
                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);

                    PerformAction(ref array, action, args);
                    PrintArray(ref array);
                }
                else if (command.Contains("lshift") || command.Contains("rshift"))
                {
                    PerformAction(ref array, action, args);
                    PrintArray(ref array);
                }
                

                command = Console.ReadLine();
            }
        }

        static void PerformAction(ref long[] arr, string action, int[] args)
        {
            //long[] array = arr.Clone() as long[];
            int pos = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos] *= value;
                    break;
                case "add":
                    arr[pos] += value;
                    break;
                case "subtract":
                    arr[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(ref arr);
                    break;
                case "rshift":
                    ArrayShiftRight(ref arr);
                    break;
            }
        }

        private static void ArrayShiftRight(ref long[] array)
        {
            long lastEelement = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {                
                array[i] = array[i - 1];
            }
            array[0] = lastEelement;
        }

        private static void ArrayShiftLeft(ref long[] array)
        {
            long firstEelement = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];                
            }
            array[array.Length - 1] = firstEelement;
        }

        private static void PrintArray(ref long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}{1}",
                    array[i],
                    (i == array.Length -1)? "":" ");
            }
            Console.WriteLine();
        }
    }
}
