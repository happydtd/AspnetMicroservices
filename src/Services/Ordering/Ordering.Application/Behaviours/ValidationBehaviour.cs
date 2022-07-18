using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Behaviours
{
    public class ValidationBehaviour<Trequest, Tresponse> : IPipelineBehavior<Trequest, Tresponse>
    {
        private readonly IEnumerable<IValidator<Trequest>> _validators;

        public ValidationBehaviour(IEnumerable<IValidator<Trequest>> validators)
        {
            _validators = validators?? throw new ArgumentNullException(nameof(validators));
        }

        public async Task<Tresponse> Handle(Trequest request, CancellationToken cancellationToken, RequestHandlerDelegate<Tresponse> next)
        {
            if (_validators.Any())
            {

            }
        }
    }
}
