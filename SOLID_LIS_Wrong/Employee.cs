using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_LIS_Wrong
{
    public abstract class Employee
    {
        public virtual string GetWorkDetails(int id)
        {
            return "Base Work";
        }

        public virtual string GetEmployeeDetails(int id)
        {
            return "Base Employee";
        }

    }
}
