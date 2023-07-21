using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador
{
    public class Conexao
    {
        public SqlConnection conn = new SqlConnection("Data Source=dbaulabanco.ce9eq7mml3ie.sa-east-1.rds.amazonaws.com;Initial Catalog=db_fabiana;Persist Security Info=True;;MultipleActiveResultSets=True;User ID=fabiana;Password=fabiana80!");

        public void Conectar()
        {
            conn.Open();
        }
        public void Desconectar()
        {
            conn.Close();
        }


        // VALIDAÇÃO DO USUARIO E QUEM ESTA ACESSANDO 
        public string BuscarTipoUsuario(string cpf, string senha)
        {
            try
            {
                string sqlTitular = $"SELECT 'Titular' AS TipoUsuario FROM Titular WHERE cpf = @cpf AND senhaTitular = @Senha";
                string sqlDependente = $"SELECT 'Dependente' AS TipoUsuario FROM Dependente WHERE cpf = @cpf AND senhaDependente = @Senha";

                SqlCommand comandoTitular = new SqlCommand(sqlTitular, conn);
                comandoTitular.Parameters.AddWithValue("@CPF", cpf);
                comandoTitular.Parameters.AddWithValue("@Senha", senha);

                SqlCommand comandoDependente = new SqlCommand(sqlDependente, conn);
                comandoDependente.Parameters.AddWithValue("@CPF", cpf);
                comandoDependente.Parameters.AddWithValue("@Senha", senha);

                string tipoUsuario = string.Empty;

                if (comandoTitular.ExecuteScalar() != null)
                {
                    tipoUsuario = comandoTitular.ExecuteScalar().ToString();
                }
                else if (comandoDependente.ExecuteScalar() != null)
                {
                    tipoUsuario = comandoDependente.ExecuteScalar().ToString();
                }

                return tipoUsuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                return string.Empty;
            }
        }

        // OBTER O CODIGO DO TITULAR
        public int ObterCodigoTitular(string cpf)
        {
            try
            {
                string sql = "SELECT codigo FROM Titular WHERE cpf = @CPF";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@CPF", cpf);

                object resultado = comando.ExecuteScalar();

                if (resultado != null && int.TryParse(resultado.ToString(), out int codigoTitular))
                {
                    return codigoTitular;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na validação: " + ex.Message);
                return -1;
            }
        }

        // OBTER O CODIGO DO DEPENDENTE
        public int ObterCodigoDependente(string cpf)
        {
            try
            {
                string sql = "SELECT codigo FROM Dependente WHERE cpf = @CPF";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@CPF", cpf);

                object resultado = comando.ExecuteScalar();

                if (resultado != null && int.TryParse(resultado.ToString(), out int codigoTitular))
                {
                    return codigoTitular;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na validação: " + ex.Message);
                return -1;
            }
        }

        // VERIFICAR O CPF E A SENHA PRA ATUALIZAR A SENHA
        public bool VerificarCpfESenhaAntiga(string cpf, string senhaAntiga)
        {
            try
            {
                string sqlTitular = "SELECT COUNT(*) FROM Titular WHERE CPF = @CPF AND SenhaTitular = @SenhaAntiga";
                string sqlDependente = "SELECT COUNT(*) FROM Dependente WHERE CPF = @CPF AND SenhaDependente = @SenhaAntiga";

                SqlCommand comandoTitular = new SqlCommand(sqlTitular, conn);
                comandoTitular.Parameters.AddWithValue("@CPF", cpf);
                comandoTitular.Parameters.AddWithValue("@SenhaAntiga", senhaAntiga);

                SqlCommand comandoDependente = new SqlCommand(sqlDependente, conn);
                comandoDependente.Parameters.AddWithValue("@CPF", cpf);
                comandoDependente.Parameters.AddWithValue("@SenhaAntiga", senhaAntiga);

                int countTitular = (int)comandoTitular.ExecuteScalar();
                int countDependente = (int)comandoDependente.ExecuteScalar();

                return countTitular > 0 || countDependente > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                return false;
            }
        }

        // ALTERAÇÃO DA SENHA
        public bool AlterarSenha(string cpf, string senhaNova)
        {
            try
            {
                string sqlTitular = "UPDATE Titular SET SenhaTitular = @SenhaNova WHERE CPF = @CPF";
                string sqlDependente = "UPDATE Dependente SET SenhaDependente = @SenhaNova WHERE CPF = @CPF";

                SqlCommand comandoTitular = new SqlCommand(sqlTitular, conn);
                comandoTitular.Parameters.AddWithValue("@SenhaNova", senhaNova);
                comandoTitular.Parameters.AddWithValue("@CPF", cpf);

                SqlCommand comandoDependente = new SqlCommand(sqlDependente, conn);
                comandoDependente.Parameters.AddWithValue("@SenhaNova", senhaNova);
                comandoDependente.Parameters.AddWithValue("@CPF", cpf);

                int rowsAffectedTitular = comandoTitular.ExecuteNonQuery();
                int rowsAffectedDependente = comandoDependente.ExecuteNonQuery();

                return rowsAffectedTitular > 0 || rowsAffectedDependente > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                return false;
            }
        }

        // INSERIR CADASTRO DO TITULAR
        public bool InserirCadastro(string nome, string cpf, string email, string senhaTitular)
        {
            try
            {
                string sql = "INSERT INTO Titular (nome, cpf, email, senhaTitular) VALUES (@Nome, @Cpf, @Email, @Senha)";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@Nome", nome);
                comando.Parameters.AddWithValue("@Cpf", cpf);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@Senha", senhaTitular);

                int linhasAfetadas = comando.ExecuteNonQuery();

                return linhasAfetadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                return false;
            }
        }

        // INSERIR CADASTRO DO DEPENDENTE
        public bool InserirDependente (Dependente dependente)
        {
            try
            {
                string sql = "INSERT INTO Dependente (codigoTitular, nome, cpf, email, senhaDependente) VALUES (@CodigoTitular, @Nome, @Cpf, @Email, @Senha)";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@CodigoTitular", dependente.codigoTitular);
                comando.Parameters.AddWithValue("@Nome", dependente.nome);
                comando.Parameters.AddWithValue("@Cpf", dependente.cpf);
                comando.Parameters.AddWithValue("@Email", dependente.email);
                comando.Parameters.AddWithValue("@Senha", dependente.senhaDependente);

                int linhasAfetadas = comando.ExecuteNonQuery();

                return linhasAfetadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                return false;
            }
        }

        // VERIFICAR A SENHA DO TITULAR
        public bool VerificarSenhaTitular(int codigoTitular, string senhaTitular)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM Titular WHERE codigo = @CodigoTitular AND senhaTitular = @SenhaTitular";

                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@CodigoTitular", codigoTitular);
                comando.Parameters.AddWithValue("@SenhaTitular", senhaTitular);

                int countTitular = (int)comando.ExecuteScalar();

                return countTitular > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                return false;
            }
        }

        // PASSAR AS INFORMAÇÕES PRO GRID DEPENDENTES
        public List<Dependente> ConsultaDependente(int codigoTitular)
        {
            string sql = @"SELECT codigo, nome, cpf, email FROM Dependente WHERE codigoTitular = @CodigoTitular";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.Parameters.AddWithValue("@CodigoTitular", codigoTitular);
            List<Dependente> dependentes = new List<Dependente>();

            using (var reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var codigoDb = reader.GetInt32(reader.GetOrdinal("codigo"));
                    var nomeDb = reader.GetString(reader.GetOrdinal("nome"));
                    var cpfDb = reader.GetString(reader.GetOrdinal("cpf"));
                    var emailDb = reader.GetString(reader.GetOrdinal("email"));

                    dependentes.Add(new Dependente()
                    {
                        codigo = codigoDb,
                        nome = nomeDb,
                        cpf = cpfDb,
                        email = emailDb
                    });
                }
            }

            return dependentes;
        }

        // PASSAR AS INFORMAÇÕES PRO GRID EVENTOS
        public List<Evento> ConsultaEvento()
        {
            string sql = @"SELECT codigo, nome, descricao, local, dataEvento, horaEvento FROM Evento";
            SqlCommand comando = new SqlCommand(sql, conn);

            List<Evento> eventos = new List<Evento>();

            using (var reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var codigoDb = reader.GetInt32(reader.GetOrdinal("codigo"));
                    var nomeDb = reader.GetString(reader.GetOrdinal("nome"));
                    var descricaoDb = reader.GetString(reader.GetOrdinal("descricao"));
                    var localDb = reader.GetString(reader.GetOrdinal("local"));
                    var dataEventoDb = reader.GetDateTime(reader.GetOrdinal("dataEvento"));
                    var horaEventoDb = reader.GetTimeSpan(reader.GetOrdinal("horaEvento"));

                    eventos.Add(new Evento()
                    {
                        codigo = codigoDb,
                        nome = nomeDb,
                        descricao = descricaoDb,
                        local = localDb,
                        dataEvento = dataEventoDb,
                        horaEvento = horaEventoDb
                    });
                }
            }
            return eventos;
        }

        // CONSULTA FATURAS
        public List<Fatura> ConsultaFatura(int codigoTitular)
        {
            string sql = @"SELECT codigo, codigoTitular, mesReferente, dataVencimento, valor, statusPagamento FROM Fatura WHERE codigoTitular = @CodigoTitular";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.Parameters.AddWithValue("@CodigoTitular", codigoTitular);

            List<Fatura> faturas = new List<Fatura>();

            using (var reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var codigoDb = reader.GetInt32(reader.GetOrdinal("codigo"));
                    var codigoTitularDb = reader.GetInt32(reader.GetOrdinal("codigoTitular"));
                    var mesReferenteDb = reader.GetDateTime(reader.GetOrdinal("mesReferente"));
                    var dataVencimentolDb = reader.GetDateTime(reader.GetOrdinal("dataVencimento"));
                    var valorDb = reader.GetDecimal(reader.GetOrdinal("valor"));
                    var statustPagamentoDb = reader.GetBoolean(reader.GetOrdinal("statusPagamento"));

                    faturas.Add(new Fatura()
                    {
                        codigo = codigoDb,
                        codigoTitular = codigoTitularDb,
                        mesReferente = mesReferenteDb,
                        dataVencimento = dataVencimentolDb,
                        valor = valorDb,
                        statusPagamento = statustPagamentoDb
                    });
                }
            }
            return faturas;
        }
            
        // EXCLUIR O DEPENDENTE 
        public void ExcluirDependente(DataGridView dataGridView1, BindingList<Dependente> dependentes)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                int idDependente = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["codigoColumn"].Value);

                string sql = "SELECT * FROM Dependente WHERE codigo = @Codigo";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@Codigo", idDependente);

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    string nome = reader.GetString(reader.GetOrdinal("nome"));

                    string mensagem = $"Tem certeza que deseja excluir o dependente {nome}?";
                    DialogResult resultado = MessageBox.Show(mensagem, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        sql = "DELETE FROM Dependente WHERE codigo = @Codigo";
                        comando = new SqlCommand(sql, conn);
                        comando.Parameters.AddWithValue("@Codigo", idDependente);
                        comando.ExecuteNonQuery();
                        
                        Dependente dependenteRemovido = dependentes.FirstOrDefault(d => d.codigo == idDependente);
                        if (dependenteRemovido != null)
                        {
                            dependentes.Remove(dependenteRemovido);
                        }
                    }
                }
                reader.Close();
            }
        }

        // CONFIRMAR PRESENÇA NO EVENTO
        public void ConfirmarPresenca(DataGridView dataGridView, string tipoUsuario, int codigoTitular, int codigoDependente)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView.SelectedRows[0].Index;
                int codigoEvento = Convert.ToInt32(dataGridView.Rows[rowIndex].Cells["codigoColumn"].Value);
                string nomeEvento = dataGridView.Rows[rowIndex].Cells["nomeColumn"].Value.ToString();

                string mensagem = $"Tem certeza que deseja confirmar presença no evento {nomeEvento}?";
                DialogResult resultado = MessageBox.Show(mensagem, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        string sql;
                        SqlCommand comando;

                        if (tipoUsuario == "Titular")
                        {
                            sql = "INSERT INTO Inscricao (codigoTitular, codigoEvento) VALUES (@CodigoTitular, @CodigoEvento)";
                            comando = new SqlCommand(sql, conn);
                            comando.Parameters.AddWithValue("@CodigoTitular", codigoTitular);
                            comando.Parameters.AddWithValue("@CodigoEvento", codigoEvento);
                        }
                        else
                        {
                            sql = "INSERT INTO Inscricao (codigoDependente, codigoEvento) VALUES (@CodigoDependente, @CodigoEvento)";
                            comando = new SqlCommand(sql, conn);
                            comando.Parameters.AddWithValue("@CodigoDependente", codigoDependente);
                            comando.Parameters.AddWithValue("@CodigoEvento", codigoEvento);
                        }

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Presença confirmada com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao confirmar presença: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um evento para confirmar presença.");
            }
        }

        // CONSULTA PRO GRID DOS EVENTOS CONFIRMADOS
        public List<EventoConfirmado> ConsultaEventosConfirmados(int codigoTitular, int codigoDependente)
        {
            string sql = @"
        SELECT I.codigo, E.nome, E.descricao, E.local, E.dataEvento, E.horaEvento
        FROM Evento E
        INNER JOIN Inscricao I ON E.codigo = I.codigoEvento
        WHERE (I.codigoTitular = @CodigoTitular OR I.codigoDependente = @CodigoDependente)";

            SqlCommand comando = new SqlCommand(sql, conn);
            comando.Parameters.AddWithValue("@CodigoTitular", codigoTitular);
            comando.Parameters.AddWithValue("@CodigoDependente", codigoDependente);

            List<EventoConfirmado> eventosConfirmados = new List<EventoConfirmado>();

            using (var reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var codigoDb = reader.GetInt32(reader.GetOrdinal("codigo"));
                    var nomeDb = reader.GetString(reader.GetOrdinal("nome"));
                    var descricaoDb = reader.GetString(reader.GetOrdinal("descricao"));
                    var localDb = reader.GetString(reader.GetOrdinal("local"));
                    var dataEventoDb = reader.GetDateTime(reader.GetOrdinal("dataEvento"));
                    var horaEventoDb = reader.GetTimeSpan(reader.GetOrdinal("horaEvento"));

                    eventosConfirmados.Add(new EventoConfirmado()
                    {
                        codigo = codigoDb,
                        nome = nomeDb,
                        descricao = descricaoDb,
                        local = localDb,
                        dataEvento = dataEventoDb,
                        horaEvento = horaEventoDb
                    });
                }
            }

            return eventosConfirmados;
        }

        // REMOVER PRESENÇA
        public void RemoverPresencaEvento(int codigoPessoa, int codigoEvento)
        {
            try
            {
                string sql = "DELETE FROM Inscricao WHERE (codigoTitular = @CodigoPessoa OR codigoDependente = @CodigoPessoa) AND codigoEvento = @CodigoEvento";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@CodigoPessoa", codigoPessoa);
                comando.Parameters.AddWithValue("@CodigoEvento", codigoEvento);

                comando.ExecuteNonQuery();
                MessageBox.Show("Presença removida com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao remover a presença: " + ex.Message);
            }
        }

        // CONSULTA PRO GRID DOS EXAMES
        public List<Exames> ConsultaExames(int codigoTitular)
        {
            string sql = @"SELECT codigo, codigoTitular, tipo, descricao, dataRealizacao, status FROM Exame WHERE codigoTitular = @CodigoTitular";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.Parameters.AddWithValue("@CodigoTitular", codigoTitular);

            List<Exames> exames = new List<Exames>();

            using (var reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var codigoDb = reader.GetInt32(reader.GetOrdinal("codigo"));
                    var codigoTitularDb = reader.GetInt32(reader.GetOrdinal("codigoTitular"));
                    var tipoDb = reader.GetString(reader.GetOrdinal("tipo"));
                    var descricaoDb = reader.GetString(reader.GetOrdinal("descricao"));
                    var dataRealizacaoDb = reader.GetDateTime(reader.GetOrdinal("dataRealizacao"));
                    var statusDb = reader.GetBoolean(reader.GetOrdinal("status"));

                    exames.Add(new Exames()
                    {
                        codigo = codigoDb,
                        codigoTitular = codigoTitularDb,
                        tipo = tipoDb,
                        descricao = descricaoDb,
                        dataRealizacao = dataRealizacaoDb,
                        status = statusDb,
                    });
                }
            }
            return exames;
        }
    }
}

