using demoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoLibrary.Queries
{
    public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;
   
    
       
    //alternate way of doing this

        //public class GetPersonByIdQueryClass : IRequest<PersonModel>
        //{
        //    public int Id { get; set; }

        //    public GetPersonByIdQueryClass(int id)
        //    {
        //        Id = id;
        //    }
        //}


    
}
