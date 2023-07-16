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
        public Acesso___Inicio(string tipoUsuario)
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario;
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEventosTodos todosEventos = new FormEventosTodos();
            todosEventos.ShowDialog();
        }

        private void Acesso___Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
