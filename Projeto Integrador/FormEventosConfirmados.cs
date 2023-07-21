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
    public partial class FormEventosConfirmados : Form
    {
        private int codigoTitular;
        private int codigoDependente;
        public FormEventosConfirmados(int codigoTitular, int codigoDependente)
        {
            InitializeComponent();
            this.codigoTitular = codigoTitular;
            this.codigoDependente = codigoDependente;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void FormEventosConfirmados_Load(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();
        }
    }
}
