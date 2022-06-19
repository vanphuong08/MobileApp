using LabMobile.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LabMobile.Controllers
{
    [Produces("application/json")]
    [Route("api/Login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DataContext _datacontext;

        public LoginController(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        // GET: api/<LoginController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _datacontext.user;
        }

        // GET api/<LoginController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoginController>
        [HttpPost]
        public async Task<IActionResult> Insert(User user)
        {
            _datacontext.user.Add(user);
            await _datacontext.SaveChangesAsync();

            return CreatedAtAction("GetLogin", new { Id = user.Id }, user);
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
