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

namespace Ejercicio_3
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
            ArrayList servicios = new ArrayList();
            ArrayList socios = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                Medidor mdd = new Medidor();
                mdd.NroMedidor = i;
                Domicilio dmc = new Domicilio();
                Servicio srv = new Servicio(mdd, dmc);
                servicios.Add(srv);
            }

            for (int i = 0; i < 10; i++)
            {
                Domicilio dmc = new Domicilio();
                Socio nuevo = new Socio("apellido" + i, "nombres" + i, i, rnd.Next(100000000), rnd.Next(1, 100), (Servicio)(servicios[i]), dmc);
                socios.Add(nuevo);
            }

            string rzn = "La Juana";
            string cuit = "20" + rnd.Next(10000000, 100000000).ToString() + "2";
            Domicilio ubi = new Domicilio();
            Cooperativa laJuana = new Cooperativa(rzn, cuit, ubi, (Socio)socios[0]);

            for (int i = 0; i < 10; i++)
            {
                Domicilio dmc = new Domicilio();
                laJuana.AgregarSocio((Socio)socios[i]);
            }

            int selectedPeriodo = 9;
            for (int i = 0; i < selectedPeriodo; i++)
            {
                foreach (Servicio selectedServ in servicios)
                {
                    int consumoAnterior = selectedServ.medidoPor.LecturaActual;
                    int lecturaActual = consumoAnterior + rnd.Next(2000);
                    selectedServ.RegistrarConsumo(lecturaActual);
                }
            }
            
            lbPrueba.Items.Clear();
            lbPrueba.Items.Add($"{"Periodo", -10}{"Consumo",10}");

            foreach (Socio selectedSos in socios)
            {
                string titularNro = selectedSos.NroSocio.ToString("000000");
                string nroMedidor = selectedSos.Servicio.medidoPor.NroMedidor.ToString("000000");
                int periodo = selectedSos.Servicio.Periodo;
                lbPrueba.Items.Add($"{titularNro,-10}{nroMedidor,10}");
                for (int i = 0; i < selectedSos.Servicio.CantidadConsumos; i++)
                {
                    string consumo = selectedSos.Servicio[i].ToString("0.00");
                    lbPrueba.Items.Add($"{i + selectedSos.Servicio.Periodo % 6, -10}{consumo, 10}");
                }
                lbPrueba.Items.Add("---");
            }
        }
    }
}
