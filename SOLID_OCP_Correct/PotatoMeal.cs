using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_OCP_Correct
{
    class PotatoMeal : IMeal
    {
        public void Prepare()
        {
            Console.WriteLine("Prepared potatoes!");
        }
    }
}
