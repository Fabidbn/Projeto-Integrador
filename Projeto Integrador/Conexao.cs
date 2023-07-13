using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador
{
    public class Conexao
    {






        // CONFIRMAÇÃO DOS USUARIO
        //  public bool BuscarUsuario(string CPF, string senha)
        //  {
        //      string sql = $"select * from Usuario where CPF = '{CPF}' and Senha = '{senha}' ";
        //      SqlCommand comando = new SqlCommand(sql, conn);
        //
        //      var retorno = comando.ExecuteReader();
        //
        //      if (retorno.Read())
        //          return true;
        //
        //      return false;
        //  }



        // VERIFICAR A SENHA NO BANCO PARA CRIAR UMA NOVA
        // public bool VerificarSenhaAntiga(string cpf, string senhaAntiga)
        // {
        //     try
        //     {
        //         string sql = "SELECT COUNT(*) FROM Usuario WHERE CPF = @CPF AND Senha = @SenhaAntiga";
        //         SqlCommand comando = new SqlCommand(sql, conn);
        //         comando.Parameters.AddWithValue("@CPF", cpf);
        //         comando.Parameters.AddWithValue("@SenhaAntiga", senhaAntiga);
        //
        //         int senhaCorrespondente = (int)comando.ExecuteScalar();
        //
        //         return senhaCorrespondente > 0;
        //     }
        //     catch (Exception ex)
        //     {
        //         MessageBox.Show("Ocorreu um erro: " + ex.Message);
        //         return false;
        //     }
        // }



        // REDEFINIR SENHA
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



        // public bool InserirCadastro(string nome, string cpf, string email, string senha)
        // {
        //     try
        //     {
        //         string sql = "INSERT INTO Titular (Nome, Cpf, Email, Senha) VALUES (@Nome, @Cpf, @Email, @Senha)";
        //             SqlCommand comando = new SqlCommand(sql, conn);
        //             comando.Parameters.AddWithValue("@Nome", nome);
        //             comando.Parameters.AddWithValue("@Cpf", cpf);
        //             comando.Parameters.AddWithValue("@Email", email);
        //             comando.Parameters.AddWithValue("@Senha", senha);
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
    }
}
