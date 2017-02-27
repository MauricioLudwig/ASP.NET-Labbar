using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L2_2.Models
{

    public class Address
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public Address CompanyAddress { get; set; }
        public int EmployeeCount { get; set; }
    }
}
