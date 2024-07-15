using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace AcessoDados
{
    public class AcessoDadosSqlServer
    {
        private SqlConnection CriarConexao()
        {           
            return new SqlConnection(StrConn.StringConexao.StrConexao);

        }
        //Parametros que vao para o banco de dados 
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;
        //Limpa Parametros
        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }
        //Adicionar Parametros
        public void AdicionarParametros(String nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }
        //inserir-alterar-deletar no banco de dados  //Percistencia 
        public object ExecutarManipulacao(CommandType commandType, String nomeStoradProcedureOuTextSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                //Abrir Conexao
                sqlConnection.Open();
                //Criar comando que vai 
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas dentro do comando 
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoradProcedureOuTextSql;
                sqlCommand.CommandTimeout = 500;
                //Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // Consultar banco de dados 
        public DataTable ExecutarConsulta(CommandType commandType, String nomeStoradProcedureOuTextSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                //Abrir Conexao
                sqlConnection.Open();
                //Criar comando que vai 
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas dentro do comando 
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoradProcedureOuTextSql;
                sqlCommand.CommandTimeout = 500;
                //Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //criar adaptador traduzir dados do banco de dados 
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //data table rece os dados do banco de dados 
                DataTable dataTable = new DataTable();
                // preenchedo datatable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
