using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, string> addressBook = new Dictionary<string, string>();
            while (input[0] != "END")
            {

                if (input[0].Equals("A"))
                {
                    if (!addressBook.ContainsKey(input[1]))
                    {
                        addressBook.Add(input[1], input[2]);
                    }
                    else
                    {
                        addressBook[input[1]] = input[2];
                    }
                }
                else if (input[0].Equals("S"))
                {
                    if (addressBook.ContainsKey(input[1]))
                    {
                        Console.WriteLine("{0} -> {1}", input[1], addressBook[input[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", input[1]);
                    }
                }
                else if (input[0].Equals("ListAll"))
                {
                    ListAllContacts(addressBook);
                }

                input = Console.ReadLine().Split(' ').ToList();
            }
        }

        public static void ListAllContacts(Dictionary<string, string> dict)
        {
            SortedDictionary<string, string> sortedList = new SortedDictionary<string, string>(dict);

            foreach (var item in sortedList)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
