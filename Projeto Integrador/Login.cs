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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = textBox1.Text;
            string senha = textBox2.Text;

            (string tipoUsuario, int codigoTitular, int codigoDependente) = FazerLogin(cpf, senha);

            if (codigoTitular != -1)
            {
                Acesso___Inicio acesso = new Acesso___Inicio(tipoUsuario, codigoTitular, codigoDependente);
                acesso.Show();
                this.Hide();
            }
        }

            private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                Cadastro cadastro = new Cadastro();
                cadastro.Show();
            }

            private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                FormNossosPlanos planos = new FormNossosPlanos();
                planos.Show();
            }

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                FormRedefinirSenha novaSenha = new FormRedefinirSenha();
                novaSenha.Show();
            }
        private (string tipoUsuario, int codigoTitular, int codigoDependente) FazerLogin(string cpf, string senha)
        {
            Conexao db = new Conexao();
            db.Conectar();

            if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return (null, -1, -1);
            }

            // Verificar o tipo de usuário (Titular ou Dependente)
            string tipoUsuario = db.BuscarTipoUsuario(cpf, senha);

            if (!string.IsNullOrEmpty(tipoUsuario))
            {
                // Obter o código do titular
                int codigoTitular = db.ObterCodigoTitular(cpf);

                if (codigoTitular != -1)
                {
                    // Obter o código do dependente apenas se o tipo de usuário for "Dependente"
                    int codigoDependente = tipoUsuario == "Dependente" ? db.ObterCodigoDependente(cpf) : -1;

                    // Retornar o resultado do login com o código do dependente
                    return (tipoUsuario, codigoTitular, codigoDependente);
                }
                else
                {
                    // Exibir mensagem de erro ao obter o código do titular
                    MessageBox.Show("Erro ao obter o código do titular. Por favor, tente novamente.");
                }
            }
            else
            {
                // Exibir mensagem de erro de login inválido
                MessageBox.Show("CPF e/ou senha inválidos. Por favor, tente novamente.");
            }

            return (null, -1, -1);
        }
    }
}
