using Microsoft.AspNetCore.Mvc;
using OmnitrixCRUD.Models;

namespace OmnitrixCRUD.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class AliensController : ControllerBase
        {
            private static List<Alien> aliens = new();
            private static int nextId = 1;

            [HttpGet]
            public ActionResult<List<Alien>> GetAll()
            {
                return Ok(aliens);
            }

            [HttpGet("{id}")]
            public ActionResult<Alien> GetById(int id)
            {
                var alien = aliens.FirstOrDefault(a => a.Id == id);

                if (alien == null)
                    return NotFound();

                return Ok(alien);
            }

            [HttpPost]
            public ActionResult<Alien> Create(Alien alien)
            {
                alien.Id = nextId++;
                aliens.Add(alien);

                return CreatedAtAction(nameof(GetById),
                    new { id = alien.Id }, alien);
            }

            [HttpPut("{id}")]
            public IActionResult Update(int id, Alien updatedAlien)
            {
                var alien = aliens.FirstOrDefault(a => a.Id == id);

                if (alien == null)
                    return NotFound();

                alien.Nombre = updatedAlien.Nombre;
                alien.Poder = updatedAlien.Poder;

                return NoContent();
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                var alien = aliens.FirstOrDefault(a => a.Id == id);

                if (alien == null)
                    return NotFound();

                aliens.Remove(alien);

                return NoContent();
            }
        [HttpGet("search/{nombre}")]
        public ActionResult<List<Alien>> Search(string nombre)
        {
            var results = aliens
                .Where(a => a.Nombre.Contains(nombre,
                    StringComparison.OrdinalIgnoreCase))
                .ToList();

            return Ok(results);
        }
    }
    }

