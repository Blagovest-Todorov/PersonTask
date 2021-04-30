using System;

namespace DefiningClasses
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            Person personOne = new Person();
            personOne.Name = "Peer";
            personOne.Age = 20;

            Person personTwo = new Person() 
            {
                Name = "Kris",
                Age = 22 
            };

        }
    }
}
