using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Medidor
    {
        public int NroMedidor { get; set; }
        public int LecturaAnterior { get; set; }
        int lecturaActual;
        public int LecturaActual
        {
            get { return lecturaActual; }
            set { lecturaActual = value; }
        }

        public int ConsumoActual()
        {
            return LecturaActual - LecturaAnterior;
        }
        public void Medicion(int lectura)
        {
            LecturaActual = lectura;
        }
    }
}
