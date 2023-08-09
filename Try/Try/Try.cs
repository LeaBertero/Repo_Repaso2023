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

        //decimal suma;
        //decimal resta;
        //decimal mult;
        //string div;

        public Try()
        {
            InitializeComponent();
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                LbRes.Text = (Convert.ToDecimal(TxDiv1.Text) /
                Convert.ToDecimal(TxDiv2.Text)).ToString();

                //if (Convert.ToString(TxOperDiv.Text) == "/")
                //{

                //}
                //else
                //{
                //    MessageBox.Show("Imposible dividir");
                //}


                //LbRes.Text = (Convert.ToDecimal(TxMult1.Text) *
                //Convert.ToDecimal(TxMult2.Text)).ToString();



                LbRes.Visible = true;

            }
            catch (Exception)
            {
                //Forma 2:llamando a una ventana emergente , incluyendo un aviso de error
                MessageBox.Show("Dato ingresado es invalido");


                //forma 3: a travez de una label directo poniendo en false y pasando luego a true en el codigo

                //LbMensaje.Visible = true;
                //LbMensaje.Text = "Dato ingresado es invalido";


                // Forma 1: mensaje con variable de error a tra vez de un label
                // (Mensaje adaptado al software desarrollador, en este caso por medio de un label).

                //LbMensaje.Text = mensajeErr.Message;
                //LbMensaje.Visible = true;
            }
        }


        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            TxDiv1.Text = null;
            TxDiv2.Text = null;
            LbRes.Text = null;
        }
    }
}








