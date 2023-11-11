using RoadService.Repository;
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

        public AddressList(UnitOfWork unitOfWork) 
        {
            _addresses = unitOfWork.Address.GetAll().ToList();
        }

        public void Add(Address address)
        {
            _addresses.Add(address);
        }

        public void Remove(Address address)
        {
            _addresses.Remove(address);
        }

        public bool IsValidAddress(string address)
        {
            if (string.IsNullOrEmpty(address)) { return false; }

            return _addresses.Any(u => u.Name.Contains(address));

        }

        public bool IsValidAddress1(string address)
        {
            if (string.IsNullOrEmpty(address)) { return false; }

            bool isValid = false;

            for (int i = 0; i < _addresses.Count; i++)
            {
                if (_addresses[i].Name.Contains(address))
                {
                    isValid = true;
                }
            }

            return isValid;
        }

    }
}
