using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConciergeApp.Models;
using ConciergeApp.Services;
using ConciergeApp.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ConciergeApp.API
{
    [Route("api/[controller]")]
    public class CommentController : Controller
    {
        private CommentsService _service;

        public CommentController(CommentsService service)
        {
            _service = service;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<CommentDTO> GetProfileComment()
        {
            string userId = User.Identity.GetUserId();
            return _service.GetProfileComment(userId);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost("{feedbackId}")]
        public void Post( int feedbackId, [FromBody]CommentDTO value)
        {
            _service.Add(value, User.Identity.GetUserId(), feedbackId);
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
