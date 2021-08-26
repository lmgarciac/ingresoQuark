using System;
using System.Collections.Generic;
using System.Text;
using Enums;

namespace TiendaRopaWindowsForms
{
    class Pantalon : Prenda, ICotizable
    {
        private TipoPantalon _tipo;

        public Pantalon(TipoPantalon tipo, CalidadPrenda calidad, float precioUnitario, int stock)
        {
            _tipo = tipo;
            _calidad = calidad;
            _precioUnitario = precioUnitario;
            _stock = stock;
        }

        public override float Cotizar(float cotizacion = 0f)
        {
            cotizacion = _precioUnitario;

            if (_tipo == TipoPantalon.chupin)
                _precioUnitario *= 0.88f;

            cotizacion = base.Cotizar(cotizacion);

            return cotizacion;
        }
    }
}
