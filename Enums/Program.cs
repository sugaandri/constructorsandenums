using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog sass = new Dog("Sass", 10, Breed.Bulldog);
            Dog kruudi = new Dog("Kruudi", 2, Breed.Taxi);
            sass.PrintDogInfo();
            kruudi.PrintDogInfo();
            Console.WriteLine($"You have created {Dog.Count} dogs");
            Console.WriteLine($"Number of boxer is:{ (int)Breed.Boxer}");


        }
    }

    class Dog 
    {
        public static int Count = 0;
        public string name;
        public int age;
        public Breed breed;
        

        public Dog(string _name, int _age, Breed _breed) 
        {
            name = _name;
            age = _age;
            breed = _breed;

            Count++;

        }

        public void PrintDogInfo() 
        {
            Console.WriteLine($"Name: {name}. Age: {age}. Breed:{breed}");
        
        }


    }

    enum Breed 
    {
        Bulldog,
        Boxer,
        Chihuahua,
        Taxi
    }


}
