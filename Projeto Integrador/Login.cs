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
            //Conexao db = new Conexao();
            //db.Conectar();

            //UsuarioDoBanco usuario = new UsuarioDoBanco();  -- classe -- arrumar
            //usuario.cpf = textBox1.Text;
            //usuario.senha = textBox2.Text;


            // Ver se tem campos não preenchidos
            //if (usuario.IsNullOrEmpty(cpf) || usuario.IsNullOrEmpty(senha))
            // {
            //     MessageBox.Show("Por favor, preencha todos os campos.");
            //     return;
            // }


            //Buscar usuário e senha do banco de dados
            //var retorno = db.BuscarUsuario(usuario.CPF, usuario.Senha);

            //if (!retorno) // ! = negação
            {
                //    MessageBox.Show("Senha incorreta!");
            }
            //if (retorno)
            {
                //    int usuarioId = db.BuscarId(usuario.CPF);     -- usar caso necessário --
                //    MessageBox.Show("Bem-vindo!");

                Acesso___Inicio acesso = new Acesso___Inicio();
                acesso.ShowDialog();
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
