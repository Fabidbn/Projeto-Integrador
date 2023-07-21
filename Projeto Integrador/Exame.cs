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
    public partial class Exame : Form
    {
        private int codigoTitular;
        public Exame(int codigoTitular)
        {
            InitializeComponent();
            this.codigoTitular = codigoTitular;

            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void Exame_Load(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            List<Exames> exames = db.ConsultaExames(codigoTitular);

            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("codigoColumn", "Código");
            dataGridView1.Columns["codigoColumn"].DataPropertyName = "codigo";
            dataGridView1.Columns["codigoColumn"].Visible = false; // Essa linha oculta a coluna visualmente.

            dataGridView1.Columns.Add("codigoTitularColumn", "Código Titular");
            dataGridView1.Columns["codigoTitularColumn"].DataPropertyName = "codigoTitular";
            dataGridView1.Columns["codigoTitularColumn"].Visible = false;

            dataGridView1.Columns.Add("tipoColumn", "tipo");
            dataGridView1.Columns["tipoColumn"].DataPropertyName = "tipo";

            dataGridView1.Columns.Add("descricaoColumn", "Descrição");
            dataGridView1.Columns["descricaoColumn"].DataPropertyName = "descricao";

            dataGridView1.Columns.Add("dataRealizacaoColumn", "Data");
            dataGridView1.Columns["dataRealizacaoColumn"].DataPropertyName = "dataRealizacao";

            dataGridView1.Columns.Add("statusColumn", "Status");
            dataGridView1.Columns["statusColumn"].DataPropertyName = "status";

            dataGridView1.DataSource = exames;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "dataRealizacaoColumn" && e.Value != null && e.Value != DBNull.Value)
            {
                DateTime dataRealizacao = Convert.ToDateTime(e.Value);
                e.Value = dataRealizacao.ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == dataGridView1.Columns["statusColumn"].Index)
            {
                // Verificar se o valor é true ou false e definir o valor de exibição
                if (e.Value is bool status)
                {
                    e.Value = status ? "pago" : "pendente";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
