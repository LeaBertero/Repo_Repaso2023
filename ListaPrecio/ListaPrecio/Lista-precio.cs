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
        //matrices [,] = dos dimensiones
        private string[,] Producto = new string[3, 2];
        decimal[] Precio = new decimal[3];

        private int Fila = 0;

        //constructores
        public Lista_precio()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs botonCerrar)
        {
            Close();
            BtSalir.Focus();

        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            BtAceptar.Focus();


            if (Fila > 2)
            {
                LblError.Text = "Solo se aceptan 3 productos";
                LblError.Visible = true;
            }
            else
            {
                //matriz bidimensional
                Producto[Fila, 0] = TxCodigo.Text;
                Producto[Fila, 1] = TxProducto.Text;

                //Matriz unidimensional
                Precio[Fila] = Convert.ToDecimal(TxPrecio.Text);

                //contador de fila, para pasar a ka siguiente carga de producto
                Fila = Fila + 1;

                TxCodigo.Text = null;
                TxPrecio.Text = null;
                TxProducto.Text = null;

            }


        }

        private void BtListar_Click(object sender, EventArgs e)
        {
            BtListar.Focus();

            //lblListaPrecio.Text = "Lista de precios" + "\r\n";

            for (int incremento = 0; incremento < Precio.Length; incremento++)
            {
                lblListaPrecio.Text = lblListaPrecio.Text +
                    Producto[incremento, 0] + " " +
                    Producto[incremento, 1] + " .. " +
                    Precio[incremento].ToString()
                    + "\r\n";
            }
        }

      
    }
}
