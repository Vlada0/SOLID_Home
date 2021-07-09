using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_LIS_Wrong
{
    public class SeniorEmployee : Employee
    {
        public override string GetWorkDetails(int id)
        {
            return "Senior Work";
        }

        public override string GetEmployeeDetails(int id)
        {
            return "Senior Employee";
        }
    }
}
