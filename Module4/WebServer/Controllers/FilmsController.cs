using System;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace WebServer.Controllers
{
    [Route("api/films")]
    public class FilmsController : Controller
    {
        private SakilaDbContext dbContext;

        public FilmsController()
        {
            string connectionString = "server=localhost;port=3306;database=sakila;userid=root;pwd=123456;sslmode=none";
            dbContext = SakilaDbContextFactory.Create(connectionString);
        }



        [HttpGet]
        public Film[] Get()
        {
            return dbContext.Film.ToArray();
        }

        [HttpGet("{id}")]
        public Film Get(int id)
        {
            var test = new Film();

            var film = test; //"//dbContext.Film.SingleOrDefault(r => r.Film_ID == id);
            return film;
        }

    }
}
