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
    public partial class FrmNuevo : Form
    {
        public FrmNuevo()
        {
            InitializeComponent();
        }

        private void FrmNuevo_Load(object sender, EventArgs e)
        {
            BackColor = Color.DarkKhaki;
        }

        private void BtSalir2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
