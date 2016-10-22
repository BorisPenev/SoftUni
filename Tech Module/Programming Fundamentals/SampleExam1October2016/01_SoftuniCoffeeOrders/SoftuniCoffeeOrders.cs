namespace _01_SoftuniCoffeeOrders
{
    using System;
    using System.Globalization;

    public class SoftuniCoffeeOrders
    {
        static void Main()
        {
            int orderCount = int.Parse(Console.ReadLine());
            decimal totalPrice = 0M;
                
                            
            for (int i = 0; i < orderCount; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                uint capsulesCount = uint.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                decimal orderTotal = ((daysInMonth * capsulesCount) * pricePerCapsule);
                totalPrice += orderTotal;
                Console.WriteLine("The price for the coffee is: ${0:f2}", Math.Round(orderTotal, 2));
            }

            Console.WriteLine("Total: ${0:f2}", Math.Round(totalPrice, 2));
        }
    }
}
