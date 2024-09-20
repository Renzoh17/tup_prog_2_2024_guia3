using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Cooperativa
    {
        public string RazonSocial {  get; set; }
        public string Cuit {  get; set; }
        public Domicilio UbicadaEn { get; set; }
        private ArrayList asociado = new ArrayList();
        
        public Cooperativa(string razonSocial, string cuit, Domicilio ubicadaEn, Socio socio)
        {
            RazonSocial = razonSocial;
            Cuit = cuit;
            UbicadaEn = ubicadaEn;
            asociado.Add(socio);
        }
        public void AgregarSocio(Socio socio)
        {
            asociado.Add(socio);
        }
    }
}
