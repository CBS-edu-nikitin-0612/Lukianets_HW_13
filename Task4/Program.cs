using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice(123456, "Develompent Company X", "Global Staff Provider", "Find top specialist service", 5);
            Console.WriteLine(invoice1);
            Invoice.taxRate = 20;
            invoice1.CountSum();
        }
    }

}
