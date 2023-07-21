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
        private string tipoUsuario;
        public FormEventosConfirmados(int codigoTitular, int codigoDependente, string tipoUsuario)
        {
            InitializeComponent();
            this.codigoTitular = codigoTitular;
            this.codigoDependente = codigoDependente;
            this.tipoUsuario = tipoUsuario;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void FormEventosConfirmados_Load(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            List<EventoConfirmado> eventosConfirmados = db.ConsultaEventosConfirmados(codigoTitular, codigoDependente);

            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("codigoColumn", "Código");
            dataGridView1.Columns["codigoColumn"].DataPropertyName = "codigo";
            dataGridView1.Columns["codigoColumn"].Visible = false;

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

            dataGridView1.DataSource = eventosConfirmados;
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

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                
                if (dataGridView1.Rows[rowIndex].Cells["nomeColumn"].Value != null)
                {
                    string nomeEvento = dataGridView1.Rows[rowIndex].Cells["nomeColumn"].Value.ToString();

                    DialogResult resultado = MessageBox.Show($"Tem certeza que deseja retirar a presença do evento '{nomeEvento}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        int codigoEvento = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["codigoColumn"].Value);

                        if (tipoUsuario == "Titular")
                        {
                            db.RemoverPresencaEvento(codigoTitular, codigoEvento);
                        }
                        else
                        {
                            db.RemoverPresencaEvento(codigoDependente, codigoEvento);
                        }

                        
                        List<EventoConfirmado> eventosConfirmadosAtualizados = db.ConsultaEventosConfirmados(codigoTitular, codigoDependente);
                        dataGridView1.DataSource = eventosConfirmadosAtualizados;
                    }
                }
                else
                {
                    MessageBox.Show("A célula está vazia.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um evento para retirar a presença.");
            }
        }
    }
}
