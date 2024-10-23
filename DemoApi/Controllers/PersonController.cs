using demoLibrary.Commands;
using demoLibrary.Models;
using demoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private readonly IMediator mediator;

        public PersonController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/Person
        [HttpGet]
        public async Task<List<PersonModel>> Get()
        {
            return await mediator.Send(new GetPersonListQuery());
        }


        // GET: api/Person/Details/5
        [HttpGet("Details/{id}")]
        public async Task<PersonModel> Details(int id)
        {
            return await mediator.Send(new GetPersonByIdQuery(id));
        }


        // POST: api/Person/Create
        [HttpPost("Create")]
        public async Task<PersonModel> Create([FromBody] PersonModel value)
        {
            var model = new InsertPersonCommand(value.FirstName, value.LastName);
            return await mediator.Send(model);
        }


       

        // GET: api/Person/Create
        //[HttpGet("Create")]
        //public ActionResult Create()
        //{
        //    return View();



        //}
        //// GET: api/Person/Edit/5
        //[HttpGet("Edit/{id}")]
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: api/Person/Edit/5
        //[HttpPost("Edit/{id}")]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: api/Person/Delete/5
        //[HttpGet("Delete/{id}")]
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: api/Person/Delete/5
        //[HttpPost("Delete/{id}")]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}



