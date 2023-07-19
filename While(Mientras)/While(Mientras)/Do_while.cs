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
        int x;
        int paso;
        int contador = 0;
        int Totalcontador = 5;

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

            do
            {
                anchoFormulario = this.Width;
                anchoLabel = LblMov.Width;
                anchoBorde = 20;
                x = 0;
                paso = 1;
                contador = contador + 1; //contador = contador +1;

                while (true)
                {

                    while(x < (anchoFormulario - anchoBorde - anchoLabel))
                    {
                        
                        LblMov.Left = x;
                        this.Refresh();
                        x = x + paso;


                    }


                }
                
            } while (contador < Totalcontador);
                
        }

    }

}





