using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Integrador
{
    public partial class FormDepNovo : Form
    {
        private int codigoTitular;
        public FormDepNovo(int codigoTitular)
        {
            InitializeComponent();
            this.codigoTitular = codigoTitular;
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

                Dependente dependenteNovo = new Dependente();
                dependenteNovo.nome = textBox1.Text;
                dependenteNovo.cpf = textBox2.Text;
                dependenteNovo.email = textBox3.Text;
                dependenteNovo.senhaDependente = textBox4.Text;
                string confirmarSenha = textBox5.Text;
                string senhaTitular = textBox6.Text;

                // Ver se tem campos não preenchidos
                if (string.IsNullOrEmpty(dependenteNovo.nome) || string.IsNullOrEmpty(dependenteNovo.cpf) || string.IsNullOrEmpty(dependenteNovo.email) || string.IsNullOrEmpty(dependenteNovo.senhaDependente) || string.IsNullOrEmpty(confirmarSenha) || string.IsNullOrEmpty(senhaTitular))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.");
                    return;
                }

                // Validar se a senha e a confirmação de senha são iguais
                if (dependenteNovo.senhaDependente != confirmarSenha)
                {
                    MessageBox.Show("A senha e a confirmação de senha não coincidem.");
                    textBox5.Text = "";
                    return;
                }

                // Validar a senha do titular
                bool senhaTitularValidada = db.VerificarSenhaTitular(codigoTitular, senhaTitular);
                if (!senhaTitularValidada)
                {
                    MessageBox.Show("A senha do titular não foi validada. Escreva novamente");
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    return;
                }

                // Atribuir o código do titular ao dependente
                dependenteNovo.codigoTitular = codigoTitular;

                // Inserir dependente no banco de dados
                bool inserido = db.InserirDependente(dependenteNovo);
                if (inserido)
                {
                    MessageBox.Show("Dependente cadastrado com sucesso!");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar dependente. Por favor, tente novamente.");
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
            textBox6.Text = string.Empty;
        }
    }
}
