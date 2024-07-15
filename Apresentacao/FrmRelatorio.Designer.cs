namespace Apresentacao
{
    partial class FrmRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblCustosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustosDataSet = new Apresentacao.CustosDataSet();
            this.tblreceitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblCustosTableAdapter = new Apresentacao.CustosDataSetTableAdapters.tblCustosTableAdapter();
            this.tblreceitaTableAdapter = new Apresentacao.CustosDataSetTableAdapters.tblreceitaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblreceitaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCustosBindingSource
            // 
            this.tblCustosBindingSource.DataMember = "tblCustos";
            this.tblCustosBindingSource.DataSource = this.CustosDataSet;
            // 
            // CustosDataSet
            // 
            this.CustosDataSet.DataSetName = "CustosDataSet";
            this.CustosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblreceitaBindingSource
            // 
            this.tblreceitaBindingSource.DataMember = "tblreceita";
            this.tblreceitaBindingSource.DataSource = this.CustosDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 38;
            reportDataSource1.Name = "DataSetCustos";
            reportDataSource1.Value = this.tblCustosBindingSource;
            reportDataSource2.Name = "DataSetReceita";
            reportDataSource2.Value = this.tblreceitaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Apresentacao.RptCustos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(799, 487);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblCustosTableAdapter
            // 
            this.tblCustosTableAdapter.ClearBeforeFill = true;
            // 
            // tblreceitaTableAdapter
            // 
            this.tblreceitaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(799, 487);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCustosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblreceitaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.BindingSource tblCustosBindingSource;
        public CustosDataSet CustosDataSet;
        public System.Windows.Forms.BindingSource tblreceitaBindingSource;
        public CustosDataSetTableAdapters.tblCustosTableAdapter tblCustosTableAdapter;
        public CustosDataSetTableAdapters.tblreceitaTableAdapter tblreceitaTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

    }
}