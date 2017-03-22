using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L3A_Models_2.Models
{
    public static class DataManager
    {
        static List<Person> people = new List<Person>()
        {
            new Person { Id = 1, Name = "Damien", Email = "damien@me.com" },
            new Person { Id = 2, Name = "Pavel", Email = "pavel@me.com" },
            new Person { Id = 3, Name = "Dael", Email = "dael@me.com" },
        };

        public static void AddPerson(Person person)
        {
            person.Id = people
                .Max(o => o.Id) + 1;
            people.Add(person);
        }

        public static Person[] GetAllPeople()
        {
            return people.OrderBy(o => o.Id).ToArray();
        }

        public static Person GetPerson(int id)
        {
            return people
                .SingleOrDefault(o => o.Id == id);
        }

        public static void EditPerson(Person person)
        {
            people.RemoveAt(people.SingleOrDefault(o => o.Id == person.Id).Id - 1);
            people.Add(person);
        }
    }
}
