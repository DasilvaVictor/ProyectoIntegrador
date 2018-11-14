using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiHotel.Models;

namespace WebApiHotel.Controllers
{
    [Produces("application/json")]
    [Route("api/Empleados")]
    public class EmpleadosController : Controller
    {
        private readonly WebApiHotelDBContext _context;

        public EmpleadosController(WebApiHotelDBContext context)
        {
            _context = context;
        }

        // GET: api/Empleados
        [HttpGet]
        public IEnumerable<Empleados> GetEmpleados()
        {
            return _context.Empleados;
        }

        // GET: api/Empleados/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmpleados([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var empleados = await _context.Empleados.SingleOrDefaultAsync(m => m.Id == id);

            if (empleados == null)
            {
                return NotFound();
            }

            return Ok(empleados);
        }

        // PUT: api/Empleados/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpleados([FromRoute] int id, [FromBody] Empleados empleados)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != empleados.Id)
            {
                return BadRequest();
            }

            _context.Entry(empleados).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadosExists(id))
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

        // POST: api/Empleados
        [HttpPost]
        public async Task<IActionResult> PostEmpleados([FromBody] Empleados empleados)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Empleados.Add(empleados);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpleados", new { id = empleados.Id }, empleados);
        }

        // DELETE: api/Empleados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpleados([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var empleados = await _context.Empleados.SingleOrDefaultAsync(m => m.Id == id);
            if (empleados == null)
            {
                return NotFound();
            }

            _context.Empleados.Remove(empleados);
            await _context.SaveChangesAsync();

            return Ok(empleados);
        }

        private bool EmpleadosExists(int id)
        {
            return _context.Empleados.Any(e => e.Id == id);
        }
    }
}