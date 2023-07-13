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
            // Conexao db = new Conexao();
            // db.Conectar();

            // AtualizarSenha atualizar = new AtualizarSenha();  -- classe -- arrumar
            // atualizar.cpf = TextBox;
            // atualizar.senhaAntiga = TexBox;
            // atualizar.senhaNova = TextBox;


            // Ver se tem campos não preenchidos
            //if (atualizar.IsNullOrEmpty(cpf) || atualizar.IsNullOrEmpty(senhaAntiga) || atualizar.IsNullOrEmpty(senhaNova))
            // {
            //     MessageBox.Show("Por favor, preencha todos os campos.");
            //     return;
            // }


            // Verificar se a senha antiga está correta
            // bool senhaAntigaCorreta = db.VerificarSenhaAntiga(cpf, senhaAntiga);
            // 
            // if (!senhaAntigaCorreta)
            // {
            //     MessageBox.Show("Senha antiga incorreta.");
            //     return;
            // }
            // 

            // // Atualizar a senha
            // bool senhaAtualizada = db.AtualizarSenha(cpf, novaSenha);
            // 
            // if (senhaAtualizada)
            // {
            //     MessageBox.Show("Senha redefinida com sucesso!");
            // }
            // else
            // {
            //     MessageBox.Show("Não foi possível redefinir a senha.");
            // }
        }
    }
}
