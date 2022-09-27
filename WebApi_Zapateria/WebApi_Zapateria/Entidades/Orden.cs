namespace WebApi_Zapateria.Entidades
{
    public class Orden
    {
        //datos o atributos que tomaran las peticiones
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int Precio { get; set;  }
        public string FechaEntrega { get; set; } 
    }
}
