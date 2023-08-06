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

        //temporalmente desactivado
        private void Comenzar_Click(object sender, EventArgs e)
        {
            while ((blue.Left - blue.Width) == red.Left)
            {
                red.Left = red.Left - 1;
                blue.Left = blue.Left + 1;

                this.Refresh();
                //break;
            }

        }

        private void BtMover_Click(object sender, EventArgs e)
        {

            while ((rojo.Left + rojo.Width) == azul.Left)
            {
                rojo.Left = rojo.Left + 1;
                azul.Left = azul.Left - 1;


                this.Refresh();
                break;
            }

        }

    }
}
