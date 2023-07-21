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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Integrador
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox1.TextChanged += textBox1_TextChanged;
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

            
            string tipoUsuario = db.BuscarTipoUsuario(cpf, senha);

            if (!string.IsNullOrEmpty(tipoUsuario))
            {
                
                int codigoTitular = db.ObterCodigoTitular(cpf);

                if (codigoTitular != -1)
                {
                    
                    int codigoDependente = tipoUsuario == "Dependente" ? db.ObterCodigoDependente(cpf) : -1;

                    
                    return (tipoUsuario, codigoTitular, codigoDependente);
                }
                else
                {
                    
                    MessageBox.Show("Erro ao obter o código do titular. Por favor, tente novamente.");
                }
            }
            else
            {
                MessageBox.Show("CPF e/ou senha inválidos. Por favor, tente novamente.");
            }

            return (null, -1, -1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cpf = textBox1.Text;
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

            textBox1.Text = cpf;
            textBox1.SelectionStart = cpf.Length;
        }
    }
}
