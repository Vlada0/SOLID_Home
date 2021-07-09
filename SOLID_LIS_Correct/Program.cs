using System;

namespace SOLID_LIS_Correct
{
    class Program
    {
        static void Main(string[] args)
        {
            JunEmployee jun = new JunEmployee();
            Console.WriteLine(jun.GetEmployeeDetails(9));
            SeniorEmployee senior = new SeniorEmployee();
            Console.WriteLine(senior.GetEmployeeDetails(7));
            Console.WriteLine(senior.GetWorkDetails(3));
        }
    }
}
