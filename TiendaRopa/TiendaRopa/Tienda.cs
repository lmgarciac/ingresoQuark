using System;
using System.Collections.Generic;
using System.Text;

namespace NegocioRopa
{
    class Tienda
    {
        private string _nombre;
        private string _dirección;
        private List<string> _prendas;

        public Tienda(string nombre, string dirección, List<string> prendas)
        {
            _nombre = nombre;
            _dirección = dirección;
            _prendas = prendas;
        }
    }
}
