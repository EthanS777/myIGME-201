using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace UT2Q4
{
    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber()
        {
            return phoneNumber;
        }
        public abstract void Connect();

        public abstract void Disconnect();
    }
}
