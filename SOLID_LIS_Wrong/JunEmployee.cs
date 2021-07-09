using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_LIS_Wrong
{
    public class JunEmployee : Employee
    {
        // Допустим, для Junior’a отсутствует информация
        public override string GetWorkDetails(int id)
        {
            throw new NotImplementedException();
        }


        public override string GetEmployeeDetails(int id)
        {
            return "Junior Employee";

        }
    }
}
