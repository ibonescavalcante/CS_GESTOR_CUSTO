using System;
using System.Collections.Generic;
using System.Text;
using AcessoDados;
using ObjetoTransferencia ;
using System.Data;

namespace RegraNegorcios
{
   public class Negorcios
    {
        //Instanciar classe acesso a dados 
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string InserirCustos(Custos custos)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Gastos", custos.Gastos);
                acessoDadosSqlServer.AdicionarParametros("@Cliente", custos.Cliente);
                acessoDadosSqlServer.AdicionarParametros("@Produto", custos.Produto);
                acessoDadosSqlServer.AdicionarParametros("@Quantidade", custos.Quant);  
                acessoDadosSqlServer.AdicionarParametros("@Valor", custos.Valor);
                acessoDadosSqlServer.AdicionarParametros("@Total", custos.Total);  
                acessoDadosSqlServer.AdicionarParametros("@Data", custos.Data);
                acessoDadosSqlServer.AdicionarParametros("@cdc", custos.cdc);
                acessoDadosSqlServer.AdicionarParametros("@Favorecido", custos.Favorecido); 

                string ID_Custos = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "InserirCustos").ToString();
                return ID_Custos;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string AlterarCustos(Custos custos)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@ID_Custos", custos.ID_Custos);
                acessoDadosSqlServer.AdicionarParametros("@Gastos", custos.Gastos);
                acessoDadosSqlServer.AdicionarParametros("@Cliente", custos.Cliente);
                acessoDadosSqlServer.AdicionarParametros("@Produto", custos.Produto);
                acessoDadosSqlServer.AdicionarParametros("@Quantidade", custos.Quant);
                acessoDadosSqlServer.AdicionarParametros("@Valor", custos.Valor);
                acessoDadosSqlServer.AdicionarParametros("@Total", custos.Total);
                acessoDadosSqlServer.AdicionarParametros("@Data", custos.Data);
                acessoDadosSqlServer.AdicionarParametros("@cdc", custos.cdc);
                acessoDadosSqlServer.AdicionarParametros("@Favorecido", custos.Favorecido); 

