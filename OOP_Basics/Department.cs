using Decomposition;
using System.Collections.Generic;

namespace OOP_Basics
{
    internal class Department
    {
        private string v;
        private List<Teacher> t;

        public Department(string v, List<Teacher> t)
        {
            this.v = v;
            this.t = t;
        }
    }
}