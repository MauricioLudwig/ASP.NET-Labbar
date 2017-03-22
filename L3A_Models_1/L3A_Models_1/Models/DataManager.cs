using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L3A_Models_1.Models
{
    public static class DataManager
    {
        static List<Person> people = new List<Person>()
        {
            new Person { Name = "Damien", Age = 20 },
            new Person { Name = "Pavel", Age = 24 },
            new Person { Name = "Mauricio", Age = 26 },
        };

        public static Person[] GetPeople()
        {
            return people.ToArray();
        }
    }
}
