using System;
using System.Collections.Generic;   // to be able to use lists

namespace Polymorphie
{
    abstract class Mammal
    {                
        public virtual void Sound()
        {
            Console.WriteLine("The mammal (lion) roars.");
        }
    }

    class Hyena : Mammal
    {
        public override void Sound() // this method overrides the method "Sound()"in the base class
        {
            Console.WriteLine("The heyna laughs.");
        }
    }

    class Lion : Mammal
    {
        public new void Sound() // the keyword "new" doesn`t allow poylmorph
                                // the base class is called instead --> method "Sound()" --> "The mammal (lion) roars."
        {
            Console.WriteLine("The lion roars.");
        }
    }

    class Horse : Mammal
    {
        public override void Sound()
        {
            Console.WriteLine("The horse neighs.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Mammal heyna = new Hyena();
            heyna.Sound();  // here the method of the derived class is called

            Mammal lion = new Lion();
            lion.Sound();   // here the method of the derived class is called

            Mammal horse = new Horse();
            horse.Sound();  // here the method of the derived class is called

            Console.WriteLine("\n--------------------------\n");
            Console.WriteLine("All animals use the same methode.\n");

            List<Mammal> mammals = new List<Mammal> // create a list of all animals
            {
                heyna,
                lion,
                horse
            };

            foreach (Mammal mammal in mammals)
            {
                mammal.Sound();
            }


            // At runtime it should be decided which method will be called.
            // This is called dynamic polymorphism.
            Console.WriteLine("Choose an animal: h for heyna, l for lion, p for horse");
            char input = Convert.ToChar(Console.ReadLine());

            switch (input)
            {
                case 'h':
                    heyna.Sound();
                    break;
                case 'l':
                    lion.Sound();
                    break;
                case 'p':
                    horse.Sound();
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }

            Console.ReadLine();            
        }
    }
    
   
}
