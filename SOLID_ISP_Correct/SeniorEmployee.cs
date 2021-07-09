using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_ISP_Correct
{
    class SeniorEmployee : IAddDetails, IGetDetails
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
