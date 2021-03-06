﻿using Eventos.IO.Domain.CommandHandlers;
using Eventos.IO.Domain.Core.Events;
using Eventos.IO.Domain.Eventos.Commands;
using Eventos.IO.Domain.Eventos.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Domain.Eventos.CommandHandlers
{
    public class EventoCommandHandler : CommandHandler,
        IHandler<RegistrarEventoCommand>,
        IHandler<AtualizarEventoCommand>,
        IHandler<ExcluirEventoCommand>
    {
        private readonly IEventoRepository _eventoRepository;

        public EventoCommandHandler(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public void Handle(RegistrarEventoCommand message)
        {
            var evento = new Evento(
                message.Nome,
                message.DataInicio,
                message.DataFim,
                message.Gratuito,
                message.Valor,
                message.Online,
                message.NomeEmpresa);

        
            if (!evento.EhValido())
            {
                NotificarValidacoesErro(evento.ValidationResult);
                return;
            }

            // TODO:
            // Validacoes de negocio!
            // Organizador pode registrar evento?

            _eventoRepository.Add(evento);
        }

        public void Handle(AtualizarEventoCommand message)
        {
            throw new NotImplementedException();
        }

        public void Handle(ExcluirEventoCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
