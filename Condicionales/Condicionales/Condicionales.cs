namespace Condicionales
{
    public partial class Condicionales : Form
    {
        //constructor
        public Condicionales()
        {
            InitializeComponent();
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            decimal numero1;
            decimal numero2;
            decimal resultado;

            if (TxOperador.Text == "")
            {
                MessageBox.Show("Debe ingresar un operador para realizar la suma correspondiente");
            }


            if (TxOperador.Text == "+")
            {

                numero1 = Convert.ToInt32(TxNum1.Text);
                numero2 = Convert.ToInt32(TxNum2.Text);

                resultado = numero1 + numero2;

                LblResultado.Text = resultado.ToString();

                //resultado = Convert.ToString(numero1) + Convert.ToString(numero2);

                LblResultado.ToString();

                LblResultado.Visible = true;
            }
            else if (TxOperador.Text == "-")
            {
                numero1 = Convert.ToInt32(TxNum1.Text);
                numero2 = Convert.ToInt32(TxNum2.Text);

                resultado = numero1 - numero2;

                LblResultado.Text = resultado.ToString();

                //resultado = Convert.ToString(numero1) + Convert.ToString(numero2);

                LblResultado.ToString();

                LblResultado.Visible = true;
            }
            else if (TxOperador.Text == "*")
            {
                numero1 = Convert.ToInt32(TxNum1.Text);

                numero2 = Convert.ToInt32(TxNum2.Text);

                resultado = numero1 * numero2;

                LblResultado.Text = resultado.ToString();

                //resultado = Convert.ToString(numero1) + Convert.ToString(numero2);

                LblResultado.ToString();

                LblResultado.Visible = true;
            }
            else if (TxOperador.Text == "/")
            {
                numero1 = Convert.ToInt32(TxNum1.Text);
                numero2 = Convert.ToInt32(TxNum2.Text);

                resultado = numero1 / numero2;


                LblResultado.Text = resultado.ToString();

                //resultado = Convert.ToString(numero1) + Convert.ToString(numero2);

                LblResultado.ToString();

                LblResultado.Visible = true;
            }

        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void BtLimpiar_Click(object sender, EventArgs e)
        {
            TxNum1.Text = null;
            TxNum2.Text = null;
            TxOperador.Text = null;
            LblResultado.Text = null;

        }
    }
}










