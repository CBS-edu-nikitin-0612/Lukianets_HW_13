using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Converter
    {
        private readonly double _usdRate, _eurRate, _rubRate;
        public Converter(double usd, double eur, double rub)
        {
            _usdRate = usd;
            _eurRate = eur;
            _rubRate = rub;
        }

        public void Operation()
        {
            Console.WriteLine("Enter 1 or 2 to convert: \n\t1.TO hrv\n\t2.FROM hrn");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1-3 for currency: \n\t1.USD \n\t2.EUR \n\t3.RUB");
            int choice2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an amount");
            double amount = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (choice1)
            {
                case 1:
                    if (choice2 == 1) result = Math.Round(amount * _usdRate, 1);
                    if (choice2 == 2) result = Math.Round(amount * _eurRate, 1);
                    if (choice2 == 3) result = Math.Round(amount * _rubRate, 1);
                    Console.WriteLine($"You will get {result}");
                    break;
                case 2:
                    if (choice2 == 1) result = Math.Round(amount / _usdRate, 1);
                    if (choice2 == 2) result = Math.Round(amount / _eurRate, 1);
                    if (choice2 == 3) result = Math.Round(amount / _rubRate, 1);
                    Console.WriteLine($"You will get {result}");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            
        }
    }
}
