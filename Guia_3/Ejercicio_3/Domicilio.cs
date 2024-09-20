using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Domicilio
    {
        public string Calle {  get; set; }
        public int Nro {  get; set; }
        public string Localidad {  get; set; }
        public string Provincia {  get; set; }

        public string EnTexto()
        {
            return $"{Localidad}, Nro: {Nro}, {Localidad}, {Provincia}";
        }
    }
}
