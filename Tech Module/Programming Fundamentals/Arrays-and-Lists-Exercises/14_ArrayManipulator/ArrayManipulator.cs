namespace _14_ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ArrayManipulator
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Split();
            List<int> nums = new List<int>();
            nums.AddRange(line.Select(int.Parse));

            while (line[0] != "print")
            {
                switch (line[0])
                {
                    case "add":
                        {
                            int index = int.Parse(line[1]);
                            int number = int.Parse(line[2]);
                            AddAt(nums, index, number);
                        }
                        break;
                    case "addMany":
                        addMany(nums, line);
                        break;
                    case "contains":
                        {
                            int element = int.Parse(line[1]);
                            Contains(nums, element);
                        }
                        break;
                    case "remove":
                        {
                            int index = int.Parse(line[1]);
                            RemoveAt(nums, index);
                        }
                        break;
                    case "shift":
                        {
                            int rotations = int.Parse(line[1]);
                            ShiftLeft(nums, rotations);
                        }
                        break;
                    case "sumPairs":
                        nums = SumPairs(nums);
                        break;
                }

                line = Console.ReadLine().Split();
            }

            Print(nums);
        }

        public static void AddAt(List<int> nums, int index, int num)
        {
            nums.Insert(index, num);
        }

        public static void RemoveAt(List<int> nums, int index)
        {
            nums.RemoveAt(index);
        }
        public static void Contains(List<int> nums, int element)
        {
            int containsElement = nums.IndexOf(element);
            Console.WriteLine(containsElement);
        }
        public static void Print(List<int> nums)
        {
            Console.WriteLine("[{0}]", string.Join(", ", nums));
        }
        private static void addMany(List<int> nums, string[] command)
        {
            int index = int.Parse(command[1]);
            if (index >= nums.Count)
            {
                for (int i = command.Length - 1; i >= 2; i--)
                {
                    int element = int.Parse(command[i]);
                    nums.Insert(index, element);
                }
            }
            else
            {
                nums.InsertRange(index, command.Skip(2).Select(int.Parse));
            }
        }

        public static List<int> SumPairs(List<int> list)
        {
            List<int> distinct = new List<int>();
            foreach (var item in list)
            {
                distinct.Add(item);
            }

            for (int i = 0; i < list.Count() / 2; i++)
            {
                distinct[i] = distinct[i] + distinct[i + 1];
                distinct.RemoveAt(i + 1);
            }

            list = distinct;
            return list;
        }
        public static void ShiftLeft(List<int> nums, int rotations)
        {
            //int rotations = int.Parse(line[1]);
            for (int i = 0; i < rotations; i++)
            {
                int firstElementIndex = 0;
                int firstElement = nums.First();

                nums.RemoveAt(firstElementIndex);
                nums.Add(firstElement);
            }
        }
    }
}
