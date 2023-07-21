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
        private int codigoDependente;
        public Acesso___Inicio(string tipoUsuario, int codigoTitular, int codigoDependente)
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario;
            this.codigoTitular = codigoTitular;
            this.codigoDependente = codigoDependente;
        }


        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEventosTodos todosEventos = new FormEventosTodos(tipoUsuario, codigoTitular, codigoDependente);
            todosEventos.Show();

        }

        private void Acesso___Inicio_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void verDependentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepVerTodos verTodos = new FormDepVerTodos(codigoTitular);
            verTodos.Show();

        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepNovo depNovo = new FormDepNovo(codigoTitular);
            depNovo.Show();


        }

        private void Acesso___Inicio_Load_1(object sender, EventArgs e)
        {
            AcessoPermitidoPeloTipoUsuario();
        }
        private void AcessoPermitidoPeloTipoUsuario()
        {
            if (tipoUsuario == "Titular")
            {
                // Configurar a visibilidade ou habilitação dos campos específicos para o titular
                eventosToolStripMenuItem.Enabled = true;
                minhasFaturasToolStripMenuItem.Enabled = true;
                cadastrarDependenteToolStripMenuItem.Enabled = true;
                exameToolStripMenuItem.Enabled = true;
                sairToolStripMenuItem.Enabled = true;
            }
            else
            {
                eventosToolStripMenuItem.Enabled = true;
                minhasFaturasToolStripMenuItem.Enabled = false;
                cadastrarDependenteToolStripMenuItem.Enabled = false;
                exameToolStripMenuItem.Enabled = false;
                sairToolStripMenuItem.Enabled = true;
            }
        }

        private void minhasFaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarDependenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void emAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFaturasTodas verTodos = new FormFaturasTodas(codigoTitular);
            verTodos.Show();

        }
        private void confirmadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEventosConfirmados eventosConfirmados = new FormEventosConfirmados(codigoTitular, codigoDependente, tipoUsuario);
            eventosConfirmados.Show();
        }
    }
}
