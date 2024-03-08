namespace TP_03___PROJETO_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSalario.Enabled = false;
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = txtNome.Text;
            funcionario.QtdHoras = txtQtd.Text;
            funcionario.HoraTrabalhada = txtHora.Text;

            FuncBLL.ValidarDados(funcionario);

            if (Erro.TemErro)
            {
                MessageBox.Show(Erro.Mensagem);
            }
            else
            {
                txtSalario.Text = funcionario.getSalario();

                txtNome.Enabled = false;
                txtHora.Enabled = false;
                txtQtd.Enabled = false;
            }

            

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtHora.Clear();
            txtQtd.Clear();
            txtSalario.Clear();
            txtNome.Enabled = true;
            txtHora.Enabled = true;
            txtQtd.Enabled = true;

        }
    }
}