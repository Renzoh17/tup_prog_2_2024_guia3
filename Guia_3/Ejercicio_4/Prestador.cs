using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Prestador : Persona
    {
        ArrayList consultas = new ArrayList();
        public Prestador(string apellidosNombres) : base(apellidosNombres)
        {
        }
        public void AgregarConsulta(Prestacion consulta)
        {
            consultas.Add(consulta);
        }
        public double GenerarPago()
        {
            double pago = 0;
            foreach (Prestacion m in consultas) pago += m.MontoTotal;
            return pago;
        }
    }
}
