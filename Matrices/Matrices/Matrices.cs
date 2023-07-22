namespace Matrices
{
    public partial class Matrices : Form
    {
        //lista de arreglos
        string[] Lista = new string[3];
        int posicion = 0;

        public Matrices()
        {
            InitializeComponent();
        }

        private void BtInicio_Click(object sender, EventArgs e)
        {
            try
            {
                Lista[posicion] = TxIngreso.Text;
                posicion = posicion + 1;

                //LblRes.Text = LblRes.Text + TxIngreso.Text + "\r\n";

                TxIngreso.Text = "";
                TxIngreso.Focus();
            }
            catch (Exception)
            {

                lblMensaje.Text = "Limite de carga, completo";
                lblMensaje.BackColor = Color.Black;
                lblMensaje.Visible = true;
            }


        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtListar_Click(object sender, EventArgs e)
        {
            for (int incremento = 0; incremento < Lista.Length; incremento++)
            {
                LblRes.Text = LblRes.Text + Lista[incremento] + "\r\n";

            }

        }

        private void BtBorrar_Click(object sender, EventArgs e)
        {
            LblRes.Text = null;
            TxIngreso.Text = null;
            lblMensaje.Text = null;
        }
    }
}