namespace Cadena_dato
{
    public partial class FrmDato : Form
    {
        public FrmDato()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btconvert_Click(object sender, EventArgs e)
        {
            LblRes.Visible = true;

            string cadena;
            LblRes.Text = TXDato.Text;

            cadena = TXDato.Text.Substring(0,1).ToUpper() + TXDato.Text.Substring(1).ToLower(); ;

            LblRes.Text = cadena;
            //cadena = TXDato.Text.Trim();

        }
    }
}