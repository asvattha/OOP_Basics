using System;
using System.Collections.Generic;
using System.Text;

namespace Decomposition
{
    class Creature
    {
        string name;
        Point location;

        /* You may ask they why do we have to create another class called Point, why can't we simply make x and y as members of the Creature class
         * like the following:
         * class Creature {
         *  string name;
         *  int x;
         *  int y;
         *  }
         *  
         *  The following is the reason:
         *  1. It is always good to let a class only focus on achieving one task. In this problem, we considered that Creature class is going to be 
         *  responsible for moving on a screen. Therefore, the creature would only focus on it, and won't worry about how those points are represented
         *  for eg: in 3D or in polar cordinates. This reduces the complexity of the problem and help to debug or add more functionality in future, increasing
         *  extensibility of the program. Such property is also called cohesion. We always try to achieve high cohesion. 
         *  
         *  2. Also, by decomposing the problem we achieve separation of concerns. For eg: in walmart, we have separate section for vegetables, and 
         *  for electronic items etc. This increases code managebility. 
         *  
         *  3. Also, we can delegate a task to the smaller task. For eg: since the points x and y belong to Point object, it is good idea to let 
         *  Point object have a behavior to set the points x and y to newer x and newer y. That way, Creature delegate the task of moving to a new loation
         *  to the Point class. This property is called coupling. By doing so, we decoupled the strong dependency of the members of Point x and y in the Creature
         *  class to just the Point class. We always aspire for low coupling in our program.
         */

        public Creature(string name)
        {
            location = new Point();
            this.name = name;
        }

        public void moveTo(int x, int y)
        {
            location.setPoint(x, y);
        }
    }
}