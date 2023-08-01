using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores
{
    public partial class FormPrueba : Form
    {
        int contador = 0;

        public FormPrueba()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtComenzar_Click(object sender, EventArgs e)
        {

            ++contador;
            LblContar.Text = Convert.ToString(contador);

        }
    }
}
