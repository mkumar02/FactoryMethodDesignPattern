using System;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is Factory Method Design Pattern example");

            IAnimal animal = new DogFactory().GetAnimal();
            Console.WriteLine("\nWhen animal object is an instance of DogFactory");
            Console.WriteLine(animal.Sound());

            animal = new CatFactory().GetAnimal();
            Console.WriteLine("\nSame animal object is now an instance of CatFactory");
            Console.WriteLine(animal.Sound());
        }
    }
}
