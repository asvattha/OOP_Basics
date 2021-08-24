using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Basics
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; }

        public Dog()
        {
            Name = "Tommy";
            Age = 1;
        }

        private void bark()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
