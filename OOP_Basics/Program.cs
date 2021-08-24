using System;

namespace OOP_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
           Dog myDog = new Dog(); // myDog is initialized with name set as Tommy and age as 1. 
            myDog.Name = "Rocky"; // Overwriting the name Tommy with Rocky. If you comment this out then it will print Tommy. 
            Console.WriteLine(myDog.Name);
        }
    }
}
