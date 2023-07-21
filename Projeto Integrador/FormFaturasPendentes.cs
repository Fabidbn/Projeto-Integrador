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
    public partial class FormFaturasPendentes : Form
    {
        private int codigoTitular;
        public FormFaturasPendentes(int codigoTitular)
        {
            InitializeComponent();
            this.codigoTitular = codigoTitular;
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["statusPagamentoColumn"].Index)
            {
                // Verificar se o valor é true ou false e definir o valor de exibição
                if (e.Value is bool statusPagamento)
                {
                    e.Value = statusPagamento ? "pago" : "pendente";
                    e.FormattingApplied = true;
                }
            }
        }

        private void FormFaturasPendentes_Load(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();
            List<Fatura> faturas = db.ConsultaFaturaPendente(codigoTitular);
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("codigoTitularColumn", "Código Titular");
            dataGridView1.Columns["codigoTitularColumn"].DataPropertyName = "codigo";
            dataGridView1.Columns["codigoTitularColumn"].Visible = false; // Essa linha oculta a coluna visualmente.

            dataGridView1.Columns.Add("codigoColumn", "Código");
            dataGridView1.Columns["codigoColumn"].DataPropertyName = "codigo";
            dataGridView1.Columns["codigoColumn"].Visible = false; // Essa linha oculta a coluna visualmente.

            dataGridView1.Columns.Add("mesReferenteColumn", "Competencia");
            dataGridView1.Columns["mesReferenteColumn"].DataPropertyName = "mesReferente";

            dataGridView1.Columns.Add("dataVencimentoColumn", "Vencimento");
            dataGridView1.Columns["dataVencimentoColumn"].DataPropertyName = "dataVencimento";

            dataGridView1.Columns.Add("valorColumn", "Valor Mensalidade");
            dataGridView1.Columns["valorColumn"].DataPropertyName = "valor";

            dataGridView1.Columns.Add("statusPagamentoColumn", "Status Pagamento");
            dataGridView1.Columns["statusPagamentoColumn"].DataPropertyName = "statusPagamento";

            dataGridView1.DataSource = faturas;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
