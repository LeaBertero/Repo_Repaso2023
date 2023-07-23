using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices
{
    public partial class Matrices_2 : Form
    {
        //instanciando el objeto
        string[] Lista = new string[4];
        int posicion = 0;

        public Matrices_2()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            Lista[posicion] = TXingreso.Text;
            posicion = posicion + 1; //incremento de posicion a medida que se presione enter

            //LblRes.Text = LblRes.Text + TXingreso.Text + "\r\n";
            
            TXingreso.Text = null;
            TXingreso.Focus();
        }

        private void Btlistar_Click(object sender, EventArgs e)
        {
            for (int incremento = 0; incremento < Lista.Length; incremento++)
            {
                LblRes.Text = LblRes.Text + Lista[incremento] + "\r\n";
            }
        }
    }


}
