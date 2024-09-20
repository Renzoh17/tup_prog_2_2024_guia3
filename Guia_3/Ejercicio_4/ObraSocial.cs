using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class ObraSocial : Prestacion
    {
        public double Arancel = 200;
        private int consultasMensuales;
        public int ConsultasMensuales { get { return consultasMensuales; } }

        public ObraSocial(string nombre, Prestador medico) : base(nombre, medico)
        {
            consultasMensuales = 2;
        }
        public override double PrestarServicio()
        {
            if (consultasMensuales > 0)
            {
                consultasMensuales--;
                return MontoTotal;  
            }
            montoTotal = Arancel;
            Medico.AgregarConsulta(this);
            return MontoTotal;
        }
    }
}
