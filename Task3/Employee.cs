using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Employee
    {
        private string _name, _secondName;

        private Position _position;

        private int _seniorityYears;

        public readonly double _taxRate = 0.2;

        public string PositionName
        {
            get { return _position.Name; }
            set { _position = new Position(value); }
        }

        public Employee(string name, string secondName)
        {
            _name = name;
            _secondName = secondName;
        }

        public Employee(string name, string secondName, string position) : this(name, secondName)
        {
            PositionName = position;  
        }

        public Employee(string name, string secondName, string position, int seniorityYears) : this(name, secondName, position)
        {
            _seniorityYears = seniorityYears;
        }

        public double Salary()
        {
            // imaginary formula)
            return Math.Round((_position.Salary + (_position.Salary * Math.Pow(_seniorityYears, 3) / 100)) * (1 - _taxRate)
                , 2);
        }

        public override string ToString()
        {
            return $"{_name} {_secondName}, position: {_position.Name}, salary after tax: {Salary()}";
        }
    }
}
