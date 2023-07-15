using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            BackColor = Color.BlueViolet;
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtNuevo_Click(object sender, EventArgs e)
        {
            var Nuewformulario = new FrmNuevo();
            Nuewformulario.ShowDialog();
        }
    }
}
