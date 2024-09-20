using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Socio : Persona
    {
        public int NroSocio { get; set; }
        private Domicilio viveEn;
        public Domicilio ViveEn { get {  return viveEn; } }
        private Servicio servicio;
        public Servicio Servicio { 
            get { return servicio; }
            set
            {
                servicio = value;
                servicio.socios.Add(this);
            }
        }
        public Socio(string apellidos, string nombres, int dni, int edad, int nroSocio, Servicio srv, Domicilio dmc):base(apellidos, nombres, dni, edad)
        {
            NroSocio = nroSocio;
            Servicio = srv;
        }
        public void AgregarServicio(Servicio nuevoSrv)
        {
            Servicio = nuevoSrv;
        }
        public void CambiarDomicilio(Domicilio nuevoDmc)
        {
            viveEn = nuevoDmc;
        }
    }
}
