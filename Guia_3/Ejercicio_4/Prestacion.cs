using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal abstract class Prestacion : Persona
    {
        protected double montoTotal = 0;
        public double MontoTotal { get { return montoTotal; } }
        protected Prestador Medico;
        public Prestacion(string apellidosNombresPersona, Prestador medico) : base(apellidosNombresPersona)
        {
            Medico = medico;
        }
        public abstract double PrestarServicio();
    }
}
