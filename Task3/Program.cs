using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Valeriy", "Lebedev", "Middle", 2);
            Employee employee2 = new Employee("Olga", "Vetrova", "Middle", 1);
            Employee employee3 = new Employee("Denys", "Fedorychev", "Senior", 4);
            Employee employee4 = new Employee("Alexandra", "Ivanova", "Junior", 1);
            Console.WriteLine(employee1);
            Console.WriteLine(employee2);
            Console.WriteLine(employee3);
            Console.WriteLine(employee4);
        }
    }
}
