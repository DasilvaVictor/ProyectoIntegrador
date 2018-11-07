﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiHotel.Data;
using WebApiHotel.Models;

namespace WebApiHotel.Controllers
{
    [Produces("application/json")]
    [Route("api/Habitaciones")]
    public class HabitacionesController : Controller
    {
        private readonly WebApiHotelDBContext _context;

        public HabitacionesController(WebApiHotelDBContext context)
        {
            _context = context;
        }

        // GET: api/Habitaciones
        [HttpGet]
        public IEnumerable<Habitacion> GetHabitaciones()
        {
            return _context.Habitaciones.Include(x=>x.Estado).Include(y=>y.Tipo);
        }

        // GET: api/Habitaciones/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHabitacion([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Habitacion habitacion;
           
             habitacion = await _context.Habitaciones.Include(x=>x.Estado).Include(y=>y.Tipo).SingleOrDefaultAsync(m => m.Codigo == id);
           
            if (habitacion == null)
            {
                return NotFound();
            }

            return Ok(habitacion);
        }
       

        // PUT: api/Habitaciones/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHabitacion([FromRoute] int id, [FromBody] Habitacion habitacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != habitacion.Codigo)
            {
                return BadRequest();
            }

  
            _context.Entry(habitacion).State = EntityState.Modified;

            try
            {
                //_context.UpdateRange(habitacion.Estado);
                //_context.UpdateRange(habitacion.Tipo);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HabitacionExists(id))
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

        // POST: api/Habitaciones
        [HttpPost]
        public async Task<IActionResult> PostHabitacion([FromBody] Habitacion habitacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Habitaciones.Add(habitacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHabitacion", new { id = habitacion.Codigo }, habitacion);
        }

        // DELETE: api/Habitaciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHabitacion([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var habitacion = await _context.Habitaciones.SingleOrDefaultAsync(m => m.Codigo == id);
            if (habitacion == null)
            {
                return NotFound();
            }

            _context.Habitaciones.Remove(habitacion);
            await _context.SaveChangesAsync();

            return Ok(habitacion);
        }

        private bool HabitacionExists(int id)
        {
            return _context.Habitaciones.Any(e => e.Codigo == id);
        }
    }
}