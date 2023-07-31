using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrueba
{
    public partial class FrmInicio : Form
    {

        int operador1;
        int operador2;
        int resultado;
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void BtRes_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxOperador.Text == "+")
                {
                    LblRes.Visible = true;

                    operador1 = Convert.ToInt32(TxNum1.Text);
                    operador2 = Convert.ToInt32(TxNum2.Text);

                    resultado = operador1 + operador2;

                    LblRes.Text = resultado.ToString();
                }
                else if (TxOperador.Text == "-")
                {
                    LblRes.Visible = true;

                    operador1 = Convert.ToInt32(TxNum1.Text);
                    operador2 = Convert.ToInt32(TxNum2.Text);

                    resultado = operador1 - operador2;

                    LblRes.Text = resultado.ToString();
                }
                else if (TxOperador.Text == "*")
                {
                    LblRes.Visible = true;

                    operador1 = Convert.ToInt32(TxNum1.Text);
                    operador2 = Convert.ToInt32(TxNum2.Text);

                    resultado = operador1 * operador2;

                    LblRes.Text = resultado.ToString();
                }
                else if (TxOperador.Text == "/")
                {
                    LblRes.Visible = true;

                    operador1 = Convert.ToInt32(TxNum1.Text);
                    operador2 = Convert.ToInt32(TxNum2.Text);

                    resultado = operador1 / operador2;

                    LblRes.Text = resultado.ToString();
                }


            }
            catch
           (Exception)
            {

                MessageBox.Show("No puede ingresar valores no autorizados");

            }

        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
