using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Servicio
    {
        private ArrayList Consumos = new ArrayList();
        public int CantidadConsumos { get { return Consumos.Count; } }
        private int periodo;
        public int Periodo
        {
            get { return periodo; }
            private set
            {
                if (CantidadConsumos >= 7) Consumos.RemoveAt(0);
                periodo = value % 6;
            }
        }
        public int this[int nro]
        {
            get
            {
                return (int)Consumos[nro];
            }
        }
        public DateTime FechaAlta { get; set; }
        public Medidor medidoPor { get; set; }
        public Domicilio prestadoEn { get; set; }
        public ArrayList socios {  get; set; }

        public Servicio(Medidor mdd, Domicilio dmc)
        {
            medidoPor = mdd;
            prestadoEn = dmc;
        }
        public void CambioTitular(Socio titularBaja, Socio titularAlta)
        {
            socios.Remove(titularBaja);
            socios.Add(titularAlta);
        }
        public void RegistrarConsumo(int medicion)
        {
            Periodo++;
            Consumos.Add(medidoPor.ConsumoActual());
            medidoPor.LecturaAnterior = medidoPor.LecturaActual;
            medidoPor.LecturaActual = medicion;
        }

    }
}
