﻿using System;
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

        // OBTER O CODIGO DO TITULAR
        public int ObterCodigoTitular(string cpf)
        {
            try
            {
                string sql = "SELECT codigo FROM Titular WHERE cpf = @CPF";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@CPF", cpf);

                // Executar o comando e obter o código do titular
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
                MessageBox.Show("Ocorreu um erro ao obter o código do titular: " + ex.Message);
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
        public bool InserirDependente(Dependente dependente)
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
    }
}
