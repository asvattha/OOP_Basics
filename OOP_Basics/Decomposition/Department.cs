using System;
using System.Collections.Generic;
using System.Text;

namespace Decomposition
{
    class Department
    {
        List<Teacher> teachers;
        string name;

        public Department(string name, List<Teacher> t)
        {
            teachers = t; // usually the smaller part are initialized by the argument passed to the constructor or any method to the bigger class
            /* Here the teachers is initialized with the t passed to the Department. 
             * Also, it is important to note that, the List t or any object is passed as reference and not by value. Therefore, if you make any change
             * to t attributes, then every teacher object that refers to t will be changed.
             */
            this.name = name;
        }
    }
}
