using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi_Zapateria.Entidades;

namespace WebApi_Zapateria.Controllers
{
    [ApiController]
    [Route("zapatos")]
    public class PedZapController : ControllerBase
    {

        //métodos utilizados get, put, push, post

        //sirvio para crear nuestra base de datos
        [HttpGet("id: int")]
        public async Task<ActionResult<List<PedZap>>> Get()
        {
            /*return new List<PedZap>()
            {
                //Creando una base de datos apartir de codigo
                new PedZap() { Id = 1, Talla = 24, Color = "Negro", Marca = "Andrea" },
                new PedZap() { Id = 2, Talla = 21, Color = "Hueso", Marca = "Andrea" },
                new PedZap() { Id = 3, Talla = 25, Color = "Lila", Marca = "Andrea" }

            };*/
            return await dbContext.PedZap.ToListAsync();

        }

        //sirve para ingresar datos 
        [HttpPost("id: int")]
        public async Task<ActionResult<int>> Post(PedZap pedzap)
        {
            dbContext.Add(pedzap);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        private readonly ApplicationDbContext dbContext;
        public PedZapController(ApplicationDbContext context)
        {
            this.dbContext = context;
        }

        [HttpPut("id: int")]
        
        public async Task<ActionResult> Put(PedZap pedzap, int id)
        {
            if(pedzap.Id != id)
            {
                return BadRequest("El id del zapato no coincide con el establecido en la url");
            }

            dbContext.Update(pedzap);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("id: int")]

        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.PedZap.AnyAsync(x=> x.Id == id);

            if (!exist)
            {
                return NotFound();
            }

            dbContext.Remove(new PedZap()
            {
                Id = id
            }); 
            await dbContext.SaveChangesAsync();
            return Ok();
        }

    }
}
