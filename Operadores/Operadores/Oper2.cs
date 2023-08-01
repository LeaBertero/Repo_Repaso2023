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
    public partial class Oper2 : Form
    {
        //decimal num1;
        //decimal num2;
        //decimal resultado;
        
        int incremento = 0;

        public Oper2()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num1 = Convert.ToDecimal(TxCalc1.Text);
                decimal num2 = Convert.ToDecimal(TxCalc2.Text);

                decimal resultado = resultado = num1 - num2;

                LbRes.Text = resultado.ToString();

                LbRes.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Debe ingresar dos valores para realizar la operación");
            }

        }

        private void LblContador_Click(object sender, EventArgs e)
        {

            Lblincremento.Text = System.Convert.ToString(incremento);

            //++incremento;  //funciona

            incremento = incremento + 1; //funciona

            Lblincremento.Visible = true;
        }
    }
}
