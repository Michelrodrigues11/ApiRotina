using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiRotina.Models;
using ApiRotina.Models.Enuns;
using ApiRotina.Data;

namespace ApiRotina.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DietasController : ControllerBase
    {
        private readonly DataContext _context;

        public DietasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Dieta>> Get(int id)
        {
            var dieta = await _context.TB_DIETAS.FindAsync(id);
            if (dieta == null)
            {
                return NotFound();
            }
            return dieta;
        }

        [HttpPost]
        public async Task<ActionResult<Dieta>> Post(Dieta dieta)
        {
            _context.TB_DIETAS.Add(dieta);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Get", new { id = dieta.IdDieta }, dieta);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Dieta dieta)
        {
            if (id != dieta.IdDieta)
            {
                return BadRequest();
            }
            _context.Entry(dieta).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var dietaValida = await _context.TB_DIETAS.FindAsync(id);
                if (dietaValida == null)
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var dieta = await _context.TB_DIETAS.FindAsync(id);
            if (dieta == null)
            {
                return NotFound();
            }
            _context.TB_DIETAS.Remove(dieta);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
