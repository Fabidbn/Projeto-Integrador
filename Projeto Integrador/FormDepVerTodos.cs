using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.ComponentModel;

namespace Projeto_Integrador
{
    public partial class FormDepVerTodos : Form
    {
        private int codigoTitular;
        //private List<Dependente> dependentes;
        private BindingList<Dependente> dependentes;
        public FormDepVerTodos(int codigoTitular)
        {
            InitializeComponent();
            this.codigoTitular = codigoTitular;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();
            db.ExcluirDependente(dataGridView1, dependentes);
        }


        private void FormDepVerTodos_Load(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            //dependentes = db.ConsultaDependente(codigoTitular); // Inicializando a lista aqui
            dependentes = new BindingList<Dependente>(db.ConsultaDependente(codigoTitular));


            dataGridView1.AutoGenerateColumns = false;

            // Adicione uma coluna oculta para armazenar o código do dependente, mas não a exiba visualmente.
            dataGridView1.Columns.Add("codigoColumn", "Código");
            dataGridView1.Columns["codigoColumn"].DataPropertyName = "codigo";
            dataGridView1.Columns["codigoColumn"].Visible = false; // Essa linha oculta a coluna visualmente.

            dataGridView1.Columns.Add("nomeColumn", "Nome");
            dataGridView1.Columns["nomeColumn"].DataPropertyName = "nome";

            dataGridView1.Columns.Add("cpfColumn", "CPF");
            dataGridView1.Columns["cpfColumn"].DataPropertyName = "cpf";

            dataGridView1.Columns.Add("emailColumn", "E-mail");
            dataGridView1.Columns["emailColumn"].DataPropertyName = "email";

            dataGridView1.DataSource = dependentes;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
