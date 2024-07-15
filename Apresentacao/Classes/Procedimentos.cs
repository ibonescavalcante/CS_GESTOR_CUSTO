using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using RegraNegorcios;
using ObjetoTransferencia;
using AcessoDados;
using System.Data;

namespace Apresentacao.Classes
{
   public static  class Procedimentos
    {
       public static void ConfiguraDataGridCCusto(DataGridView dataGridView)
       {
           dataGridView.Columns[0].HeaderText = "Código";
           dataGridView.Columns[0].Width = 50;
           dataGridView.Columns[0].ReadOnly = true;
           dataGridView.Columns[1].HeaderText = "CDC";
           dataGridView.Columns[1].Width = 98;
           dataGridView.Columns[1].ReadOnly = true;
       }

       public static void ConfiguraDataGrid(DataGridView dataGridView)
       {
           dataGridView.Columns[0].HeaderText = "Código";
           dataGridView.Columns[0].Width = 50;
           dataGridView.Columns[0].ReadOnly=true ;
           dataGridView.Columns[1].HeaderText = "Gastos";
           dataGridView.Columns[1].Width = 98;
           dataGridView.Columns[1].ReadOnly = true;
           dataGridView.Columns[2].HeaderText = "Clientes";
           dataGridView.Columns[2].Width = 110;
           dataGridView.Columns[2].ReadOnly = true;
           dataGridView.Columns[3].HeaderText = "Produtos";
           dataGridView.Columns[3].Width = 150;
           dataGridView.Columns[3].ReadOnly = true;
           dataGridView.Columns[4].HeaderText = "Qaunt";
           dataGridView.Columns[4].Width = 40;
           dataGridView.Columns[4].ReadOnly = true;
           dataGridView.Columns[5].HeaderText = "Valor";
           dataGridView.Columns[5].Width = 60;
           dataGridView.Columns[5].ReadOnly = true;
           dataGridView.Columns[6].HeaderText = "Total";
           dataGridView.Columns[6].Width = 60;
           dataGridView.Columns[6].ReadOnly = true;
           dataGridView.Columns[7].HeaderText = "Data";
           dataGridView.Columns[7].Width = 100;
           dataGridView.Columns[7].ReadOnly = true;
           dataGridView.Columns[8].HeaderText = "Cdc";
           dataGridView.Columns[8].Width = 100;
           dataGridView.Columns[8].ReadOnly = true;
           dataGridView.Columns[9].HeaderText = "Favorecido";
           dataGridView.Columns[9].Width = 100;
           dataGridView.Columns[9].ReadOnly = true;
       }

       public static void ConfiguraDataGridReceita(DataGridView dataGridView)
       {
           dataGridView.Columns[0].HeaderText = "Código";
           dataGridView.Columns[0].Width = 50;
           dataGridView.Columns[0].ReadOnly = true;
           dataGridView.Columns[1].HeaderText = "Patrocinio";
           dataGridView.Columns[1].Width = 98;
           dataGridView.Columns[1].ReadOnly = true;
           dataGridView.Columns[2].HeaderText = "Valor";
           dataGridView.Columns[2].Width = 60;
           dataGridView.Columns[2].ReadOnly = true;
           dataGridView.Columns[3].HeaderText = "Data";
           dataGridView.Columns[3].Width = 100;
           dataGridView.Columns[3].ReadOnly = true;
           dataGridView.Columns[4].HeaderText = "Cdc";
           dataGridView.Columns[4].Width = 100;
           dataGridView.Columns[4].ReadOnly = true;
          
       }

       public static string GetTotal(DataGridView dataGridView,string coluna)
       {
           double resulta = 0;
           for (int i = 0; i < dataGridView.RowCount; i++)
           {               
               resulta = Convert.ToDouble(dataGridView.Rows[i].Cells[coluna].Value) + resulta;
           }
           
           return "Total: " + Convert.ToString(resulta);
          
       }

       public static void GetCCusto(ComboBox comboBox) 
       {
           AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
           //Negorcios negorcios = new Negorcios();
           //CCustoColecao cCustosColecao = new CCustoColecao();
           //cCustosColecao = negorcios.ConsultarCC("");
           //cCustosColecao.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
           //comboBox.DataSource = null;          
           //comboBox.DataSource = cCustosColecao;
           //comboBox.ValueMember = "CDC_Descricao";
           //comboBox.DisplayMember = "CDC_Descricao";
           //comboBox.SelectedItem = "";
           //comboBox.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
           try
           {
             
               acessoDadosSqlServer.LimparParametros();
               acessoDadosSqlServer.AdicionarParametros("@CDC_Descricao", "");
               DataTable tableCCusto = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "ConsultaCentroCusto");
               DataRow row = tableCCusto.NewRow();
               tableCCusto.Rows.InsertAt(row, 0);
               comboBox.DataSource = null;
               comboBox.DataSource = tableCCusto;
               comboBox.ValueMember = "CDC_Descricao";
              // comboBox.DisplayMember = "CDC_Descricao";
               comboBox.SelectedItem = "";
               comboBox.Refresh(); //faz uma nova busc            
              
             

           }
           catch (Exception ex)
           {
               throw new Exception("Não foi possivel executar a operação. Detalhes: " + ex.Message);
           }
       }
    }
}
