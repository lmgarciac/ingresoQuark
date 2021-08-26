using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaRopa
{
    class Cotizacion
    {
        private int _id;
        private DateTime _fecha;
        private int _codigoVendedor;
        private string _prenda;
        private int _unidades;
        private float _cotizacion;

        public Cotizacion(int id, DateTime fecha, int codigoVendedor, string prenda, int unidades, float cotizacion)
        {
            _id = id;
            _fecha = fecha;
            _codigoVendedor = codigoVendedor;
            _prenda = prenda;
            _unidades = unidades;
            _cotizacion = cotizacion;
        }
    }
}
