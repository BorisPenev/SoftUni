namespace _07_SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SalesReport
    {
        static void Main()
        {
            int numberOfSales = int.Parse(Console.ReadLine());
            List<Sale> sales = new List<Sale>();

            for (int i = 0; i < numberOfSales; i++)
            {
                List<string> sale = Console.ReadLine().Split(' ').ToList();

                sales.Add(new Sale()
                {
                    Town = sale[0],
                    Product = sale[1],
                    Price = double.Parse(sale[2]),
                    Quantity = double.Parse(sale[3])
                });
            }

            PrintTotal(Sale.GetTotalSalesByTown(sales));
        }
        public static void PrintTotal(SortedDictionary<string, double> sortedTotalSalesByTown)
        {
            foreach (var item in sortedTotalSalesByTown)
            {
                Console.WriteLine("{0} -> {1:0.00}", item.Key, Math.Round(item.Value, 2));
            }
        }

    }

    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public static SortedDictionary<string,double> GetTotalSalesByTown(List<Sale> sales)
        {
            SortedDictionary<string, double> totalSalesPerTown = new SortedDictionary<string, double>();

            foreach (var sale in sales)
            {
                if (!totalSalesPerTown.ContainsKey(sale.Town))
                {
                    totalSalesPerTown.Add(sale.Town, sale.Price * sale.Quantity);
                }
                else
                {
                    totalSalesPerTown[sale.Town] += (sale.Price * sale.Quantity);
                }
            }

            return totalSalesPerTown;
        }
    }
}
