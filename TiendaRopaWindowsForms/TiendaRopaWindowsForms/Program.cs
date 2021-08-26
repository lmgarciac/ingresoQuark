using System;
using Enums;

namespace TiendaRopaWindowsForms
{
    class Program
    {
        static void Main(string[] args)
        {
            Form1 form1 = new Form1();
            Tienda tienda = new Tienda("Ropitas", "Lima 800");
            Vendedor vendedor = new Vendedor("Pedro", "Gomez", 156);
        }
    }
}
