using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    class Test
    {
        public string Name { get; set; }
        private static int counter = 0; 

        public Test(string name)
        {
            counter++;
            Name = name;
        }

        public override string ToString()
        {
            return Name + " no " + counter;
        }
    }
}
