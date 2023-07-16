namespace Projeto_Integrador
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja cadastrar?", "Confirmação", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Conexao db = new Conexao();
                db.Conectar();

                Titular novoTitular = new Titular();
                novoTitular.nome = textBox1.Text;
                novoTitular.cpf = textBox2.Text;
                novoTitular.email = textBox4.Text;
                novoTitular.senhaTitular = textBox3.Text;
                string confirmarSenha = textBox5.Text;

                // Ver se tem campos não preenchidos
                if (string.IsNullOrEmpty(novoTitular.nome) || string.IsNullOrEmpty(novoTitular.cpf) || string.IsNullOrEmpty(novoTitular.email) || string.IsNullOrEmpty(novoTitular.senhaTitular) || string.IsNullOrEmpty(confirmarSenha))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.");
                    return;
                }

                // Validar se a senha e a confirmação de senha são iguais
                if (novoTitular.senhaTitular != confirmarSenha)
                {
                    MessageBox.Show("A senha e a confirmação de senha não coincidem.");
                    textBox5.Text = "";
                    return;
                }

                bool inserido = db.InserirCadastro(novoTitular.nome, novoTitular.cpf, novoTitular.email, novoTitular.senhaTitular);

                if (inserido)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar");
                }
            }
        }
        private void LimparCampos()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }
    }
}