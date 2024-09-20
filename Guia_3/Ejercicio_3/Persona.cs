using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Persona
    {
        public int Dni {  get; set; }
        public string Apellidos {  get; set; }
        public string Nombres {  get; set; }
        private int edad;
        public int Edad()
        {
            return edad;
        }
        public Persona(string apellidos, string nombres, int dni, int edad)
        {
            Dni = dni;
            Apellidos = apellidos;
            Nombres = nombres;
            this.edad = edad;
        }
    }
}
