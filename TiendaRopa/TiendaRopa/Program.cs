using System;
using Enums;

namespace NegocioRopa
{
    class Program
    {
        static void Main(string[] args)
        {
            string cuello, manga, calidad;
            float precio;

            Console.WriteLine($"Ingrese tipo cuello: ");
            cuello = Console.ReadLine();

            Console.WriteLine($"Ingrese tipo manga: ");
            manga = Console.ReadLine();

            Console.WriteLine($"Ingrese calidad: ");
            calidad = Console.ReadLine();

            Console.WriteLine($"Ingrese precio unitario: ");
            precio = float.Parse(Console.ReadLine());

            Camisa camisa = new Camisa((TipoCuello)Enum.Parse(typeof(TipoCuello), cuello),
                                       (TipoManga)Enum.Parse(typeof(TipoManga), manga),
                                       (CalidadPrenda)Enum.Parse(typeof(CalidadPrenda), calidad), precio, 1);

            var cotizacion = camisa.Cotizar();
            Console.WriteLine($"La camisa sale {cotizacion:F2}");
        }
    }
}
