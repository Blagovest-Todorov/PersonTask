﻿using System;

namespace DefiningClasses
{
    public class StartUp
    {
       public static void Main(string[] args)
       {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                //that reads the names and ages of N people 
                string[] personData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = personData[0];
                int age = int.Parse(personData[1]);

                Person currPerson = new Person(name, age);
                // Members.Add(currPerson);
                family.AddMembers(currPerson);                
            }

            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");

        }
    }
}
