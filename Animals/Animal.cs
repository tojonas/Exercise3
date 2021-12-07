using System;

namespace Exercise3.Animals
{
    public abstract class Animal
    {
        public uint Age { get; set; }
        protected string Sound { get; }

        protected Animal( string sound )
        {
            Sound = sound;
        }
        public virtual void DoSound()
        {
            Console.WriteLine($"{GetType()} sound {Sound}");
        }

        public virtual void Stats()
        {
            Console.WriteLine($"Properties of {GetType().Name}:");
            foreach ( var prop in GetType().GetProperties() )
            {
                Console.WriteLine($"   {prop.Name}"); 
            }
            Console.WriteLine("\n");
        }
    }
}
