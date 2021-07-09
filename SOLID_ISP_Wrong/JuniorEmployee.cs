using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_ISP_Wrong
{
    public class JunEmployee : IEmployee
    {
        public bool AddDetailsEmployee()
        {
            return true;
        }

        public bool ShowDetailsEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
