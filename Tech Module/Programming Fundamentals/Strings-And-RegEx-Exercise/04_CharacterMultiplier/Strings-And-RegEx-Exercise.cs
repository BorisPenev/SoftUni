namespace _04_CharacterMultiplier
{
    using System;
    using System.Linq;

    public class CharacterMultiplier
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int sum = 0;

            if (input[0].Length <= input[1].Length)
            {
                int lenght = input[0].Length;
                
                for (int i = 0; i < lenght; i++)
                {
                    sum += input[0][i] * input[1][i];
                }

                int leftSum = input[1].Skip(lenght).Sum(x => x);

                sum += leftSum;
            }
            else
            {
                int lenght = input[1].Length;

                for (int i = 0; i < lenght; i++)
                {
                    sum += input[0][i] * input[1][i];
                }

                int leftSum = input[0].Skip(lenght).Sum(x => x);

                sum += leftSum;
            }

            Console.WriteLine((int)sum);
        }
    }
}
