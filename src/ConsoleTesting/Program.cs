﻿using Eventos.IO.Domain.Models;
using System;

namespace ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var evento = new Evento(
                     "Nome do Evento",
                     DateTime.Now,
                     DateTime.Now,
                     false,
                     50,
                     false,
                     "DBSF");

        var evento2 = new Evento(
         "Nome do Evento",
         DateTime.Now,
         DateTime.Now,
         true,
         50,
         false,
         "DBSF");

            Console.WriteLine(evento.ToString());
            Console.WriteLine(evento.Equals(evento2));
            Console.ReadKey();
        }
    }
}
