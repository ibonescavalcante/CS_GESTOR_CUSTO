using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apresentacao.Classes;
using RegraNegorcios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmCadastraCentroCusto : Form
    {
    
        public FrmCadastraCentroCusto()
        {
            InitializeComponent();

        
       
        }

        private void AtualizarGrid()
        {
            Negorcios negorcios = new Negorcios();
            CCustoColecao cCustosColecao = new CCustoColecao();
            cCustosColecao = negorcios.ConsultarCC(textBoxCentroCPesquisa.Text);
            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = cCustosColecao;
            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
            Classes.Procedimentos.ConfiguraDataGridCCusto(dataGridViewPrincipal);
            //labelTotal.Text = Classes.Procedimentos.GetTotal(dataGridViewPrincipal, "Total");

        }

        private void buttonPesquisa_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (textBoxCentroCPesquisa.Text == "") { MessageBox.Show("Centro de Custo inválido."); return; }
            CCusto cCusto=new CCusto();
            Negorcios negorcios = new Negorcios();
            cCusto.CDC_Descricao = textBoxCentroCPesquisa.Text;
            negorcios.InserirCC(cCusto);
            AtualizarGrid();            
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente Alterar.", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            Negorcios negorcios = new Negorcios();
            CCusto cCusto =new CCusto();
            cCusto.ID_CDC = Convert.ToInt32(textBoxCodigo.Text);
            cCusto.CDC_Descricao = textBoxCentroCPesquisa.Text;
            //instanciar a regra de negorcios
           
            String retorno = negorcios.AlterarCC(cCusto);
            MessageBox.Show(retorno);
            AtualizarGrid();
      
        }

        private void dataGridViewPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CCusto cCusto = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as CCusto);
            textBoxCentroCPesquisa.Text= cCusto.CDC_Descricao;
            textBoxCodigo.Text = Convert.ToString(cCusto.ID_CDC);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente Excluir.", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            Negorcios negorcios = new Negorcios();
            CCusto cCusto = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as CCusto);        
            //instanciar a regra de negorcios

            String retorno = negorcios.ExcluirCC(cCusto);
            MessageBox.Show(retorno);
            AtualizarGrid();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Procedimentos.GetCCusto(comboBox1);
        }
      
    }
}
