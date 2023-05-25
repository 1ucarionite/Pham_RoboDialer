using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pham_RoboDialer
{
    internal class HomePhone : Phone
    {
        public HomePhone(string phoneNumber, string companyName)
            : base(phoneNumber, companyName, 1)
        {   
        }
    }
}
