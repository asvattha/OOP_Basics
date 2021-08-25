using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Basics
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; }

        public static string owner; // because it is public it can be accesed outside

        private static double weight; // because this static variable is private, we would need a public static method to access it.

        public Dog()
        {
            Name = "Tommy";
            Age = 1;
        }

        // parameterized constructor
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public static double weightsInKg()
        {
            return weight * 0.45; // returning weights in kilograms
        }

        private void bark()
        {
            Console.WriteLine("Woof Woof");
        }

        public bool isEquals(Dog d) // passing object by reference;
        {
            d.Name = "Max"; // changing the attribute of the object would reflect everywhere the object is used, as d is also referencing to the 
            // same object as it is passed by reference.
            if(this.Name == d.Name && this.Age == d.Age)
                return true;
            return false;
        }
    }
}
