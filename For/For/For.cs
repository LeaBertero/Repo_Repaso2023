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


            for (int velocidad = x; velocidad < 1000; velocidad++)
            {
                Lbdesplazar.Left = velocidad;


                this.Refresh();
            }


        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtComenzar_2_Click(object sender, EventArgs e)
        {
            LblMover2.Visible = true;

            int left = Convert.ToInt32(TxLeft.Text);

            for (int avanceIzquierdo = left; avanceIzquierdo < 1200; avanceIzquierdo++)
            {
                LblMover2.Left = left;

                this.Refresh();
            }



        }
    }
}