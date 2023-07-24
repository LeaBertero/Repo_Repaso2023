using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPrecio
{
    public partial class Lista_precio : Form
    {
        public Lista_precio()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
            BtSalir.Focus();

        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            BtAceptar.Focus();
        }

        private void BtListar_Click(object sender, EventArgs e)
        {
            BtListar.Focus();
        }
    }
}
