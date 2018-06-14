using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lab29MovieAPI.Models;


namespace Lab29MovieAPI.Controllers
{
    public class MoviesController : ApiController
    {

        [HttpGet]
        public List<Movy> ShowAllMovies()
        {
            Lab29Entities1 ORM = new Lab29Entities1();

            return ORM.Movies.ToList();

        }

        [HttpGet]
        public List<Movy> MoviesByCatagory(string Catagory)
        {
            Lab29Entities1 ORM = new Lab29Entities1();

            return ORM.Movies.Where(c => c.Catagory.Contains(Catagory)).ToList();

        }

        [HttpGet]
        public List<Movy> SearchByCatagory(string discription)
        {
            Lab29Entities1 ORM = new Lab29Entities1();

            return ORM.Movies.Where(c => c.Catagory.Contains(discription)).ToList();

        }

        public Movy GetRandomMovie()
        {
            Lab29Entities1 ORM = new Lab29Entities1();
            List<Movy> movie = ORM.Movies.ToList();
            Random r = new Random();
            int result = r.Next(0, movie.Count);
            return movie[result];
        }

     

    }
}
