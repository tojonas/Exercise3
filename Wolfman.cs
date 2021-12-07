using System;
using Exercise3.Animals;

namespace Exercise3
{
    public class Wolfman : Wolf, IPerson
    {
        public string WolfmanProperty { get;  }
        public void Talk()
        {
            Console.WriteLine($"Hello from {this.GetType().Name}");
        }
    }
}
