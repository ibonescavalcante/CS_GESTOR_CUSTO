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
    public partial class FrmConsultaReceitas : Form
    {
        public FrmConsultaReceitas()
        {
            InitializeComponent();
        }
        private void AtualizarGridReceita()
        {
            Negorcios custosNegorcios = new Negorcios();
            ReceitaColecao receitaColecao = new ReceitaColecao();
            receitaColecao = custosNegorcios.ConsultarReceita(textBoxPesquisar.Text);
            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = receitaColecao;
            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
            Classes.Procedimentos.ConfiguraDataGridReceita(dataGridViewPrincipal);
             labelTotal.Text = Classes.Procedimentos.GetTotal(dataGridViewPrincipal, "Valor");

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGridReceita();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            FrmCadastraReceita FrmCadastraReceita = new FrmCadastraReceita(Classes.Acoes.Inserir, null);
            DialogResult dialogResult = FrmCadastraReceita.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGridReceita();
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe Itens selecionados.");
                return;
            }
            //Pegar o Eleitor selecionado no grid
            Receita receita = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Receita);
            FrmCadastraReceita rrmCadastraReceita = new FrmCadastraReceita(Classes.Acoes.Alterar, receita);
            // frmCadastraEleitores.ShowDialog();
            DialogResult dialogResult = rrmCadastraReceita.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGridReceita();
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
            Receita receita = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Receita);
            //instanciar a regra de negorcios
            Negorcios negorcios = new Negorcios();
            String retorno = negorcios.ExcluirReceita(receita);
            //verifiar o retorno da execução
            try
            {
                int idEleitor = Convert.ToInt32(retorno);
                MessageBox.Show("Dado excluido com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGridReceita();
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
