﻿using Eventos.IO.Domain.Eventos;
using Eventos.IO.Domain.Eventos;
using System;

namespace ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Valor = 50;
            var evento = new Evento(
                     "",
                     DateTime.Now,
                     DateTime.Now,
                     true,
                     Valor,
                     false,
                     "");

        

            Console.WriteLine(evento.ToString());
            Console.WriteLine(evento.EhValido());

            if (!evento.ValidationResult.IsValid)
            {
                foreach (var erro in evento.ValidationResult.Errors)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }
            Console.ReadKey();
        }
    }
}
