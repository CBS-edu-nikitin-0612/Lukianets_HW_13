namespace Task3
{
    internal class Position
    {
        private string _name;
        private int _salary;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "Junior")
                    _salary = 700;
                if (value == "Middle")
                    _salary = 2000;
                if (value == "Senior")
                    _salary = 4000;
                _name = value;
            }
        }

        public int Salary
        {
            get { return _salary; }
        }

        public Position(string position)
        {
            Name = position;
        }
    }
}
