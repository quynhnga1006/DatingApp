using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Namespace;

namespace DatingApp.API.Controllers
{
    
    public class UserContoller : BaseApiController
    {
        private readonly DataContext _context;
        public UserContoller(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_context.users);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var user = _context.users.FirstOrDefault(a =>  a.Id == id);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}