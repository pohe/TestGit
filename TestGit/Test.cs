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

        public Test(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
