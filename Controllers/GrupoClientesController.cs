using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Annexus_API.Models;

namespace Annexus_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoClientesController : ControllerBase
    {
        private readonly Contexto _context;

        public GrupoClientesController(Contexto context)
        {
            _context = context;
        }

        // GET: api/GrupoClientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GrupoClientes>>> GetGrupoClientes()
        {
            return await _context.GrupoClientes.ToListAsync();
        }

        // GET: api/GrupoClientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GrupoClientes>> GetGrupoClientes(int id)
        {
            var grupoClientes = await _context.GrupoClientes.FindAsync(id);

            if (grupoClientes == null)
            {
                return NotFound();
            }

            return grupoClientes;
        }

        // PUT: api/GrupoClientes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrupoClientes(int id, GrupoClientes grupoClientes)
        {
            if (id != grupoClientes.Id)
            {
                return BadRequest();
            }

            _context.Entry(grupoClientes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GrupoClientesExists(id))
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

        // POST: api/GrupoClientes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GrupoClientes>> PostGrupoClientes(GrupoClientes grupoClientes)
        {
            _context.GrupoClientes.Add(grupoClientes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGrupoClientes", new { id = grupoClientes.Id }, grupoClientes);
        }

        // DELETE: api/GrupoClientes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GrupoClientes>> DeleteGrupoClientes(int id)
        {
            var grupoClientes = await _context.GrupoClientes.FindAsync(id);
            if (grupoClientes == null)
            {
                return NotFound();
            }

            _context.GrupoClientes.Remove(grupoClientes);
            await _context.SaveChangesAsync();

            return grupoClientes;
        }

        private bool GrupoClientesExists(int id)
        {
            return _context.GrupoClientes.Any(e => e.Id == id);
        }
    }
}
