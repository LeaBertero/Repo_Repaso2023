namespace Matrices
{
    public partial class Matrices : Form
    {
        //lista de arreglos
        string[] Lista = new string[10];
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

                LblRes.Text = LblRes.Text + TxIngreso.Text + "\r\n";

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

        private void Bt_Matrices2_Click(object sender, EventArgs e)
        {
            var matrices_2 = new Matrices_2();
            matrices_2.ShowDialog();
        }
    }
}