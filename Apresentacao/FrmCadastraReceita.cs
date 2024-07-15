using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegraNegorcios;

namespace Apresentacao
{
    public partial class FrmCadastraReceita : Form
    {
        Classes.Acoes acoesNaTela;
        public FrmCadastraReceita(Classes.Acoes acoes, Receita receita)
        {
            InitializeComponent();

            acoesNaTela = acoes;
            if(acoes == Classes.Acoes.Inserir)
            {
                this.Text = "Inserir";
                this.buttonSalvar.Text = "Inserir";
            }
            if (acoes == Classes.Acoes.Alterar)
            {
                this.Text = "Alterar";
                this.buttonSalvar.Text = "Alterar";

               textBoxCodigo.Text = Convert.ToString(receita.ID_Receita);
               textBoxPatrocinio.Text = Convert.ToString(receita.Patrocinio);
               textBoxvalor.Text = Convert.ToString(receita.Valor);
               textBoxData.Text = Convert.ToString(receita.Data);

            }

            Classes.Procedimentos.GetCCusto(comboBoxCdc);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (acoesNaTela == Classes.Acoes.Inserir)
            {
                Receita receita = new Receita();
                receita.Patrocinio = textBoxPatrocinio.Text;
                receita.Valor = Convert.ToDecimal(textBoxvalor.Text);
                receita.Data = textBoxData.Text;
                receita.cdc = comboBoxCdc.Text;

                Negorcios negorciosInserir = new Negorcios();
                string retorno = negorciosInserir.InserirReceita(receita);

                try
                {
                    int ID_Custos = Convert.ToInt32(retorno);
                    MessageBox.Show("Dados inserido com sucesso. Código: " + ID_Custos.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel inserir. Detalhes: " + retorno);
                    this.DialogResult = DialogResult.No;
                }

            }
            else if (acoesNaTela == Classes.Acoes.Alterar)
            {
                Receita receita = new Receita();
                receita.ID_Receita = Convert.ToInt32(textBoxCodigo.Text);
                receita.Patrocinio = textBoxPatrocinio.Text;
                receita.Valor = Convert.ToDecimal(textBoxvalor.Text);
                receita.Data = textBoxData.Text;
                receita.cdc = comboBoxCdc.Text;
               

                Negorcios negorciosInserir = new Negorcios();
                string retorno = negorciosInserir.AlterarReceita(receita);

                try
                {
                    int ID_Custos = Convert.ToInt32(retorno);
                    MessageBox.Show("Custo Alterado com sucesso. Código: " + ID_Custos.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel Alterar. Detalhes: " + retorno);
                    this.DialogResult = DialogResult.No;
                }

            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
