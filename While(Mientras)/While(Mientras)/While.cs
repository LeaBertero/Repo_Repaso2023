namespace While_Mientras_
{
    public partial class While : Form
    {
        public While()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtNuevo_Click(object sender, EventArgs e)
        {
            var nuevoejemplo = new Do_while();
            nuevoejemplo.ShowDialog();
        }

        private void BtIniciar_Click(object sender, EventArgs e)
        {

        }
    }
}