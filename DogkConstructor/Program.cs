using System;

namespace DogkConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog sass = new Dog("Sass", "black", "bulldog");
            sass.PrintInfo();

            Console.WriteLine($"{Animal.Count} animal has been created");
            Console.ReadLine();
        }
        
    }

    class Animal
    {
        public string name;
        public string color;
        public static int Count = 0;


        public void PrintInfo() 
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {color}");

        }
    }

    class Dog : Animal 
    {
        public string breed;

        public Dog(string _name, string _color, string _breed) 
        {
            name = _name;
            color = _color;
            breed = _breed;

            Count++;

        }

        public void PrintInfo() 
        {
            Console.WriteLine($"Dog name: {name}");
            Console.WriteLine($"Dog color: {color}");
            Console.WriteLine($"Dog breed: {breed}");

        }
    }
}
