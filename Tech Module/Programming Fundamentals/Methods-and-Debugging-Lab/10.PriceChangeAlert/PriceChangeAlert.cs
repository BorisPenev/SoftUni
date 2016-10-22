using System;

namespace _10.PriceChangeAlert
{
    class PriceChangeAlert
    {
        static void Main(string[] args)
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double priceTreshold = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double minorPriceDifference = GetPriceDifference(lastPrice, currentPrice);
                bool isSignificantDifference = IsThereADifference(minorPriceDifference, priceTreshold);
                string message = GetPriceStatus(currentPrice, lastPrice, minorPriceDifference, isSignificantDifference);
                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        private static string GetPriceStatus(double currentPrice, double lastPrice, double difference, bool hasSignificantDifference)
        {
            string statusMessage = "";

            if (difference == 0)
            {
                statusMessage = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!hasSignificantDifference)
            {
                statusMessage = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (hasSignificantDifference && (difference > 0))
            {
                statusMessage = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (hasSignificantDifference && (difference < 0))
            {
                statusMessage = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }

            return statusMessage;
        }
        private static bool IsThereADifference(double minorPriceDifference, double priceTreshold)
        {
            if (Math.Abs(minorPriceDifference) >= priceTreshold)
            {
                return true;
            }
            return false;
        }

        private static double GetPriceDifference(double lastPrice, double currentPrice)
        {
            double result = (currentPrice - lastPrice) / lastPrice;
            return result;
        }
    }
}