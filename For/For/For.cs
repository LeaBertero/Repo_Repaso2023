namespace For
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void BtIniciar_Click(object sender, EventArgs e)
        {
            Lbdesplazar.Visible = true; //label invisible pasado a true

            //int anchoformulario;

            int x = Convert.ToInt32(TxValorIni.Text); //variable declarada afuera de la estructura de for


            for (int velocidad = x; velocidad < 900; velocidad++)
            {
                Lbdesplazar.Left = velocidad;


                this.Refresh();
            }


        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}