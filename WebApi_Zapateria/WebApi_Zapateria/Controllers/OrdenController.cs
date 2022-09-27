using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi_Zapateria.Entidades;

namespace WebApi_Zapateria.Controllers
{
    [ApiController]
    [Route("zapatos/ordenes")]

    public class OrdenController: Controller
    {
        //métodos utilizados get, put, push, post

        [HttpGet]
        public async Task<ActionResult<List<Orden>>> Get()
        {
            /*return new List<Orden>()
            {
                Creando una base de datos apartir de codigo
                new Orden() {Id= 1,Codigo= "4D8A", Precio=1200 , FechaEntrega= "28 de nov"},
                new Orden() {Id= 2,Codigo= "7M2F", Precio=560 , FechaEntrega= "1 de oct"},
                new Orden() {Id= 3,Codigo= "1P3R", Precio=720 , FechaEntrega= "19 de oct"}
            };*/

            return await dbContext.Orden.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Orden orden)
        {
            dbContext.Add(orden);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        private readonly ApplicationDbContext dbContext;
        public OrdenController(ApplicationDbContext context)
        {
            this.dbContext = context;
        }

        [HttpPut("id: int")]

        public async Task<ActionResult> Put(Orden orden, int id)
        {
            if (orden.Id != id)
            {
                return BadRequest("El id del zapato no coincide con el establecido en la url");
            }

            dbContext.Update(orden);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("id: int")]

        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Orden.AnyAsync(x => x.Id == id);

            if (!exist)
            {
                return NotFound();
            }

            dbContext.Remove(new Orden()
            {
                Id = id
            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }

    }
}
