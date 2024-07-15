using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;
using AcessoDados;
namespace Apresentacao
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            //this.Text = "Relatório";
          this.tblreceitaTableAdapter.Connection.ConnectionString = StrConn.StringConexao.StrConexao;
          this.tblCustosTableAdapter.Connection.ConnectionString = StrConn.StringConexao.StrConexao;
            //// TODO: This line of code loads data into the 'CustosDataSet.tblCustos' table. You can move, or remove it, as needed.
          this.tblCustosTableAdapter.Fill(this.CustosDataSet.tblCustos);
          // TODO: This line of code loads data into the 'CustosDataSet.tblreceita' table. You can move, or remove it, as needed.
          this.tblreceitaTableAdapter.Fill(this.CustosDataSet.tblreceita);
          this.reportViewer1.LocalReport.ReleaseSandboxAppDomain();
          this.reportViewer1.RefreshReport();
          this.Show();
            
            
          
        }
    }
}
