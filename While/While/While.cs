﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class While : Form
    {
        public While()
        {
            InitializeComponent();
        }

        private void BtIniciar_Click(object sender, EventArgs e) //evento click - (BtIniciar_Click)
        {
            while (true)
            {
                picArg.Left = picArg.Left + 1;
                picFra.Left = picFra.Left - 1;

                this.Refresh();

                if ((picArg.Left + picArg.Width) == picFra.Left)
                {
                    LblMensaje.Visible = true;
                    //MessageBox.Show("ARGENTINA CAMPEÓN DEL MUNDO 2023");
                    break;
                }
            }
        }
        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtAcomodar_Click(object sender, EventArgs e)
        {
            picArg.Visible = true;
            picFra.Visible = true;

            picArg.Top = 190;
            picFra.Top = 190;



            //370 es el numero para la bandera de francia
        }


    }
}




