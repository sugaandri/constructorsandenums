using System;

namespace ConstructorsAndEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog kruudi = new Dog();
            kruudi.name = "Kruudi";
            kruudi.age = 2;
            kruudi.levelOfHappiness = 1;
            kruudi.PrintBasicInfo();

            for(int i=0; i<13; i++) 
            {
                kruudi.MoveTail();

                if (kruudi.levelOfHappiness % 3 == 0) 
                {
                    kruudi.Bark();
                }
                else { }
            }

            Console.WriteLine($"Your dog barked {kruudi.numberOfBarks} times and his level of happiness is {kruudi.levelOfHappiness}");



        }
    }

    class Animal 
    {
        public string name;
        public int age;
        public int levelOfHappiness;

        public void PrintBasicInfo() 
        {
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Level of happiness: {levelOfHappiness}");

        }

    }

    class Dog : Animal 
    {
        public int numberOfBarks = 0;

        public void MoveTail() 
        {
            levelOfHappiness++;
        }

        public void Bark() 
        {
            Console.WriteLine("Woof");
            numberOfBarks++;
        }
    }
}
