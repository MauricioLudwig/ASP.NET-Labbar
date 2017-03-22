using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L3B_Models_1.Models
{
    public static class DataManager
    {
        static List<Person> people = new List<Person>()
        {
            new Person { Name = "Damien", Email = "damien@gmail.com" },
            new Person { Name = "Pavel", Email = "pavel@acme.com" },
            new Person { Name = "Dael", Email = "dael@outlook.com" },
            new Person { Name = "Dael", Email = "dael@acme.com" },
        };

        public static PeopleIndexVM[] GetAllPeople()
        {
            return people
                .Select(o => new PeopleIndexVM()
                {
                    Name = o.Name,
                    Email = o.Email,
                    ShowAsHighlighted = o.Email.EndsWith("acme.com"),
                })
                .ToArray();
        }

        public static void AddPerson(PeopleCreateVM viewModel)
        {
            //var person = new Person()
            //{
            //    Name = viewModel.Name,
            //    Email = viewModel.Email,
            //};

            var person = AutoMapper.Mapper.Map<Person>(viewModel);

            people.Add(person);
        }
    }
}
