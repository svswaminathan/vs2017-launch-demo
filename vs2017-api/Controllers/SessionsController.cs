using System.Collections.Generic;
using vs2017_api.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace vs2017_api
{
    [Route("api/[controller]")]
    public class SessionsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Session> Get()
        {
            List<Session> Sessions = new List<Session>();
            Sessions.Add(new Session { Title= "Welcome & Registration", Speaker = "-", Time="08:00 - 09:30"});
            Sessions.Add(new Session { Title= "Visual Studio 2017 - Keynote", Speaker = "Lohith", Time="09:30 - 10:10"});
            Sessions.Add(new Session { Title= "What's new in VS 2017 ?", Speaker = "Rahul Sahay", Time="10:10 - 11:00"});
            Sessions.Add(new Session { Title = "Coffee/Tea Break", Speaker = "-", Time = "11:15 - 11:30" });
            Sessions.Add(new Session { Title= "What's new for .Net core in VS 2017 ?", Speaker = "Lohith", Time="11:30 - 12:25"});
            Sessions.Add(new Session { Title = "Lunch Break", Speaker = "-", Time = "12:30 - 01:25" });
            Sessions.Add(new Session { Title= "Building Web Apps powered by Angular 2.0 in VS 2017", Speaker = "Vic", Time="01:30 - 02:25"});
            Sessions.Add(new Session { Title= "Connected iOS, Android and Windows app using Azure and Xamarin", Speaker = "Anubhav", Time="02:30 - 03:25"});
            Sessions.Add(new Session { Title = "Coffee/Tea Break", Speaker = "-", Time = "03:25 - 03:45" });
            Sessions.Add(new Session { Title= "Visual Studio Mobile Center", Speaker = "Anubhav", Time="03:45 - 04:05"});
            Sessions.Add(new Session { Title= "Docker & ACS using VS 2017", Speaker = "Swami", Time="04:10 - 05:00"});
            return Sessions;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
