using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Mientras_
{
    public partial class Do_while : Form
    {
        public Do_while()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btcerrar_Click(object sender, EventArgs e)
        {
            //condicion para cerrar el formulario
            if (TxIngreso.Text == "Salir")
            {
                LblMensaje.Text = "Ingreso correcto";
            }
            else
            {
                LblMensaje.Text = "Debe ingresar un valor";
            }
        }

        private void BtNuevo3_Click(object sender, EventArgs e)
        {
            var nuevoArrarnque = new FormPrueba();
            nuevoArrarnque.ShowDialog();
        }
    }
}
