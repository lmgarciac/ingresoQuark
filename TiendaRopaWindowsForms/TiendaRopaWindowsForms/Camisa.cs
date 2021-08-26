using System;
using System.Collections.Generic;
using System.Text;
using Enums;

namespace TiendaRopaWindowsForms
{
    class Camisa : Prenda, ICotizable
    {
        private TipoCuello _cuello;
        private TipoManga _manga;

        public Camisa(TipoCuello cuello, TipoManga manga, CalidadPrenda calidad, float precioUnitario, int stock)
        {
            _cuello = cuello;
            _manga = manga;
            _calidad = calidad;
            _precioUnitario = precioUnitario;
            _stock = stock;
        }

        public override float Cotizar(float cotizacion = 0f)
        {
            cotizacion = _precioUnitario;

            if (_manga == TipoManga.corta)
                cotizacion *= 0.9f;
            if (_cuello == TipoCuello.mao)
                cotizacion *= 1.03f;

            Console.WriteLine($"Cotizacion Camisa {cotizacion}");

            cotizacion = base.Cotizar(cotizacion);

            Console.WriteLine($"Cotizacion base {cotizacion}");


            return cotizacion;
        }
    }
}
