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
    public partial class FormEventosTodos : Form
    {
        private string tipoUsuario;
        private int codigoTitular;
        private int codigoDependente;
        public FormEventosTodos(string tipoUsuario, int codigoTitular, int codigoDependente)
        {
            InitializeComponent();
            this.codigoTitular = codigoTitular;
            this.codigoDependente = codigoDependente;
            this.tipoUsuario = tipoUsuario;
        }

        private void FormEventosTodos_Load(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            List<Evento> eventos = db.ConsultaEvento();

            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("codigoColumn", "Código");
            dataGridView1.Columns["codigoColumn"].DataPropertyName = "codigo";
            dataGridView1.Columns["codigoColumn"].Visible = false; // Essa linha oculta a coluna visualmente.

            dataGridView1.Columns.Add("nomeColumn", "Nome");
            dataGridView1.Columns["nomeColumn"].DataPropertyName = "nome";

            dataGridView1.Columns.Add("descricaoColumn", "Descrição");
            dataGridView1.Columns["descricaoColumn"].DataPropertyName = "descricao";

            dataGridView1.Columns.Add("localColumn", "Local");
            dataGridView1.Columns["localColumn"].DataPropertyName = "local";

            dataGridView1.Columns.Add("dataEventoColumn", "Data");
            dataGridView1.Columns["dataEventoColumn"].DataPropertyName = "dataEvento";

            dataGridView1.Columns.Add("horaEventoColumn", "Hora");
            dataGridView1.Columns["horaEventoColumn"].DataPropertyName = "horaEvento";

            dataGridView1.DataSource = eventos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();
            db.ConfirmarPresenca(dataGridView1, tipoUsuario, codigoTitular, codigoDependente);
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
