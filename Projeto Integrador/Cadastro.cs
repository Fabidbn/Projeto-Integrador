using System.Text.RegularExpressions;

namespace Projeto_Integrador
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            textBox4.TextChanged += textBox4_TextChanged;
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

        private void label4_Click(object sender, EventArgs e)
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
                novoTitular.nome = textBox2.Text;
                novoTitular.cpf = textBox4.Text;
                novoTitular.email = textBox3.Text;
                novoTitular.senhaTitular = textBox1.Text;
                string confirmarSenha = textBox5.Text;

                
                if (string.IsNullOrEmpty(novoTitular.nome) || string.IsNullOrEmpty(novoTitular.cpf) || string.IsNullOrEmpty(novoTitular.email) || string.IsNullOrEmpty(novoTitular.senhaTitular) || string.IsNullOrEmpty(confirmarSenha))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.");
                    return;
                }

               
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string cpf = textBox4.Text;
            cpf = Regex.Replace(cpf, @"[^0-9]", ""); 

            if (cpf.Length > 11)
            {
               
                cpf = cpf.Substring(0, 11);
            }

            if (cpf.Length > 3)
            {
                cpf = cpf.Insert(3, ".");
            }
            if (cpf.Length > 7)
            {
                cpf = cpf.Insert(7, "."); 
            }
            if (cpf.Length > 11)
            {
                cpf = cpf.Insert(11, "-");
            }

            textBox4.Text = cpf;
            textBox4.SelectionStart = cpf.Length;

        }
    }
}