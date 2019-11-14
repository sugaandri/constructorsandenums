using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace tasklist
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Demo\tasklist.txt";
            List<string> taskList = File.ReadAllLines(filePath).ToList();
            List<Task> listOfTask = new List<Task>();
            int i = 0;

            foreach (string description in taskList) 
            {
                string[] tempArray = description;
            }

            foreach (Task task in listOfTask) 
            {
                i++;
                Console.WriteLine($"Task {i} on your list is to {task}");
            }

        }
    }

    class Task 
    {
        public string description;
    }
}
