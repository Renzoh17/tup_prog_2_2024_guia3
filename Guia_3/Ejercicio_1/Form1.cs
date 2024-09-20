using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Producto m = new Mesa("Comedor", 10.1, 1, 1);
            Producto s = new Silla("Escritorio", 12.2, 2);
            lbPrueba.Items.Clear();
            lbPrueba.Items.Add(m.VerDetalle());
            lbPrueba.Items.Add(s.VerDetalle());
        }
    }
}
