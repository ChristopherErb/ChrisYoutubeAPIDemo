using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    public class PeopleController : ApiController
    {
        /// <summary>
        /// This is where I give you all the information about my peeps.
        /// </summary>
        List<Person> people = new List<Person>();


        public PeopleController()
        {

            people.Add(new Person { FirstName = "Chris", LastName = "Erb", Id = 1 });
            people.Add(new Person { FirstName = "Aric  ", LastName = "Meibeyer", Id = 2 });
            people.Add(new Person { FirstName = "Melanie", LastName = "Kline", Id = 3 });
        }

        /// <summary>
        /// Gets a list of the first names of all users
        /// </summary>
        /// <param name="userId"></param>The Unique Identifier of this person
        /// <param name="age"></param>We want to know how old they are
        /// <returns>A list of first names</returns>

        //Lets you change the URL, also lets you add variables: api/people/getfirstnames/32/45
        [Route("api/People/GetFirstNames/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstName(int userId, int age)
        {
            List<string> output = new List<string>();

            foreach (var p in people)
            {
                output.Add(p.FirstName);              
            }
            return output;
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
             

        }



        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
