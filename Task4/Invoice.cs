using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Invoice
    {
        private readonly int _accountId;
        private readonly string _customer, _provider;
        private string _article;
        private int _quantity;

        private double _finalSum, _finalSumInclTax;

        private const int _servicePrice = 700;
        //Tax Rate (0; 100)
        public static double taxRate;

        public int AccountId => _accountId;
        public string Customer => _customer;
        public string Provider => _provider;

        public string Article
        {
            get => _article;
            set
            {
                if (value != null)
                    _article = value;
                else
                    Console.WriteLine("Wrong decription");
            }
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value > 0)
                    _quantity = value;
                else
                    Console.WriteLine("Wrong quantity");
            }
        }

        public Invoice(int accountId, string customer, string provider, string article, int quantity)
        {
            if (accountId > 0)
                _accountId = accountId;
            else
                Console.WriteLine("Wrong account data");

            if (customer != null)
                _customer = customer;
            else
                Console.WriteLine("Wrong customer's data");

            if (provider != null)
                _provider = provider;
            else
                Console.WriteLine("Wrong provider's data");

            Article = article;
            Quantity = quantity;
        }
        public void CountSum()
        { 
            _finalSum = _quantity * _servicePrice;
            _finalSumInclTax = _finalSum + Math.Round(_finalSum * taxRate / 100, 2);
            Console.WriteLine($"Sum: {_finalSum}; sum incl TAX: {_finalSumInclTax}");
        }

        public override string ToString()
        {
            return $"Invoice data\n" +
                $"\tBill to\t\t: {_provider}, account {_accountId}\n" +
                $"\tFrom\t\t: {_customer}\n" +
                $"\tSum initial\t: {_quantity}\n" +
                $"\tSum with tax\t: {_quantity}\n" +
                $"\tDescription\t: {_article}";
        }

    }
}
