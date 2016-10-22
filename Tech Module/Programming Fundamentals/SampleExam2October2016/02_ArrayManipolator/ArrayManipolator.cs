namespace _02_ArrayManipolator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipolator
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] command = Console.ReadLine().Split();
            int count = 0;

            while (!command[0].Equals("end"))
            {
                switch (command[0])
                {
                    case "max":
                        {
                            bool isEven = command[1].Equals("even") ? true : false;
                            int indexOfMax = -1;
                            int max = int.MinValue;

                            for (int i = 0; i < input.Length; i++)
                            {
                                int num = int.Parse(input[i]);
                                if (isEven)
                                {
                                    if (num % 2 == 0 && num > max)
                                    {
                                        max = num;
                                    }
                                }
                                else
                                {
                                    if (num % 2 == 1 && num > max)
                                    {
                                        max = num;
                                    }
                                }
                            }

                            if (max != int.MinValue)
                            {
                                indexOfMax = Array.LastIndexOf(input, max.ToString());
                                Console.WriteLine(indexOfMax);
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        break;
                    case "min":
                        {
                            bool isEven = command[1].Equals("even") ? true : false;
                            int indexOfMin = -1;
                            int min = int.MaxValue;


                            for (int i = 0; i < input.Length; i++)
                            {
                                int num = int.Parse(input[i]);
                                if (isEven)
                                {
                                    if (num % 2 == 0 && num < min)
                                    {
                                        min = num;
                                    }
                                }
                                else
                                {
                                    if (num % 2 == 1 && num < min)
                                    {
                                        min = num;
                                    }
                                }
                            }

                            if (min != int.MaxValue)
                            {
                                indexOfMin = Array.LastIndexOf(input, min.ToString());
                                Console.WriteLine(indexOfMin);
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }

                        }
                        break;
                    case "first":
                        {
                            count = int.Parse(command[1]);
                            bool isEven = command[2].Equals("even") ? true : false;
                            List<int> evenOrOddArr = new List<int>();

                            if (count >= 0 && count <= input.Length)
                            {
                                for (int i = 0; i < input.Length; i++)
                                {
                                    int num = int.Parse(input[i]);
                                    if (isEven)
                                    {
                                        if (num % 2 == 0)
                                        {
                                            evenOrOddArr.Add(num);
                                        }
                                    }
                                    else
                                    {
                                        if (num % 2 == 1)
                                        {
                                            evenOrOddArr.Add(num);
                                        }
                                    }
                                }

                                if (evenOrOddArr.Count == 0)
                                {
                                    Console.WriteLine("[]");
                                }
                                else if (count >= evenOrOddArr.Count)
                                {
                                    Console.WriteLine($"[{string.Join(", ", evenOrOddArr)}]");
                                }
                                else
                                {
                                    Console.WriteLine($"[{string.Join(", ", evenOrOddArr.Take(count))}]");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid count");
                            }
                        }
                        break;
                    case "last":
                        {
                            count = int.Parse(command[1]);
                            bool isEven = command[2].Equals("even") ? true : false;
                            List<int> evenOrOddArr = new List<int>();

                            if (count >= 0 && count <= input.Length)
                            {
                                for (int i = 0; i < input.Length; i++)
                                {
                                    int num = int.Parse(input[i]);
                                    if (isEven)
                                    {
                                        if (num % 2 == 0)
                                        {
                                            evenOrOddArr.Add(num);
                                        }
                                    }
                                    else
                                    {
                                        if (num % 2 == 1)
                                        {
                                            evenOrOddArr.Add(num);
                                        }
                                    }
                                }

                                if (evenOrOddArr.Count == 0)
                                {
                                    Console.WriteLine("[]");
                                }
                                else if (count >= evenOrOddArr.Count)
                                {
                                    Console.WriteLine($"[{string.Join(", ", evenOrOddArr)}]");
                                }
                                else
                                {
                                    Console.WriteLine($"[{string.Join(", ", evenOrOddArr.Skip(evenOrOddArr.Count - count))}]");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid count");
                            }
                        }
                        break;
                    case "exchange":
                        {
                            int index = int.Parse(command[1]);
                            if (index >= 0 && index < input.Length)
                            {
                                string[] rightPart = input.Skip(index + 1).ToArray();
                                string[] leftPart = input.Take(index + 1).ToArray();
                                string[] concatinatedSArr = rightPart.Concat(leftPart).ToArray();

                                input = concatinatedSArr;
                            }
                            else
                            {
                                Console.WriteLine("Invalid index");
                            }
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split();
            }


            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}