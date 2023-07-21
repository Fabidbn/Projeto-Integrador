using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador
{
    public partial class FormRedefinirSenha : Form
    {
        public FormRedefinirSenha()
        {
            InitializeComponent();
            textBox3.TextChanged += textBox3_TextChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            string cpf = textBox3.Text;
            string senhaAntiga = textBox1.Text;
            string senhaNova = textBox2.Text;


            if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(senhaAntiga) || string.IsNullOrEmpty(senhaNova))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            DialogResult result = MessageBox.Show("Deseja redefinir a senha?", "Confirmação", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                bool cpfESenhaAntigaValidos = db.VerificarCpfESenhaAntiga(cpf, senhaAntiga);

                if (cpfESenhaAntigaValidos)
                {

                    bool alteracaoSenhaSucesso = db.AlterarSenha(cpf, senhaNova);

                    if (alteracaoSenhaSucesso)
                    {
                        MessageBox.Show("Senha alterada com sucesso!");
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar a senha. Por favor, tente novamente.");
                        LimparCampos();
                    }
                }
                else
                {
                    MessageBox.Show("CPF e/ou senha antiga inválidos. Por favor, verifique suas informações.");
                }
            }
        }
        private void LimparCampos()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string cpf = textBox3.Text;
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

            textBox3.Text = cpf;
            textBox3.SelectionStart = cpf.Length;
        }
    }
}
