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
            int anchoFormulario = this.Width;
            int anchoLabel = LblMov.Width;
            int anchoBorde = 20;
            int x = 0;
            int paso = 1;

            //for (int x = 0;
            //    x < anchoFormulario - anchoLabel - anchoBorde;
            //    x++)
            //{
            //    LblMov.Left = x;
            //    LblMov.Refresh();
            //}

            while (x < anchoFormulario - anchoLabel - anchoBorde)
            {
                LblMov.Left = x;
                x = x + paso;
                this.Refresh();
            }
        }
    }
}