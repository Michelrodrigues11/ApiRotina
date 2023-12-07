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
    public class TreinosController : ControllerBase
    {
        private readonly DataContext _context;

        public TreinosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Treino>> Get(int id)
        {
            var treino = await _context.TB_TREINOS.FindAsync(id);
            if (treino == null)
            {
                return NotFound();
            }
            return treino;
        }

        [HttpPost]
        public async Task<ActionResult<Treino>> Post(Treino treino)
        {
            _context.TB_TREINOS.Add(treino);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Get", new { id = treino.IdTreino }, treino);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Treino treino)
        {
            if (id != treino.IdTreino)
            {
                return BadRequest();
            }
            _context.Entry(treino).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var treinoValido = await _context.TB_TREINOS.FindAsync(id);
                if (treinoValido == null)
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
        public async Task<ActionResult<Treino>> Delete(int id)
        {
            var treino = await _context.TB_TREINOS.FindAsync(id);
            if (treino == null)
            {
                return NotFound();
            }
            _context.TB_TREINOS.Remove(treino);
            await _context.SaveChangesAsync();
            return treino;
        }
    }
}
