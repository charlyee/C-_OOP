using System;

namespace Polymorphism
{
    class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("[Insert Animal Sound]");
        }
    }

    class Pig : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Oink! Oink!");
        }
    }

    class Duck : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDuck = new Duck();

            myAnimal.sound();
            myPig.sound();
            myDuck.sound();
        }
    }
}
