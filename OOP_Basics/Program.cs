using Decomposition;
using System;
using System.Collections.Generic;

namespace OOP_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Composition Example
            // For this example, look for the Creature and Point class

            Creature c = new Creature("dinasaur");
            c.moveTo(10, 10);
            /* When you create the c object, then the c object would call the constructor of its class, and the constructor will
            create the location object (which is of Point type). As a result, the location object is a part or attribute of the 
            c object, also location object only belongs to c object, also when c object dies then location object also dies, and
            location has no information about other members of the c object. Hence, by creating the location object inside the 
            c object we can construct composition relationship.

            Note: you should not do the following:
            Point newLocation = new Point(); // as in this case, the Point object is existing independent of the Creature object, 
            which breaks the composition rule.

            Similarly, you should not construct or pass Creature object to the Point object, as doing so, means the Point can 
            access the other public members of the Creature object, which also breaks the composition rule, that the smaller
            object has no knowledge about the existence bigger object.
            */


            // Aggregation Example

            Teacher t1 = new Teacher();
            Teacher t2 = new Teacher();

            List<Teacher> t = new List<Teacher>();
            t.Add(t1);
            t.Add(t2);

            {
                Department d = new Department("CSC", t);
                // Since the scope of the variable d is only within this curly block, it dies outside this block
            }

            // Even though department object is inaccessible here, the teacher object still exists. Fulfilling the aggregation property
            Console.WriteLine(t1.Name);


            // Association Example

            Wine w = new Wine();
            Food f = new Food();

            f.eatWith(w);
            // Here although, food and wine are not related otherwise, but food can use wine for dinner

            // Also, if wine also uses food then the relationship will be bidirectional and can pass the food object to the wine object.
            w.drinkWith(f);

            // Also, in association, the object can be shared with multiple object, which means, The same wine w object can be used with some other 
            // object let's say, in party p object or even with other Food object say f1. Assume, you have another class called Party
            Party p = new Party();
            p.drink(w); // so w is shared with Food as well as Party class
            Food f1 = new Food();
            f1.eatWith(w);
            // Also, as you can notice, since the Wine w is passed to food in the method eatWith, therefore, food can access all the public 
            // members of Wine class using w object. Hence, the part has some knowledge of the other object it is associated with

            // This concludes the discussion on Decomposition

        }
    }
}
