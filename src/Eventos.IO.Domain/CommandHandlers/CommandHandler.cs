using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Text;

namespace Eventos.IO.Domain.CommandHandlers
{
    public abstract class CommandHandler
    {
        protected void NotificarValidacoesErro(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Console.WriteLine(error.ErrorMessage);
            }
        }
    }
}
