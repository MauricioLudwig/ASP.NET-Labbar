using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L7A_JS_jQuery_1.Models
{
    public static class DataManager
    {
        static List<Customer> customers = new List<Customer>()
        {
            new Customer { Id = 1, Name = "Franz", City = "Prague" },
            new Customer { Id = 2, Name = "Damien", City = "Santiago" },
            new Customer { Id = 3, Name = "Leo", City = "Moscow" },
            new Customer { Id = 4, Name = "Albert", City = "Paris" },
        };

        public static CustomerIndexVM[] GetAllCustomers()
        {
            return customers
                .Select(o => new CustomerIndexVM
                {
                    Id = o.Id,
                    Name = o.Name,
                    City = o.City,
                })
                .ToArray();
        }

        public static CustomerIndexVM GetCustomerDetails(int id)
        {
            var model = customers.SingleOrDefault(o => o.Id == id);
            var viewModel = new CustomerIndexVM()
            {
                Id = model.Id,
                Name = model.Name,
                City = model.City,
            };

            return viewModel;
        }
    }
}
