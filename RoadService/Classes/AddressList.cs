using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadService.Classes
{
    public class AddressList
    {
        private readonly List<Address> _addresses;

        public AddressList() 
        {
            // получить список адресов из бд
        }

        public bool IsValidAddress(string address)
        {
            if (string.IsNullOrEmpty(address)) { return false; }

            return _addresses.Any(u => u.Name.Contains(address));

        }

    }
}
