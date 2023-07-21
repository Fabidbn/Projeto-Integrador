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
    public partial class FormFaturasTodas : Form
    {
        private int codigoTitular;

        public FormFaturasTodas(int codigoTitular)
        {
            InitializeComponent();
            this.codigoTitular = codigoTitular;

            dataGridViewFatura.CellFormatting += dataGridViewFatura_CellFormatting;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void FormFaturasTodas_Load(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();
            List<Fatura> faturas = db.ConsultaFatura(codigoTitular);
            dataGridViewFatura.AutoGenerateColumns = false;

            dataGridViewFatura.Columns.Add("codigoTitularColumn", "Código Titular");
            dataGridViewFatura.Columns["codigoTitularColumn"].DataPropertyName = "codigo";
            dataGridViewFatura.Columns["codigoTitularColumn"].Visible = false; // Essa linha oculta a coluna visualmente.

            dataGridViewFatura.Columns.Add("codigoColumn", "Código");
            dataGridViewFatura.Columns["codigoColumn"].DataPropertyName = "codigo";
            dataGridViewFatura.Columns["codigoColumn"].Visible = false; // Essa linha oculta a coluna visualmente.

            dataGridViewFatura.Columns.Add("mesReferenteColumn", "Competencia");
            dataGridViewFatura.Columns["mesReferenteColumn"].DataPropertyName = "mesReferente";
            dataGridViewFatura.Columns["mesReferenteColumn"].Width = 150;

            dataGridViewFatura.Columns.Add("dataVencimentoColumn", "Vencimento");
            dataGridViewFatura.Columns["dataVencimentoColumn"].DataPropertyName = "dataVencimento";
            dataGridViewFatura.Columns["dataVencimentoColumn"].Width = 150;

            dataGridViewFatura.Columns.Add("valorColumn", "Valor Mensalidade");
            dataGridViewFatura.Columns["valorColumn"].DataPropertyName = "valor";
            dataGridViewFatura.Columns["valorColumn"].Width = 150;

            dataGridViewFatura.Columns.Add("statusPagamentoColumn", "Status Pagamento");
            dataGridViewFatura.Columns["statusPagamentoColumn"].DataPropertyName = "statusPagamento";
            dataGridViewFatura.Columns["statusPagamentoColumn"].Width = 150;

            dataGridViewFatura.DataSource = faturas;
        }

        private void dataGridViewFatura_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void dataGridViewFatura_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewFatura.Columns["statusPagamentoColumn"].Index)
            {
                // Verificar se o valor é true ou false e definir o valor de exibição
                if (e.Value is bool statusPagamento)
                {
                    e.Value = statusPagamento ? "pago" : "pendente";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
