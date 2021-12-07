using System;
using System.Collections.Generic;
using Exercise3.Animals;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var person = new Person()
                {
                    Age = 52,
                    FirstName = "Jonas",
                    LastName = "Nilsson",
                    Height = 178,
                    Weight = 80
                };

                var person2 = new Person()
                {
                    Age = 52,
                    FirstName = "Jonas",
                    LastName = "Ni",
                    Height = 178,
                    Weight = 80
                };
            }
            catch( ArgumentException x )
            {
                Console.WriteLine(x.Message);
            }
            // Create Persons using PersonHandler
            try
            {
                var person = PersonHandler.CreatePerson(52, "Jonas", "Nilsson", 178, 80);
                PersonHandler.SetAge(person, 53);
            }
            catch( ArgumentNullException x )
            {
                Console.WriteLine(x.Message);
            }

            // Create Animals
            List<Animal> animals = new List<Animal>()
            {
                new Bird(),
                new Dog(),
                new Hedgehog(),
                new Horse(),
                new Wolf(),
                new Worm(),

                new Wolfman() // Wolfman will sound like a Wolf but can talk using IPeron.Talk()
            };
            foreach (var animal in animals)
            {
                if (animal is IPerson)
                {
                    (animal as IPerson).Talk();
                }
                else
                {
                    animal.DoSound();
                }
            }
            //13.F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
            // S: I Bird klassen

            //14.F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
            // S: I Animal klassen

            animals.ForEach(a => a.Stats());

            //
            var errors = new List<UserError>() { new TextInputError(), new TextInputError(), new NumericInputError() };
            errors.ForEach(e => Console.WriteLine(e.UEMessage()) );
        }
    }
}
