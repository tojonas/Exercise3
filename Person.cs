namespace Exercise3
{
    public class Person
    {
        uint _age;
        string _fName;
        string _lName;
        float _height;
        float _weight;
        // Private fields not accessible outside this class
        public uint Age 
        { 
            get { return _age; }
            set
            {
                _age = Ensure.Greater<uint>(value, 0);
            } 
        }
        public string FirstName
        {
            get { return _fName; }
            set
            {
                _fName = Ensure.Length(value, 2, 10);
            }
        }
        public string LastName
        {
            get { return _lName; }
            set
            {
                Ensure.NotNullOrWhitespace(value);
                _lName = Ensure.Length(value, 3, 15);
            }
        }
        public float Height 
        { 
            get { return _height; } 
            set
            {
                _height = Ensure.Greater(value, 0);
            }
        }
        public float Weight
        {
            get { return _weight; }
            set
            {
                _weight = Ensure.Greater(value, 0);
            }
        }

    }
}
