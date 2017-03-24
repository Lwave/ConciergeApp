using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConciergeApp.Models;
using ConciergeApp.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ConciergeApp.API
{
    [Route("api/[controller]")]
    public class BusinessController : Controller
    {
        private BusinessService _service;

        public BusinessController(BusinessService service)
        {
            _service = service;
        }
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return "";
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Business Get(int id)
        {
            return _service.GetBusinessById(id);
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
