using LabMobile.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LabMobile.Controllers
{
    [Produces("application/json")]
    [Route("api/Home")]

    

    public class HomeController : Controller
    {
        private readonly DataContext _datacontext;

        public HomeController(DataContext datacontext)
        {
            _datacontext = datacontext;
        }
        // GET: 
        [HttpGet]
        public IEnumerable<Staff> Get()
        {
            return _datacontext.staff;
        }


        // GET: 
        [HttpGet("{id}")]
        public async Task <IActionResult> Get([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var Detail = await _datacontext.staff.SingleOrDefaultAsync(m => m.Id == id);
            if (Detail == null)
            {
                return NotFound();
            }
            return Ok(Detail);
        }

        // PUT: 
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(
            [FromRoute] int id, [FromBody] Staff detail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != detail.Id)
            {
                return BadRequest();
            }

            _datacontext.Entry(detail).State = EntityState.Modified;

            try
            {
                await _datacontext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        // POST: 
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Staff detail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _datacontext.staff.Add(detail);
            await _datacontext.SaveChangesAsync();

            return CreatedAtAction("GetDetail", new { id = detail.Id }, detail);
        }
        private bool Exists(int id)
        {
            return _datacontext.staff.Any(e => e.Id == id);
        }
    }
}
