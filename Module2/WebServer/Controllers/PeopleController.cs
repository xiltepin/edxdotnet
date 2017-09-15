using System;
using WebServer.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WebServer.Controllers
{
    [Route("api/people")]
    public class PeopleController : Controller
    {
        [HttpGet]
        public Person[] Get()
        {
            return Repository.People.ToArray();
        }

        [HttpGet("{id}")]
        public Person Get(int id){
            return Repository.GetPersonByID(id);
        }

        [HttpPost]
        public void Post([FromBody]Person person){
            Repository.AddPerson(person);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Person person){
            Repository.ReplacePersonById(id,person);
        }

        [HttpDelete("{id}")]
        public void RemovePersonByID(int id){
            Repository.RemovePersonByID(id);
        }
    }
}
