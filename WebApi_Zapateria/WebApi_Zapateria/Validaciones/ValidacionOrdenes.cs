using FluentValidation;
using WebApi_Zapateria.Entidades;

namespace WebApi_Zapateria.Validaciones
{
    public class ValidacionOrden: AbstractValidator<Orden>
    {
        public ValidacionOrden()
        {
            RuleFor(o=> o.Codigo).NotNull();
            RuleFor(o=> o.Precio).NotNull();
            RuleFor(o=> o.FechaEntrega).NotNull();

        } 
    }
}
