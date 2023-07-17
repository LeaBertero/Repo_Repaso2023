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
            TxtDesde.Text = null; //Desde
            TxtHasta.Text = null; //Hasta
            TxtPaso.Text = null; //Paso
            LblRes.Text = null;

        }

        private void Btaceptar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int contador = Convert.ToInt32(TxtDesde.Text);
               contador <= Convert.ToInt32(TxtHasta.Text);
               contador = contador + Convert.ToInt32(TxtPaso.Text))

                {

                    LblRes.Text = contador.ToString();
                    this.Refresh();

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar los valores para contar");

            }


        }

        //private void BtNuevo_Click(object sender, EventArgs e)
        //{
        //    var newForm = new Form();
        //    newForm.ShowDialog();
        //}
    }
}
