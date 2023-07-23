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
        string[] Lista;
        int posicion = 0;

        //Constructor
        public Matrices_2()
        {
            InitializeComponent();
            BtAgregar.Enabled = false;
            Btlistar.Enabled = false;
        }

        //evento del boton salir
        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //evento del boton agregar
        private void BtAgregar_Click(object sender, EventArgs e)
        {
            Lista[posicion] = TXingreso.Text;
            posicion = posicion + 1; //incremento de posicion a medida que se presione enter

            //LblRes.Text = LblRes.Text + TXingreso.Text + "\r\n";

            TXingreso.Text = "";
            TXingreso.Focus();
        }

        //evento del boton listar = (Realizar una lista de los elemtnos agregados por el usuario)
        private void Btlistar_Click(object sender, EventArgs e)
        {
            for (int incremento = 0; incremento < Lista.Length; incremento++)
            {
                LblRes.Text = LblRes.Text + Lista[incremento] + "\r\n";
            }
        }

        private void BtDimension_Click(object sender, EventArgs e)
        {
            Lista = new string[Convert.ToInt32(TxCantidad.Text)];
            posicion = 0;
            BtAgregar.Enabled = true;
            Btlistar.Enabled = true;
        }
    }


}
