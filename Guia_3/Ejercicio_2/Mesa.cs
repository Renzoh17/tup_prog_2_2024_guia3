using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Mesa : Producto
    {
        double largo;

        public Mesa(string desc, double precioB, int tipoM, double largo):base(desc, precioB, tipoM)
        {
            this.largo = largo;
        }
        public override double CalcularPrecio()
        {
            double precio = (precioBase * largo) * (1 + tipoMaterial * 0.33);
            return precio;
        }
        public override string VerDetalle()
        {
            return $"{"Mesa",10}{descripcion,10}{tipoM,10}{precioBase,10:f2}{"Mesa(",10}{largo:f1}{"m)"}{CalcularPrecio(),10:f2}";
        }
    }
}
