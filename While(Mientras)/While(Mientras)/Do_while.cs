using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Mientras_
{
    public partial class Do_while : Form
    {

        int anchoFormulario;
        int anchoLabel;
        int anchoBorde;
        int x = 0;
        int paso = 1;

        public Do_while()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtIniciar_Click(object sender, EventArgs e)
        {

        }

        private void btContar_Click(object sender, EventArgs e)
        {


        }
    }
}
