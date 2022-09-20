using Microsoft.AspNetCore.Mvc;
using WebApi_Zapateria.Entidades;

namespace WebApi_Zapateria.Controllers
{
    [ApiController]
    [Route("/zapatos")]
    public class PedZapController: ControllerBase
    {
        //métodos utilizados get, put, push, post

        [HttpGet]
        public ActionResult<List<PedZap>> Get()
        {
            return new List<PedZap>()
            {
                //Creando una base de datos apartir de codigo
                new PedZap() { Id = 1, Talla = 24, Color = "Negro", Marca = "Andrea" },
                new PedZap() { Id = 2, Talla = 21, Color = "Hueso", Marca = "Andrea" },
                new PedZap() { Id = 3, Talla = 25, Color = "Lila", Marca = "Andrea" }

            };
        }
        
    }
}
