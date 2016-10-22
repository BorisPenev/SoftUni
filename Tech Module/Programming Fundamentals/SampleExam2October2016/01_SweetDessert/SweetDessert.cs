namespace _01_SweetDessert
{
    using System;

    public class SweetDessert
    {
        static void Main()
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            uint numberOfGuests = uint.Parse(Console.ReadLine());
            decimal priceOfBananasPerUnit = decimal.Parse(Console.ReadLine());
            decimal priceOfEggsPerUnit = decimal.Parse(Console.ReadLine());
            decimal priceOfBerriesPerKilogram = decimal.Parse(Console.ReadLine());
            string message = "";

            int setsCount = (int)Math.Ceiling((decimal)numberOfGuests / 6);
            decimal cashNeededForSingleBatch = 2.0M * priceOfBananasPerUnit + 4.0M * priceOfEggsPerUnit + 0.2M * priceOfBerriesPerKilogram;
            decimal totalNeededCash = setsCount * cashNeededForSingleBatch;

            if (cash < totalNeededCash)
            {
                message = $"Ivancho will have to withdraw money - he will need {totalNeededCash - cash:f2}lv more.";
            }
            else
            {
                message = $"Ivancho has enough money - it would cost {totalNeededCash:f2}lv.";
            }

            Console.WriteLine(message);
        }
    }
}
