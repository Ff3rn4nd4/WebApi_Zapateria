using FluentValidation;
using WebApi_Zapateria.Entidades;

namespace WebApi_Zapateria.Validaciones
{
    public class PedZapValidacion: AbstractValidator<PedZap>
    {
        public PedZapValidacion()
        {
            RuleFor(p=> p.Id).Empty();
            RuleFor(p=> p.Talla).NotEmpty();
            RuleFor(p=> p.Marca).NotEmpty();
            RuleFor(p=> p.Color).NotEmpty();
        }
    }
}
