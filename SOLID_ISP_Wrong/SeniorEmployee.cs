using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_ISP_Wrong
{
    class SeniorEmployee : IEmployee
    {
        public bool AddDetailsEmployee()
        {
            return true;
        }

        public bool ShowDetailsEmployee(int id)
        {
            return true;
        }
    }
}
