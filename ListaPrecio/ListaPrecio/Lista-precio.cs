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
        private string[,] Producto = new string[3, 2]; //3 filas - 2 columnas
        decimal[] Precio = new decimal[3]; //Matriz de 3 filas

        //Fila, es una variable privada que solamente se utiliza en el boton aceptar y se utiliza en la clase formulario
        private int Posicion = 0; //Variable --Inicialmente con un valor de cero

        //constructor
        public Lista_precio() //<-- Clase
        {
            InitializeComponent(); // --> Metodo
        }

        private void BtSalir_Click(object sender, EventArgs botonCerrar)
        {
            Close();
            BtSalir.Focus();

        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {

            BtAceptar.Focus();

            if (Posicion >= 2)
            {
                LblError.Text = "Solo se aceptan 3 productos";
                LblError.Visible = true;
            }
            else
            {
                //matriz bidimensional
                Producto[Posicion, 0] = TxCodigo.Text;
                Producto[Posicion, 1] = TxProducto.Text;

                //Matriz unidimensional
                Precio[Posicion] = Convert.ToDecimal(TxPrecio.Text);

                //contador de posicion, para que vaya incrementando el conteo de los productos los codigos y los precios 
                //a medidda que se vayan ingresando
                Posicion = Posicion + 1;

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
                    Producto[incremento, 0] + " - " +
                    Producto[incremento, 1] + " - " +
                    Precio[incremento].ToString()
                    + "\r\n";
            }
        }

      
    }
}
