using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPTNET.Models
{
    //Now I will create a class call "Address"
    public class Address
    {
        public int AddressId { get; set; }
        public string BuildingNo { get; set; }
        public string StreetName { get; set; }
        public string Floor { get; set; }
        public string Township { get; set; }
        public string  PostalCode { get; set; }
    }
}
