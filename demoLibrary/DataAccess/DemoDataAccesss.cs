using demoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoLibrary.DataAccess
{
    public class DemoDataAccesss : IDataAccesss
    {
        private List<PersonModel> people = new();

        public DemoDataAccesss()
        {

            people.Add(new PersonModel
            {
                Id = 1,
                FirstName = "Ghufran",
                LastName = "Ullah"

            });

            people.Add(new PersonModel
            {
                Id = 2,
                FirstName = "Ali",
                LastName = "Mian"

            });
        }

        public List<PersonModel> getPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new() { FirstName = firstName, LastName = lastName };
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);

            return p;

        }


    }
}
