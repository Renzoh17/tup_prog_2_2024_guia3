using Ejercicio_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        Presupuesto presupuesto;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarP_Click(object sender, EventArgs e)
        {
            FormDatosCliente vtnDC = new FormDatosCliente();
            if (vtnDC.ShowDialog() == DialogResult.OK)
            {
                presupuesto = new Presupuesto(vtnDC.tbNombre.Text, vtnDC.tbDireccion.Text);
                lbNombre.Text = $"Nombre: {vtnDC.tbNombre.Text}";
                lbDireccion.Text = $"Direccion: {vtnDC.tbDireccion.Text}";
                lbCantProduc.Text = $"Cantidad de Productos: {presupuesto.CantidadProductos}";
                btnAgregarProduc.Enabled = true;
                btnVerP.Enabled = true;
                btnIniciarP.Enabled = false;
            }
            vtnDC.Dispose();
        }

        private void btnAgregarProduc_Click(object sender, EventArgs e)
        {
            FormDatosProducto vtnDP = new FormDatosProducto();
            if (vtnDP.ShowDialog() == DialogResult.OK)
            {
                int idx = vtnDP.cbTipoProduc.SelectedIndex;
                Producto p = null;
                if (idx == 0)
                {
                    p = new Mesa(vtnDP.tbDescripcion.Text, Convert.ToDouble(vtnDP.tbPrecio.Text), vtnDP.cbMaterial.SelectedIndex, Convert.ToDouble(vtnDP.tbLargo.Text));
                }
                else if (idx == 1)
                {
                    p = new Silla(vtnDP.tbDescripcion.Text, Convert.ToDouble(vtnDP.tbPrecio.Text), vtnDP.cbMaterial.SelectedIndex);
                }
                presupuesto.AgregarProducto(p);
                lbCantProduc.Text = $"Cantidad de Productos: {presupuesto.CantidadProductos}";
            }
            vtnDP.Dispose();
        }

        private void btnVerP_Click(object sender, EventArgs e)
        {
            FormVerPresupuesto vtnVP = new FormVerPresupuesto();
            vtnVP.tbVerP.Clear();
            vtnVP.tbVerP.Text += $@"Cliente: {presupuesto.Cliente}
Direccion: {presupuesto.Direccion}

Items Presupuestados:
";
            for (int i = 0; i < presupuesto.CantidadProductos; i++)
            {
                vtnVP.tbVerP.Text += $"{presupuesto.VerProducto(i).VerDetalle()}\r\n"; 
            }
            vtnVP.tbVerP.Text += $@"{"Total:"}{presupuesto.CostoTotal,60:f2}";
            vtnVP.ShowDialog();
            vtnVP.Dispose();
        }

        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            btnIniciarP.Enabled = true;
            btnAgregarProduc.Enabled = false;
            btnVerP.Enabled = false;
            lbNombre.Text = "Nombre: -";
            lbDireccion.Text = "Direccion: -";
            lbCantProduc.Text = "Cantidad de Productos: -";
        }
    }
}
