using FluentValidation;
using WebApi_Zapateria.Entidades;

namespace WebApi_Zapateria.Validaciones
{
    public class PedZapValidacion: AbstractValidator<PedZap>
    {
        public PedZapValidacion()
        {
            RuleFor(pedzap => pedzap.Id);
            RuleFor(pedzap => pedzap.Talla);
            RuleFor(pedzap => pedzap.Marca);
            RuleFor(pedzap => pedzap.Color);
        }
    }
}
