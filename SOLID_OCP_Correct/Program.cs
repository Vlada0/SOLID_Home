using System;

namespace SOLID_OCP_Correct
{
    class Program
    {
        static void Main(string[] args)
        {
            Cooker tom = new Cooker("Tom");
            tom.PrepareSomething(new PotatoMeal());
            Console.WriteLine();
            tom.PrepareSomething(new SaladMeal());
        }
    }
}
