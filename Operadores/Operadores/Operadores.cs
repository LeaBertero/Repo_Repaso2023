namespace Operadores
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            //asignacion de variables
            decimal oper1 = Convert.ToDecimal(Txoper1.Text);
            decimal oper2 = Convert.ToDecimal(Txoper2.Text);

            decimal res = oper1 + oper2;

            //LblResultado.Text = Txoper1.Text + Txoper2.Text;
            LblResultado.Text = Convert.ToString(res);
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            BackColor = Color.Gray;
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            Txoper1.Text = null;
            Txoper2.Text = null;    
        }
    }
}