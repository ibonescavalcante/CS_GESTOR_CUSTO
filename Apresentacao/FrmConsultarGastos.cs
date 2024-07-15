using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RegraNegorcios;
using ObjetoTransferencia;
namespace Apresentacao
{
    public partial class FrmConsultarGastos : Form
    {
        public FrmConsultarGastos()
        {
            InitializeComponent();
        }

        private void AtualizarGrid()
        {
            Negorcios custosNegorcios = new Negorcios();
            CustosColecao custosColecao = new CustosColecao();
            custosColecao = custosNegorcios.ConsultarCustos(textBoxPesquisar.Text );            
            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = custosColecao;
            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
            Classes.Procedimentos.ConfiguraDataGrid(dataGridViewPrincipal);
            labelTotal.Text = Classes.Procedimentos.GetTotal(dataGridViewPrincipal, "Total");

        }
      

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();            
            
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            FrmCadastroCustos frmCadastroCustos = new FrmCadastroCustos(Classes.Acoes.Inserir,null);
            DialogResult dialogResult = frmCadastroCustos.ShowDialog();
          
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            //Verificar se tem linha selecionada no grid
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe Itens selecionados.");
                return;
            }
            //Pegar o Eleitor selecionado no grid
            Custos custos = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Custos);
            FrmCadastroCustos frmCadastroCustos = new FrmCadastroCustos(Classes.Acoes.Alterar,custos );
            // frmCadastraEleitores.ShowDialog();
            DialogResult dialogResult = frmCadastroCustos.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            //Verificar se tem linha selecionada no grid
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe Itens selecionados.");
                return;
            }
            //confirmar exclusão
            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir.", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            //Pegar o Eleitor selecionado
            Custos custos = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Custos);
            //instanciar a regra de negorcios
            Negorcios negorcios = new Negorcios();
            String retorno = negorcios.ExcluirCustos(custos);
            //verifiar o retorno da execução
            try
            {
                int idEleitor = Convert.ToInt32(retorno);
                MessageBox.Show("Custo excluido com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir. Detalhes: " + retorno);
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {          
              Close();
        }


    }
}
