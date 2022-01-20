using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        internal class User
        {
            private string _login, _name, _secondName;
            private int _age;
            private DateTime _birthDate;
            private readonly DateTime _registrationDate;

            public User(string login, string name, string secondName, DateTime birthDate, DateTime registrationDate)
            {
                _login = login;
                _name = name;
                _secondName = secondName;
                _birthDate = birthDate;
                _age = registrationDate.Year - birthDate.Year;
                if (birthDate.Date > registrationDate.AddYears(-_age)) _age--;
                _registrationDate = registrationDate;
            }

            public override string ToString()
            {
                return $"User {_login}: {_name} {_secondName}, {_age} y.o., signed in {_registrationDate}";
            }
        }

        static void Main(string[] args)
        {
            User user1 = new User("Pug", "Vladimir", "Ivanov", new DateTime(1995, 11, 7), DateTime.Now);
            Console.WriteLine(user1);
            Console.ReadLine();
        }
    }
}
