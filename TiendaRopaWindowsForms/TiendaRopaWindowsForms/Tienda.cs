using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaRopaWindowsForms
{
    class Tienda
    {
        private string _nombre;
        private string _dirección;
        private List<ICotizable> _prendas;

        public Tienda(string nombre, string dirección, List<ICotizable> prendas = null)
        {
            _nombre = nombre;
            _dirección = dirección;
            _prendas = prendas;
        }

        public void CargarStock()
        {
            for (int i = 0; i < 1000; i++)
            {

            }

            for (int i = 0; i < 2000; i++)
            {

            }
        }
    }
}
