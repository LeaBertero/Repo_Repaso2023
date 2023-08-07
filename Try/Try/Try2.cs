using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try
{
    public partial class Try2 : Form
    {
        public Try2()
        {
            InitializeComponent();
        }

        private void BtCalculo_Click(object sender, EventArgs e)
        {
            LbRes.Text = (Convert.ToDecimal(TxNum1.Text) +
                Convert.ToDecimal(TxNum2.Text)).ToString();
        }
    }
}
