using KPTNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPTNET.Repository
{
    public interface IAddressRepository
    {
        string CreateNewAddress(Address address);
        string DeleteAddress(int addressId);
        void UpdateAddress(Address address);
        Address GetAddressById(int addressId);
        List<Address> GetBooks();
    }
}
