namespace _01.HelloName
{
    using System;

    public class HelloName
    {
        static void Main()
        {
            string name = Console.ReadLine();
            Greetings(name);
        }

        public static void Greetings(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
