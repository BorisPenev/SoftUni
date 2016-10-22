namespace _04.NumbersInReversedOrder
{
    using System;
    using System.Text;

    public class NumbersInReversedOrder
    {
        static void Main()
        {
            decimal number = decimal.Parse(Console.ReadLine());

            Console.WriteLine(GetNumberInReverse(number));
        }

        public static string GetNumberInReverse(decimal number)
        {
            string numberAsString = number.ToString();
            StringBuilder sb = new StringBuilder();

            for (int i = numberAsString.Length - 1; i >= 0 ; i--)
            {
                sb.Append(numberAsString[i]);
            }

            return sb.ToString();
        }
    }
}
