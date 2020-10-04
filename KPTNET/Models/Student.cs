using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KPTNET.Models
{
    public class Student
    {
        //Entity Framework
        //LINQ
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; } //Now there are no errors 
        public List<Book> Books { get; set; }
    }
}
