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
            //Conexao db = new Conexao();
            //db.Conectar();

            // --- classe ---
            // usuario.nome = textBox1.Text;
            // usuario.cpf = textBox2.Text;
            // usuario.e-mail = textBox4.Text;
            // usuario.senha = textBox3.Text;
            // usuario.confirmarSenha = textBox5.Text;

            // Ver se tem campos não preenchidos
            // if (usuario.IsNullOrEmpty(nome) || usuario.IsNullOrEmpty(cpf) || usuario.IsNullOrEmpty(e-mail) || usuario.IsNullOrEmpty(senha) || usuario.IsNullOrEmpty(confirmarSenha))
            // {
            //     MessageBox.Show("Por favor, preencha todos os campos.");
            //     return;
            // }
            // 
            // // Validar se a senha e a confirmação de senha são iguais
            // if (criarSenha != confirmarSenha)
            // {
            //     MessageBox.Show("A senha e a confirmação de senha não coincidem.");
            //     return;
            // }
            // bool inserido = conexao.InserirUsuario(usuario, senha);  -- método --
            // if (inserido)
            // {
            //     MessageBox.Show("Cadastro realizado com sucesso!");
            // }
            // else
            // {
            //     MessageBox.Show("Erro ao cadastrar");
            // }
        }
    }
}