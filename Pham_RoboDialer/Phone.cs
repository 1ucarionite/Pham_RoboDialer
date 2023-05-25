using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pham_RoboDialer
{
    internal class Phone
    {
        protected string phoneNumber;
        protected string companyName;
        protected int phoneType;

        public Phone(string phoneNumber, string companyName, int phoneType)
        {
            this.phoneNumber = phoneNumber;
            this.companyName = companyName;
            this.phoneType = phoneType;
        }

        public virtual string Dial()
        {
            return companyName + " is being dialed using " + phoneNumber + "...";
        }
    }
}
