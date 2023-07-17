using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploFor
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtBorrar_Click(object sender, EventArgs e)
        {
            TxtDesde.Text = null;
            TxtHasta.Text = null;
            LblRes.Text = null;

        }

        private void Btaceptar_Click(object sender, EventArgs e)
        {
            for (int i = Convert.ToInt32(TxtDesde.Text); i < 10; i++)
            {

            }

           
        }
    }
}
