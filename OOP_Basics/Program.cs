using System;

namespace OOP_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
           Dog myDog = new Dog("Rocky", 2); // myDog is initialized with name set as Tommy and age as 1. 
            myDog.Name = "Rocky"; // Overwriting the name Tommy with Rocky. If you comment this out then it will print Tommy. 
            Console.WriteLine(myDog.Name);

            Dog.owner = "Robin"; // since owner is static, it can be directly accssed with class name.
            float dogWeightinKg = Dog.weightsInKg(); // since the method is static, it can be called with class name

            Dog newDog = new Dog("Sam", 3);
            myDog.isEquals(newDog);
            Console.WriteLine(newDog.Name); // it will print Max instead of Sam, since we changed the name from Sam to Max when isEquals was called.
            // as newDog was passed by reference to the isEquals
        }
    }
}
