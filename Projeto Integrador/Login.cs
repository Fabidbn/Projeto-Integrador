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
            Conexao db = new Conexao();
            db.Conectar();

            string cpf = textBox1.Text;
            string senha = textBox2.Text;

            // Ver se tem campos não preenchidos
            if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(senha))
             {
                 MessageBox.Show("Por favor, preencha todos os campos.");
                 return;
             }

            
            //Buscar usuário e senha do banco de dados
            string tipoUsuario = db.BuscarTipoUsuario(cpf, senha);

            if (!string.IsNullOrEmpty(tipoUsuario))
            {
                // Login bem-sucedido, redirecionar para a tela de acesso
                Acesso___Inicio acesso = new Acesso___Inicio(tipoUsuario);
                acesso.Show();
                this.Hide();
            }
            else
            {
                // Exibir mensagem de erro de login inválido
                MessageBox.Show("CPF e/ou senha inválidos. Por favor, tente novamente.");
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
    }
}
