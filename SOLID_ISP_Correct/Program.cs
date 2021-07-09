using System;

namespace SOLID_ISP_Correct
{
    class Program
    {
        static void Main(string[] args)
        {
            JunEmployee jun = new JunEmployee();
            jun.AddDetailsEmployee();
            SeniorEmployee senior = new SeniorEmployee();
            senior.AddDetailsEmployee();
            senior.ShowDetailsEmployee(1);
        }
    }
}
