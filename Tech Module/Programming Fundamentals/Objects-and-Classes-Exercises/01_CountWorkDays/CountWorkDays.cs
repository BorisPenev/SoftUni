namespace _01_CountWorkDays
{
    using System;
    using System.Globalization;

    public class CountWorkDays
    {
        static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            
            int workingDays = 0;

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (IsWorkingDate(date))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }

        public static bool IsWorkingDate(DateTime date)
        {
            bool isWorkingDate = true;

            string dateAsString = String.Format("{0}.{1}", date.Day, date.Month);

            if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
            {
                switch (dateAsString)
                {
                    case "1.1":isWorkingDate = false; break;
                    case "3.3":isWorkingDate = false; break;
                    case "1.5":isWorkingDate = false; break;
                    case "6.5":isWorkingDate = false; break;
                    case "24.5":isWorkingDate = false; break;
                    case "6.9":isWorkingDate = false; break;
                    case "22.9":isWorkingDate = false; break;
                    case "1.11":isWorkingDate = false; break;
                    case "24.12":isWorkingDate = false; break;
                    case "25.12":isWorkingDate = false; break;
                    case "26.12":isWorkingDate = false; break;
                    default: isWorkingDate = true;
                        break;
                }
            }
            else
            {
                isWorkingDate = false;
            }

            return isWorkingDate;
        }
    }
}
