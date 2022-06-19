using LabMobile.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LabMobile.Controllers
{
    [Produces("application/json")]
    [Route("api/Values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _datacontext;

        public ValuesController(DataContext datacontext)
        {
            _datacontext = datacontext;
        }


        //GET: 
        [HttpGet]
        public IEnumerable<Staff> Get()
        {
            return _datacontext.staff;
        }

        // GET Id: 
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var staff = await _datacontext.staff.SingleOrDefaultAsync(m => m.Id == id);
            if (staff == null)
            {
                return NotFound();
            }
            return Ok(staff);
        }

        // PUT: 
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Staff staff)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != staff.Id)
            {
                return BadRequest();
            }

            _datacontext.Entry(staff).State = EntityState.Modified;

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
        public async Task<IActionResult> Insert(Staff staff)
        {
            _datacontext.staff.Add(staff);
            await _datacontext.SaveChangesAsync();

            return CreatedAtAction("GetDetail", new { Id = staff.Id }, staff);
        }
        private bool Exists(int id)
        {
            return _datacontext.staff.Any(e => e.Id == id);
        }
        // DELETE: 
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var staff = await _datacontext.staff.FindAsync(id);
            if (staff == null)
            {
                return NotFound();
            }
            _datacontext.staff.Remove(staff);
            await _datacontext.SaveChangesAsync();
            return NoContent();
        }
    }
}



