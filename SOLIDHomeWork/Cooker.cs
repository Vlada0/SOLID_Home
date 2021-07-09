using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_OCP_Wrong
{
    class Cooker
    {
        public string Name { get; set; }
        public Cooker(string name)
        {
            this.Name = name;
        }

        public void PrepareSomething()
        {
            Console.WriteLine("Prepared something!");
        }
    }
}
