using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConciergeApp.ViewModels;
using System.Net.Http;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ConciergeApp.API
{
    [Route("api/[controller]")]
    public class DetailsController : Controller
    {
        // GET: api/values
        [HttpPost("search")]
        public async Task<object> Get([FromBody] DetailsSearch placeid)
        {
            using (var client = new HttpClient())
            {
                //input google maps & replace the location using their current lat/long
                var response = await client.GetStringAsync(string.Format($"https://maps.googleapis.com/maps/api/place/details/json?placeid={placeid.Placeid}&key=AIzaSyC8XRhhuR8S3zMFfYlQX26kyzUewoccP-Q"));

                var result = JsonConvert.DeserializeObject(response);
                return result;
            }
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
