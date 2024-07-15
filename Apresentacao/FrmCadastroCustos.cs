using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Apresentacao.Classes;
using ObjetoTransferencia;
using RegraNegorcios;


namespace Apresentacao
{
    public partial class FrmCadastroCustos : Form
    {
        Acoes acaoNaTelaSelecionada; 
        public FrmCadastroCustos(Acoes acoes,Custos custos)
        {          
            InitializeComponent();
            this.acaoNaTelaSelecionada = acoes;


            if (acoes == Acoes.Inserir)
            {
                this.Text = "Inserir Cusots";
                this.buttonSalvar.Text = "Inserir";

            }else if(acoes == Acoes.Alterar)
            {
                this.Text = "Alterar Cusots";
                this.buttonSalvar.Text = "Alterar";
                textBoxCodigo.Text = custos.ID_Custos.ToString();
                comboBoxGastos.Text  = custos.Gastos.ToString();
                textBoxCliente.Text = custos.Cliente.ToString();
                textBoxProduto.Text = custos.Produto.ToString();
                maskedTextBoxQuantidade.Text = custos.Quant.ToString();
                textBoxValor.Text = custos.Valor.ToString();
                maskedTextBoxTotal.Text = custos.Total.ToString();
                maskedTextBoxData.Text = custos.Data.ToString();
            }

            Classes.Procedimentos.GetCCusto(comboBoxCdc);

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            #region Inserir
            if (acaoNaTelaSelecionada == Acoes.Inserir)
            {
                Custos custos = new Custos();
                custos.Gastos = comboBoxGastos.Text;
                custos.Cliente = textBoxCliente.Text;
                custos.Produto = textBoxProduto.Text;
                custos.Quant =Convert.ToInt32 (maskedTextBoxQuantidade.Text);
                custos.Valor =Convert.ToDecimal(textBoxValor.Text);
                custos.Total = Convert.ToDecimal(maskedTextBoxTotal.Text);
                custos.Data = maskedTextBoxData.Text;
                custos.cdc = comboBoxCdc.Text;
                custos.Favorecido = textBoxFavorecido.Text;

                Negorcios negorciosInserir = new Negorcios();
                string retorno = negorciosInserir.InserirCustos(custos);

                try
                {
                    int ID_Custos = Convert.ToInt32(retorno);
                    MessageBox.Show("Custo inserido com sucesso. Código: " + ID_Custos.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel inserir. Detalhes: " + retorno);
                    this.DialogResult = DialogResult.No;
                }
            }
            #endregion

            #region Alterar
            if (acaoNaTelaSelecionada == Acoes.Alterar)
            {
                Custos custos = new Custos();
                custos.ID_Custos  =Convert.ToInt32( textBoxCodigo.Text);
                custos.Gastos = comboBoxGastos.Text;
                custos.Cliente = textBoxCliente.Text;
                custos.Produto = textBoxProduto.Text;
                custos.Quant = Convert.ToInt32(maskedTextBoxQuantidade.Text);
                custos.Valor = Convert.ToDecimal(textBoxValor.Text);
                custos.Total = Convert.ToDecimal(maskedTextBoxTotal.Text);
                custos.Data = maskedTextBoxData.Text;
                custos.cdc = comboBoxCdc.Text;
                custos.Favorecido = textBoxFavorecido.Text;

                Negorcios negorciosInserir = new Negorcios();
                string retorno = negorciosInserir.AlterarCustos(custos);

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


            #endregion
        }

        

      

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            try
            {

                double quant = Convert.ToDouble(maskedTextBoxQuantidade.Text);
                double valor = Convert.ToDouble(textBoxValor.Text);
                double total = Convert.ToDouble(quant * valor);
                //String.Format("{0:#.#,##}", somatorio);
                maskedTextBoxTotal.Text =Convert.ToString(total);

                // MessageBox.Show(total);
            }
            catch { }
        }

       
       
    }
}
