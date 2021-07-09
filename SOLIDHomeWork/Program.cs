using SOLID_OCP_Wrong;
using System;

namespace SOLIDHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Cooker cooker = new Cooker("Some cook");
            cooker.PrepareSomething();
        }
    }
}
