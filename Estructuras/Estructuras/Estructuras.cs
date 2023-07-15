using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            BackColor = Color.BlueViolet;
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtNuevo_Click(object sender, EventArgs e)
        {
            var Nuewformulario = new FrmNuevo();
            Nuewformulario.ShowDialog();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(TxIngreso.Text);

            if (edad < 12)
            {
                LblResultado.Text = "Es un niño ";
            }
            else if (edad >= 12 && edad < 18)
            {
                LblResultado.Text = "Adolescente";
            }
            else if(edad >= 18 && edad > 60)
            {
                LblResultado.Text = "Adulto";
            }
            else
            {
                LblResultado.Text = "Adulto mayor";
            }
        }

        private void Btlimpiar_Click(object sender, EventArgs e)
        {
            TxIngreso.Text = null;
        }
    }
}
