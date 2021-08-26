using System;
using System.Collections.Generic;
using System.Text;
using Enums;

namespace NegocioRopa
{
    abstract class Prenda : ICotizable
    {
        protected CalidadPrenda _calidad;
        protected float _precioUnitario;
        protected int _stock;

        public virtual float Cotizar(float cotizacion)
        {
            if (_calidad == CalidadPrenda.premium)
                cotizacion *= 1.3f;

            return cotizacion;
        }
    }
}
