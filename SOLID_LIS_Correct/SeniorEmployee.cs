using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_LIS_Correct
{
    public class SeniorEmployee : IWork, IEmployee
    {
        public string GetWorkDetails(int employeeId)
        {
            return "Senior Work";
        }

        public string GetEmployeeDetails(int employeeId)
        {
            return "Senior Employee";
        }
    }
}
