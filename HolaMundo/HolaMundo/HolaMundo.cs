namespace HolaMundo
{
    public partial class HolaMundo : Form
    {
        public HolaMundo()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            LblMensaje.Text = "Estoy haciendo el Hola Mundo inicial";
            LblMensaje.Visible = true;

            //Close();
        }

        private void Btcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}