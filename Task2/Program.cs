using System;

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
