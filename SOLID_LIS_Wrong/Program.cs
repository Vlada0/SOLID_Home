using System;
using System.Collections.Generic;

namespace SOLID_LIS_Wrong
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            list.Add(new JunEmployee());
            list.Add(new SeniorEmployee());

            foreach (Employee emp in list)
            {
                emp.GetWorkDetails(9);
            }
        }
    }
}
