using System;

namespace _07.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type.ToLower().Equals("int"))
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(firstNumber, secondNumber));
            }

            else if (type.ToLower().Equals("char"))
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(firstChar, secondChar));
            }
            else
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();

                Console.WriteLine(GetMax(firstString, secondString));
            }
        }

        public static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
        public static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar >= secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
        public static string GetMax(string firstString, string secondString)
        {
            int result = firstString.CompareTo(secondString);
            if (result >= 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }      
        }
    }
}
