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
                _age = Ensure.Greater<uint>(value, 0, nameof(Age));
            } 
        }
        public string FirstName
        {
            get { return _fName; }
            set
            {
                _fName = Ensure.Length(value, 2, 10, nameof(FirstName));
            }
        }
        public string LastName
        {
            get { return _lName; }
            set
            {
                Ensure.NotNullOrWhitespace(value, nameof(LastName));
                _lName = Ensure.Length(value, 3, 15, nameof(LastName));
            }
        }
        public float Height 
        { 
            get { return _height; } 
            set
            {
                _height = Ensure.Greater(value, 0, nameof(Height));
            }
        }
        public float Weight
        {
            get { return _weight; }
            set
            {
                _weight = Ensure.Greater(value, 0, nameof(Weight));
            }
        }

    }
}
