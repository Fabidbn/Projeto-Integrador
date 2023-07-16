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


        // CONFIRMAÇÃO DOS USUARIO
        public string BuscarTipoUsuario(string cpf, string senha)
        {
            string sql = $@"SELECT 'Titular' AS TipoUsuario
                    FROM Titular
                    WHERE cpf = '{cpf}' AND senhaTitular = '{senha}'
                    UNION
                    SELECT 'Dependente' AS TipoUsuario
                    FROM Dependente
                    WHERE cpf = '{cpf}' AND senhaDependente = '{senha}'";

            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
                return retorno["TipoUsuario"].ToString();

            return string.Empty;
        }



        // VERIFICAR A SENHA NO BANCO PARA CRIAR UMA NOVA
        public bool VerificarSenhaAntiga(string cpf, string senhaAntiga)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM Usuario WHERE CPF = @CPF AND Senha = @SenhaAntiga";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@CPF", cpf);
                comando.Parameters.AddWithValue("@SenhaAntiga", senhaAntiga);
        
                int senhaCorrespondente = (int)comando.ExecuteScalar();
        
                return senhaCorrespondente > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                return false;
            }
        }


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

        // REDEFINIR SENHA

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
