using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoWhile
{
    public partial class Dowhile : Form
    {
        public Dowhile()
        {
            InitializeComponent();
        }

        private void Btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtMover_Click(object sender, EventArgs e)
        {
            do
            {
                //variables inicializadas y con un valor de + 1 , para wue vayan contando de a uno
                rojo.Left = rojo.Left + 1;
                azul.Left = azul.Left - 1;

                this.Refresh();
                //break;

                //MessageBox.Show("Choque frontal");

            } while ((rojo.Left + rojo.Width) != azul.Left);
        }


    }
}









