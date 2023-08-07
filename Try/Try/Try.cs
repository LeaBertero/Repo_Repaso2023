using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try
{
    public partial class Try : Form
    {
        public Try()
        {
            InitializeComponent();
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                LbRes.Text = (Convert.ToDecimal(Txnum1.Text) /
                Convert.ToDecimal(TxNum2.Text)).ToString();

                LbRes.Visible = true;

            }
            catch (Exception)
            {

                MessageBox.Show("Dato ingresado es invalido");


                //LbMensaje.Visible = true;
                //LbMensaje.Text = "Dato ingresado es invalido";
            }
        }


        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}








