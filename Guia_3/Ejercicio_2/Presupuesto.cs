using Ejercicio_1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Presupuesto
    {
        ArrayList presupuestados = new ArrayList();
        public int CantidadProductos
        {
            get
            {
                return presupuestados.Count;
            }
        }
        public double CostoTotal
        {
            get
            {
                double precio = 0;
                foreach (Producto p in presupuestados) precio += p.CalcularPrecio();
                return precio;
            }
        }
        public string Cliente { get; set; }
        public string Direccion { get; set; }

        public Presupuesto(string cliente, string direccion)
        {
            Cliente = cliente;
            Direccion = direccion;
        }
        public void AgregarProducto(Producto p)
        {
            presupuestados.Add(p);
        }
        public Producto VerProducto(int idx)
        {
            return (Producto)presupuestados[idx];
        }
    }
}
