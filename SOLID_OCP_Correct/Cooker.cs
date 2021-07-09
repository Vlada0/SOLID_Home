using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_OCP_Correct
{
    class Cooker
    {
        public string Name { get; set; }

        public Cooker(string name)
        {
            this.Name = name;
        }

        public void PrepareSomething(IMeal meal)
        {
            meal.Prepare();
        }
    }
}
