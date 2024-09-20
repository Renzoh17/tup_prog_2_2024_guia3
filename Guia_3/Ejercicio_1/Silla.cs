using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Silla : Producto
    {
        public Silla(string desc, double precioB, int tipoM):base(desc, precioB, tipoM)
        {

        }
        public override double CalcularPrecio()
        {
            double precio = (precioBase * (1 + tipoMaterial * 0.25));
            return precio;
        }
        public override string VerDetalle()
        {
            return $"{"Silla",10}{descripcion,10}{tipoM,10}{precioBase,10:f2}{"Silla",10}{CalcularPrecio(),16:f2}";
        }
    }
}
