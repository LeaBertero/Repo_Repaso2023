using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPrecio
{
    public partial class Lista_precio : Form
    {
        //matrices
        private string[,] Producto = new string[3, 2];
        private decimal[] Precio = new decimal[3];

        private int Fila = 0;
        
        public Lista_precio()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
            BtSalir.Focus();

        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            BtAceptar.Focus();

            //matriz bidimensional
            Producto[Fila, 0] = TxCodigo.Text;
            Producto[Fila, 1] = TxProducto.Text;

            //Matriz unidimensional
            Precio[Fila] = Convert.ToDecimal(TxPrecio.Text);

            //contador de fila, para pasar a ka siguiente carga de producto
            Fila = Fila + 1;


        }

        private void BtListar_Click(object sender, EventArgs e)
        {
            BtListar.Focus();
        }
    }
}
