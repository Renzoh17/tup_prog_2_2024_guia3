using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal abstract class Producto
    {
        protected string descripcion;
        protected double precioBase;
        protected int tipoMaterial;
        protected string tipoM
        {
            get
            {
                string tipo = "Desconocido";
                if (tipoMaterial == 0) tipo = "Pino";
                else if (tipoMaterial == 1) tipo = "Caoba";
                else if (tipoMaterial == 2) tipo = "Algarrobo";
                return tipo;
            }
        }

        public Producto(string descripcion, double precioBase, int tipoMaterial)
        {
            this.descripcion = descripcion;
            this.precioBase = precioBase;
            this.tipoMaterial = tipoMaterial;
        }
        public abstract double CalcularPrecio();
        public abstract string VerDetalle();
    }
}
