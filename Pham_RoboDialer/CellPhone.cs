using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pham_RoboDialer
{
    internal class CellPhone : Phone
    {
        public CellPhone(string phoneNumber, string companyName)
            : base(phoneNumber, companyName, 2)
        {
        }

        public override string Dial()
        {
            string formatPhoneNumber = phoneNumber;
            if (phoneType == 2)
            {
                formatPhoneNumber = "1+ " + formatPhoneNumber.Substring(0);
            }
            return companyName + " is being dialed using " + formatPhoneNumber + "...";
        }
    }
}
