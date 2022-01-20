using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter dailyConverter = new Converter(28.3, 32.1, 0.37);
            dailyConverter.Operation();

            Console.ReadLine();
        }
    }
}
