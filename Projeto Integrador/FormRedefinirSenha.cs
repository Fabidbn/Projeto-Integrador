using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador
{
    public partial class FormRedefinirSenha : Form
    {
        public FormRedefinirSenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            string cpf = textBox1.Text;
            string senhaAntiga = textBox2.Text;
            string senhaNova = textBox3.Text;


            // Ver se tem campos não preenchidos
            if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(senhaAntiga) || string.IsNullOrEmpty(senhaNova))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Verificar a correspondência do CPF e da senha antiga nas tabelas "Titular" e "Dependente"
            bool cpfESenhaAntigaValidos = db.VerificarCpfESenhaAntiga(cpf, senhaAntiga);

            if (cpfESenhaAntigaValidos)
            {
                // Alterar a senha
                bool alteracaoSenhaSucesso = db.AlterarSenha(cpf, senhaNova);

                if (alteracaoSenhaSucesso)
                {
                    MessageBox.Show("Senha alterada com sucesso!");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao alterar a senha. Por favor, tente novamente.");
                }
            }
            else
            {
                MessageBox.Show("CPF e/ou senha antiga inválidos. Por favor, verifique suas informações.");
            }
        }
        private void LimparCampos()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
    }
}

