using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaRopaWindowsForms
{
    class Vendedor
    {
        private string _nombre;
        private string _apellido;
        private int _codigo;

        public Vendedor(string nombre, string apellido, int codigo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _codigo = codigo;
        }
    }
}
