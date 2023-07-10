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
        public Acesso___Inicio()
        {
            InitializeComponent();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEventosTodos todosEventos = new FormEventosTodos();
            todosEventos.ShowDialog();
        }
    }
}
