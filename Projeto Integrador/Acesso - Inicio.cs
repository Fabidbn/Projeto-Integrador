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
    public partial class Acesso___Inicio : Form
    {
        
        
        private string tipoUsuario;
        private int codigoTitular;
        public Acesso___Inicio(string tipoUsuario, int codigoTitular)
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario;
            this.codigoTitular = codigoTitular;
        }
    

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEventosTodos todosEventos = new FormEventosTodos();
            todosEventos.ShowDialog();
        }

        private void Acesso___Inicio_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void verDependentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepVerTodos verTodos = new FormDepVerTodos();
            verTodos.Show();
            this.Hide();
        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepNovo depNovo = new FormDepNovo(codigoTitular);
            depNovo.Show();
            this.Hide();
        }

        private void Acesso___Inicio_Load_1(object sender, EventArgs e)
        {

        }
    }
}
