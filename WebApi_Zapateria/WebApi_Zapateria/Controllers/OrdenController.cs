using Microsoft.AspNetCore.Mvc;
using WebApi_Zapateria.Entidades;

namespace WebApi_Zapateria.Controllers
{
    [ApiController]
    [Route("/ordenes")]

    public class OrdenController: Controller
    {
        //métodos utilizados get, put, push, post

        [HttpGet]
        public ActionResult<List<Orden>> Get()
        {
            return new List<Orden>()
            {
                //Creando una base de datos apartir de codigo
                new Orden() { Codigo= "4D8A", Precio=1200 , FechaEntrega= "28 de nov"},
                new Orden() { Codigo= "7M2F", Precio=560 , FechaEntrega= "1 de oct"},
                new Orden() {Codigo= "1P3R", Precio=720 , FechaEntrega= "19 de oct"}

            };
        }
        
        
    }
}
