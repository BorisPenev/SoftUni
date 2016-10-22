namespace _01.DayOfWeek
{
    using System;

    public class DayOfWeek
    {
        static void Main()
        {
            string[] weekDays = { "Invalid Day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber < 0 || dayNumber > weekDays.Length - 1)
            {
                Console.WriteLine(weekDays[0]);
            }
            else
            {
                Console.WriteLine(weekDays[dayNumber]);
            }
        }
    }
}
