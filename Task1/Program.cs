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

            public string Login
            {
                get { return _login; }
                set
                {
                    if (value != null)
                        _login = value;
                    else
                        Console.WriteLine("Wrong login");
                }
            }

            public string Name
            {
                get { return _name; }
                set
                {
                    if (value != null)
                        _name = value;
                    else
                        Console.WriteLine("Wrong input");
                }
            }

            public string SecondName
            {
                get { return _secondName; }
                set
                {
                    if (value != null)
                        _secondName = value;
                    else
                        Console.WriteLine("Wrong input");
                }
            }

            public int Age => _age;

            public User(string login, string name, string secondName, DateTime birthDate, DateTime registrationDate)
            {
                Login = login;
                Name = name;
                SecondName = secondName;
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
