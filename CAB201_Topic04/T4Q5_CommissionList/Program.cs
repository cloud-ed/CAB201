using System;
using System.Collections.Generic;

namespace CommissionList
{
    public class Program
    {
        static void Main()
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here.
            Console.WriteLine("Number of sales:");
            int salesNr = int.Parse(Console.ReadLine());
            var sales = new List<int>();
            for (int i = 0; i < salesNr; i++)
            {
                Console.WriteLine("Sale value:");
                sales.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Your commissions:");

            // Check inputted values and display sale and commission
            double commission;
            double totalCommission = 0;
            foreach (int i in sales)
            {
                if (i > 24000) { commission = 0.1; }
                else if (i > 15000 && i <= 24000) { commission = 0.07; }
                else { commission = 0.05; }
                commission *= i;
                totalCommission += commission;
                string saleCurrency = i.ToString("C");
                string commissionCurrency = commission.ToString("C");
                Console.WriteLine($"Commission on sale {saleCurrency} = {commissionCurrency}");
            }

            // Print final commission
            Console.WriteLine($"Total commission = {totalCommission.ToString("C")}");

            // Keep the following line intact
            Console.WriteLine("===========================");
        }
    }
}