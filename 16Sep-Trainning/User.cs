using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Sep_Trainning
{
    internal class User
    {
        string name;
        int id;
        public User(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public User()
        {

        }
        public override string ToString()
        {
            return name + " " + id;
        }
    }
}
