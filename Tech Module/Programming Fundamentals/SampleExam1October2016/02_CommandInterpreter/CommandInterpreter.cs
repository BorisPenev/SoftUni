namespace _02_CommandInterpreter
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;

    public class CommandInterpreter
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string[] command = Console.ReadLine().Split();
            int start = 0;
            int count = 0;
            int rotationsCount = 0;
            byte commandsCount = 1;
            while (!command[0].Equals("end") && commandsCount <= 20)
            {
                switch (command[0])
                {
                    case "reverse":
                        {
                            start = int.Parse(command[2]);
                            count = int.Parse(command[4]);

                            Reverse(input, start, count);
                        }
                        break;
                    case "sort":
                        {
                            start = int.Parse(command[2]);
                            count = int.Parse(command[4]);
                            Sort(input, start, count);
                        }
                        break;
                    case "rollLeft":
                        {
                            rotationsCount = int.Parse(command[1]);
                            if (rotationsCount > 0)
                            {
                                List<string> dummyList = new List<string>(input);

                                for (int i = 0; i < rotationsCount; i++)
                                {
                                    string element = dummyList.First();
                                    dummyList.RemoveAt(0);
                                    dummyList.Add(element);
                                    //string lastElement = dummyList.Last();
                                    //string previousElement;

                                    //input[input.Length - 1] = element;
                                    //input[0] = input[1];

                                    //for (int j = input.Length - 2; j > 0; j--)
                                    //{
                                    //    previousElement = input[j];
                                    //    input[j] = lastElement;
                                    //    lastElement = previousElement;
                                    //}

                                    //for (int j = 1; j <= input.Length - 1; j++)
                                    //{
                                    //    input[j - 1] = input[j];
                                    //}
                                    //input[input.Length - 1] = element;
                                }

                                input = dummyList.ToArray();
                            }
                            else
                            {
                                Console.WriteLine("Invalid input parameters.");
                            }
                        }
                        break;
                    case "rollRight":
                        {
                            rotationsCount = int.Parse(command[1]);
                            if (rotationsCount > 0)
                            {
                                for (int i = 0; i < rotationsCount; i++)
                                {
                                    string firstelement = input.First();
                                    string element = input.Last();
                                    string nextElement;

                                    input[input.Length - 1] = firstelement;
                                    input[0] = element;

                                    for (int j = 1; j < input.Length; j++)
                                    {
                                        nextElement = input[j];
                                        input[j] = firstelement;
                                        firstelement = nextElement;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input parameters.");
                            }
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split();
                commandsCount++;
            }


            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        public static void Sort(string[] nums, int start, int count)
        {
            if (IsValidInput(nums, start, count))
            {

                List<string> currentList = nums
                    .Skip(start)
                    .Take(count)
                    .OrderBy(str => str)
                    .ToList();

                for (int i = 0; i < count; i++)
                {
                    nums[start + i] = currentList[i];
                }
                //nums.RemoveRange(start, count);
                //nums.InsertRange(start, currentList);
            }
        }
        public static void Reverse(string[] nums, int start, int count)
        {
            if (IsValidInput(nums, start, count))
            {
                List<string> currentList = nums
                    .Skip(start)
                    .Take(count)
                    .Reverse()
                    .ToList();

                for (int i = 0; i < count; i++)
                {
                    nums[start + i] = currentList[i];
                }
                //nums.RemoveRange(start, count);
                //nums.InsertRange(start, currentList);
            }
        }

        public static bool IsValidInput(string[] nums, int start, int count)
        {
            bool isValid = false;

            if (start < 0
                || start >= nums.Length
                || count < 0
                || (start + count) > nums.Length)
            {

                Console.WriteLine("Invalid input parameters.");
                isValid = false;
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }

    }
}
