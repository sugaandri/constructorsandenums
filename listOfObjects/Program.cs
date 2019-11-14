using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace listOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\demo\people.txt";
            List<string> listOfPeople = File.ReadAllLines(filePath).ToList();
            List<Person> listOfPeopleObjects = new List<Person>();

            foreach (string line in listOfPeople)
            {
                string[] tempArray = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Person newPerson = new Person(tempArray[0], tempArray[1], int.Parse(tempArray[2]));

                listOfPeopleObjects.Add(newPerson);
            }

            foreach (Person person in listOfPeopleObjects)
            {
                Console.WriteLine($"Person: {person.firstName} {person.lastName} is {person.age} years old.");
            }

        }
    }

    class Person
    {
        public string firstName;
        public string lastName;
        public int age;

        public static int Count = 0;

        public Person(string _firstName, string _lastName, int _age) 
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;

            Count++;
        }

    }
}
