using Eventos.IO.Domain.Models;
using System;

namespace ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Valor = 0;
            var evento = new Evento(
                     "No",
                     DateTime.Now,
                     DateTime.Now,
                     true,
                     Valor,
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
