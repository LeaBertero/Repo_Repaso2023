using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploFor
{
    public partial class siguiente : Form
    {
        public siguiente()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtComenzar_Click(object sender, EventArgs e)
        {
            for (int contador = Convert.ToInt32(TxDesde1.Text);
                contador <= Convert.ToInt32(TxHasta2.Text); 
                contador = contador + Convert.ToInt32(TxPaso3.Text))
            {

                LblResultado.Text = contador.ToString();
                this.Refresh();


            }
        }


    }
}
