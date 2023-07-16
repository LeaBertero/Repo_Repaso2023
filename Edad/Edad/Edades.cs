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
                    LblRes.Text = "Aplazado";
                    break;
                case 3:
                    LblRes.Text = "Aprobado";
                    break;
                case 4:
                    LblRes.Text = "promocionado";
                    break;
                case 5:
                    LblRes.Text = "Promocionado";
                    break;
                default:
                    LblRes.Text = "Nota no valida";
                    break;

            }
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            TxtNota.Text = null;
            LblRes.Text = null;
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}