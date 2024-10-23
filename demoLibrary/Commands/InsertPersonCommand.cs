using demoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoLibrary.Commands
{
    //setting these names in camel case becuase the name we set here will be going to be our name of properties
    //(string FirstName, string LastName
    public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;


    //way of doing using class

    //public class InsertPersonCommandClass : IRequest<PersonModel>
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //    public InsertPersonCommandClass(string firstName, string lastName)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //    }
    //}


}
