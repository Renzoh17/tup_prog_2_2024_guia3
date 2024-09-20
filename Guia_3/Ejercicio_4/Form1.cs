using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ArrayList prestadores = new ArrayList();
            ArrayList prestaciones = new ArrayList();
            lbPrueba.Items.Clear();

            prestadores.Add(new Prestador("Medico " + 1));
            prestadores.Add(new Prestador("Medico " + 2));

            prestaciones.Add(new ObraSocial("Juan", (Prestador)prestadores[0]));
            prestaciones.Add(new SinObra("Renata", (Prestador)prestadores[1], "20437560014"));

            Prestacion selectedConsulta = null;
            double montoAPagar = 0;

            for(int i = 0; i < 2; i++)
            for (int j = 0; j < 3; j++)
            {
                selectedConsulta = (Prestacion)prestaciones[i];
                montoAPagar = selectedConsulta.PrestarServicio();
                lbPrueba.Items.Add($"Consulta de {selectedConsulta.ApellidosNombres}, Monto: ${montoAPagar:f2}");
            }
            
            foreach(Prestador medico in prestadores)
            {
                lbPrueba.Items.Add($"Médico: {medico.ApellidosNombres}, Monto a Cobrar: ${medico.GenerarPago():f2}");
            }

        }
    }
}
