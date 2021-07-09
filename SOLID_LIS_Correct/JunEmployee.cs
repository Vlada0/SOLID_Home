using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_LIS_Correct
{
    public class JunEmployee : IEmployee
    {
        public string GetEmployeeDetails(int employeeId)
        {
            return "Junior Employee";
        }
    }
}
