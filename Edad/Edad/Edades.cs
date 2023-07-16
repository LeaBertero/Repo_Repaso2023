namespace Edad
{
    public partial class Edades : Form
    {
        public Edades()
        {
            InitializeComponent();
        }

        private void Edades_Load(object sender, EventArgs e)
        {
            BackColor = Color.HotPink;
        }

        private void BtRes_Click(object sender, EventArgs e)
        {
            int nota = Convert.ToInt32(TxtNota.Text);

            switch (nota)
            {
                case 1:
                    LblRes.Text = "Aplazado";
                    break;
                case 2:
                    LblRes.Text = "";
                    break;

            }
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            TxtNota.Text = null;
            LblRes.Text = null;
        }
    }
}