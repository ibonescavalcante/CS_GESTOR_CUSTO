using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AcessoDados;

namespace Apresentacao
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

     

        private void consultarToolStripMenuItemReceitas_Click(object sender, EventArgs e)
        {
         
        }


        FrmRelatorio this1 = new FrmRelatorio();
        private void relatoiosToolStripMenuItemRelatorios_Click(object sender, EventArgs e)
        {

            //this1.Text = "Relatório";
            //this1.tblreceitaTableAdapter.Connection.ConnectionString = StrConn.StringConexao.StrConexao;
            //this1.tblCustosTableAdapter.Connection.ConnectionString = StrConn.StringConexao.StrConexao;
            //// TODO: This line of code loads data into the 'CustosDataSet.tblCustos' table. You can move, or remove it, as needed.
            //this1.tblCustosTableAdapter.Fill(this1.CustosDataSet.tblCustos);
            //// TODO: This line of code loads data into the 'CustosDataSet.tblreceita' table. You can move, or remove it, as needed.
            //this1.tblreceitaTableAdapter.Fill(this1.CustosDataSet.tblreceita);
            //this1.reportViewer1.LocalReport.ReleaseSandboxAppDomain();
            //this1.reportViewer1.RefreshReport();
            //this1.Show();
            FrmRelatorio frmRelatorio = new FrmRelatorio();
            frmRelatorio.MdiParent = this;
            frmRelatorio.Show();
        }

        private void gastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarGastos frmGastos = new FrmConsultarGastos();
            frmGastos.MdiParent = this;
            frmGastos.Show();
        }

        private void receitaToolStripMenuItemReceita_Click(object sender, EventArgs e)
        {
            FrmConsultaReceitas frmReceitas = new FrmConsultaReceitas();
            frmReceitas.MdiParent = this;
            frmReceitas.Show();
        }

        private void centroDeCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastraCentroCusto frmCadastraCentroCusto = new FrmCadastraCentroCusto();
            frmCadastraCentroCusto.MdiParent = this;
            frmCadastraCentroCusto.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

      

       
    }
}
