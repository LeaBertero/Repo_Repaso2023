﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oper_parte2
{
    public partial class FormOperadores : Form
    {
        public FormOperadores()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSegundo_Click(object sender, EventArgs e)
        {
            var segundo = new segundoFrm();
            segundo.ShowDialog();
        }
    }
}