                string ID_Custos = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "AlterarCustos").ToString();
                return ID_Custos;

            }
            catch (Exception exeption)
            {
                return exeption.Message;
            }
        }

        public string ExcluirCustos(Custos custos)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@ID_Custos", custos.ID_Custos);

                string ID_Custos = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "ExcluirCustos").ToString();
                return ID_Custos;

            }
            catch (Exception exeption)
            {
                return exeption.Message;
            }
        }        

        public CustosColecao ConsultarCustos(string Gastos)
        {
            try
            {
                CustosColecao custosColecao = new CustosColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Gastos", Gastos);
                DataTable dataTableEleitores = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "ConsultaCustosGastos");
                //perconrrendo o datatable pra inserir as linhas na coleçao 
                foreach (DataRow linha in dataTableEleitores.Rows)
                {
                    Custos Custos = new Custos();
                    Custos.ID_Custos = Convert.ToInt32(linha["ID_Custos"]);
                    Custos.Gastos = Convert.ToString(linha["Gastos"]);
                    Custos.Cliente = Convert.ToString(linha["Cliente"]);
                    Custos.Produto = Convert.ToString(linha["Produto"]);
                    Custos.Quant = Convert.ToInt32(linha["Quantidade"]);
                    Custos.Valor = Convert.ToDecimal(linha["Valor"]);
                    Custos.Total = Convert.ToDecimal(linha["Total"]);
                    Custos.Data = Convert.ToString(linha["Data"]);
                    Custos.cdc = Convert.ToString(linha["Cdc"]);
                    Custos.Favorecido = Convert.ToString(linha["Favorecido"]);
                    
                    
                  
                    custosColecao.Add(Custos);

                }
                return custosColecao;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar a operação. Detalhes: " + ex.Message);
            }
        }


        public string InserirReceita(Receita receita)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Patrocinio", receita.Patrocinio);
                acessoDadosSqlServer.AdicionarParametros("@Valor", receita.Valor);
                acessoDadosSqlServer.AdicionarParametros("@Data", receita.Data);
                acessoDadosSqlServer.AdicionarParametros("@cdc", receita.cdc);


                string ID_Custos = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "InserirReceita").ToString();
                return ID_Custos;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string AlterarReceita(Receita receita)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@ID_Receita", receita.ID_Receita);
                acessoDadosSqlServer.AdicionarParametros("@Patrocinio", receita.Patrocinio);
                acessoDadosSqlServer.AdicionarParametros("@Valor", receita.Valor);
                acessoDadosSqlServer.AdicionarParametros("@Data", receita.Data);
                acessoDadosSqlServer.AdicionarParametros("@cdc", receita.cdc);

                string ID_Custos = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "AlteraReceita").ToString();
                return ID_Custos;

            }
            catch (Exception exeption)
            {
                return exeption.Message;
            }
        }

        public string ExcluirReceita(Receita receita)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@ID_Receita", receita.ID_Receita);

                string ID_Custos = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "ExcluirReceita").ToString();
                return ID_Custos;

            }
            catch (Exception exeption)
            {
                return exeption.Message;
            }
        }

        public ReceitaColecao ConsultarReceita(string Patrocinio)
        {
            try
            {
                ReceitaColecao receitaColecao = new ReceitaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Patrocinio", Patrocinio);
                DataTable dataTableEleitores = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "ConsultaReceitaPatrocinio");
                //perconrrendo o datatable pra inserir as linhas na coleçao 
                foreach (DataRow linha in dataTableEleitores.Rows)
                {
                    Receita receita = new Receita();
                    receita.ID_Receita = Convert.ToInt32(linha["ID_Receita"]);
                    receita.Patrocinio = Convert.ToString(linha["Patrocinio"]);
                    receita.Valor = Convert.ToDecimal(linha["Valor"]);
                    receita.Data = Convert.ToString(linha["Data"]);
                    receita.cdc = Convert.ToString(linha["Cdc"]);
                    receitaColecao.Add(receita);

                }
                return receitaColecao;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar a operação. Detalhes: " + ex.Message);
            }
        }

       //Inserir Centro de custo
        public string InserirCC(CCusto cCusto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CDC_Descricao", cCusto.CDC_Descricao);    
                string ID_Custos = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "InserirCentroCusto").ToString();
                return ID_Custos;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string AlterarCC(CCusto cCusto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@ID_CDC", cCusto.ID_CDC);
                acessoDadosSqlServer.AdicionarParametros("@CDC_Descricao", cCusto.CDC_Descricao);
                string ID_Custos = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "AlterarCentroCusto").ToString();
                return ID_Custos;

            }
            catch (Exception exeption)
            {
                return exeption.Message;
            }
        }

        public string ExcluirCC(CCusto cCusto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@ID_CDC", cCusto.ID_CDC);

                string ID_Custos = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "ExcluirCentroCusto").ToString();
                return ID_Custos;

            }
            catch (Exception exeption)
            {
                return exeption.Message;
            }
        }

        public CCustoColecao ConsultarCC(string CentroCusto)
        {
            try
            {
                CCustoColecao cCustoColecao = new CCustoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CDC_Descricao", CentroCusto);
                DataTable dataTableEleitores = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "ConsultaCentroCusto");
                //perconrrendo o datatable pra inserir as linhas na coleçao 
                foreach (DataRow linha in dataTableEleitores.Rows)
                {
                    CCusto cCusto = new CCusto();
                    cCusto.ID_CDC = Convert.ToInt32(linha["ID_CDC"]);
                    cCusto.CDC_Descricao = Convert.ToString(linha["CDC_Descricao"]);
                    cCustoColecao.Add(cCusto);

                }
                return cCustoColecao;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar a operação. Detalhes: " + ex.Message);
            }
        }
    }
}
