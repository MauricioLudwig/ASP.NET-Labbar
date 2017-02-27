using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupAssignment_L2_2.Models;

namespace GroupAssignment_L2_2.Models
{
    public class DataManager
    {
        static List<Customer> customers = new List<Customer>()
        {
            new Customer
            {
                Id = 1,
                CompanyName = "Stark's Inn",
                CompanyAddress = new Address { City = "Winterfell", Country = "Westeros", Street = "Peasant Street" },
                EmployeeCount = 5,
            },
            new Customer
            {
                Id = 2,
                CompanyName = "Targaryen's Dragon Display",
                CompanyAddress = new Address { City = "Storm's End", Country = "Westeros", Street = "Spear and Shield Street" },
                EmployeeCount = 10,
            },
        };

        public static void AddCustomer(Customer customer)
        {
            if (customers.Count < 1)
            {
                customer.Id = 1;
            }
            else
            {
                customer.Id = (customers
                .Max(x => x.Id)) + 1;
            }

            customers.Add(customer);
        }

        public static Customer GetCustomer(int id)
        {
            return customers
                .SingleOrDefault(x => x.Id == id);
        }

        public static Customer[] GetAllCustomers()
        {
            return customers.ToArray();
        }

        public static void RemoveCustomer(int id)
        {
            customers.Remove(customers
                .SingleOrDefault(x => x.Id == id));
        }
    }
}
