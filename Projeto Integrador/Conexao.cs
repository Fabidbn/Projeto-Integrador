using System;
using System.Collections.Generic;
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


        // VERIFICAR A SENHA NO BANCO PARA CRIAR UMA NOVA
        //public bool VerificarSenhaAntiga(string cpf, string senhaAntiga)
        //{
        //    try
        //    {
        //        string sql = "SELECT COUNT(*) FROM Usuario WHERE CPF = @CPF AND Senha = @SenhaAntiga";
        //        SqlCommand comando = new SqlCommand(sql, conn);
        //        comando.Parameters.AddWithValue("@CPF", cpf);
        //        comando.Parameters.AddWithValue("@SenhaAntiga", senhaAntiga);
        //
        //        int senhaCorrespondente = (int)comando.ExecuteScalar();
        //
        //        return senhaCorrespondente > 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ocorreu um erro: " + ex.Message);
        //        return false;
        //    }
        //}


        // public bool AtualizarSenha(string cpf, string novaSenha)
        // {
        //     try
        //     {
        //         bool senhaAntigaCorreta = VerificarSenhaAntiga(cpf, senhaAntiga);
        // 
        //         if (!senhaAntigaCorreta)
        //         {
        //             MessageBox.Show("Senha antiga incorreta.");
        //             return false;
        //         }
        // 
        //         string sql = "UPDATE Usuario SET Senha = @NovaSenha WHERE CPF = @CPF";
        //         SqlCommand comando = new SqlCommand(sql, conn);
        //         comando.Parameters.AddWithValue("@NovaSenha", novaSenha);
        //         comando.Parameters.AddWithValue("@CPF", cpf);
        // 
        //         int linhasAfetadas = comando.ExecuteNonQuery();
        // 
        //         return linhasAfetadas > 0;
        //     }
        //     catch (Exception ex)
        //     {
        //         MessageBox.Show("Ocorreu um erro: " + ex.Message);
        //         return false;
        //     }
        // }


        // INSERIR CADASTRO DO TITULAR
        public bool InserirCadastro(string nome, string cpf, string email, string senha)
        {
            try
            {
                string sql = "INSERT INTO Titular (Nome, Cpf, Email, Senha) VALUES (@Nome, @Cpf, @Email, @Senha)";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.Parameters.AddWithValue("@Nome", nome);
                    comando.Parameters.AddWithValue("@Cpf", cpf);
                    comando.Parameters.AddWithValue("@Email", email);
                    comando.Parameters.AddWithValue("@Senha", senha);
        
                int linhasAfetadas = comando.ExecuteNonQuery();
        
                return linhasAfetadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                return false;
            }
        }
    }
}
