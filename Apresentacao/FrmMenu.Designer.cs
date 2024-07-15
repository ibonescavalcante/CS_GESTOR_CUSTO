namespace Apresentacao
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CadastrarToolStripMenuItemGastos = new System.Windows.Forms.ToolStripMenuItem();
            this.gastoToolStripMenuItemGasto = new System.Windows.Forms.ToolStripMenuItem();
            this.receitaToolStripMenuItemReceita = new System.Windows.Forms.ToolStripMenuItem();
            this.centroDeCustoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoiosToolStripMenuItemRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastrarToolStripMenuItemGastos,
            this.relatoiosToolStripMenuItemRelatorios,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CadastrarToolStripMenuItemGastos
            // 
            this.CadastrarToolStripMenuItemGastos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gastoToolStripMenuItemGasto,
            this.receitaToolStripMenuItemReceita,
            this.centroDeCustoToolStripMenuItem});
            this.CadastrarToolStripMenuItemGastos.Name = "CadastrarToolStripMenuItemGastos";
            this.CadastrarToolStripMenuItemGastos.Size = new System.Drawing.Size(69, 20);
            this.CadastrarToolStripMenuItemGastos.Text = "Cadastrar";
            // 
            // gastoToolStripMenuItemGasto
            // 
            this.gastoToolStripMenuItemGasto.Name = "gastoToolStripMenuItemGasto";
            this.gastoToolStripMenuItemGasto.Size = new System.Drawing.Size(160, 22);
            this.gastoToolStripMenuItemGasto.Text = "Gasto";
            this.gastoToolStripMenuItemGasto.Click += new System.EventHandler(this.gastoToolStripMenuItem_Click);
            // 
            // receitaToolStripMenuItemReceita
            // 
            this.receitaToolStripMenuItemReceita.Name = "receitaToolStripMenuItemReceita";
            this.receitaToolStripMenuItemReceita.Size = new System.Drawing.Size(160, 22);
            this.receitaToolStripMenuItemReceita.Text = "Receita";
            this.receitaToolStripMenuItemReceita.Click += new System.EventHandler(this.receitaToolStripMenuItemReceita_Click);
            // 
            // centroDeCustoToolStripMenuItem
            // 
            this.centroDeCustoToolStripMenuItem.Name = "centroDeCustoToolStripMenuItem";
            this.centroDeCustoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.centroDeCustoToolStripMenuItem.Text = "Centro de Custo";
            this.centroDeCustoToolStripMenuItem.Click += new System.EventHandler(this.centroDeCustoToolStripMenuItem_Click);
            // 
            // relatoiosToolStripMenuItemRelatorios
            // 
            this.relatoiosToolStripMenuItemRelatorios.Name = "relatoiosToolStripMenuItemRelatorios";
            this.relatoiosToolStripMenuItemRelatorios.Size = new System.Drawing.Size(67, 20);
            this.relatoiosToolStripMenuItemRelatorios.Text = "Relatoios";
            this.relatoiosToolStripMenuItemRelatorios.Click += new System.EventHandler(this.relatoiosToolStripMenuItemRelatorios_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1014, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(136, 21);
            this.toolStripStatusLabel1.Text = "Cavalcant\'s Solutions";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 438);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Gerenciamento de Custos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CadastrarToolStripMenuItemGastos;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem relatoiosToolStripMenuItemRelatorios;
        private System.Windows.Forms.ToolStripMenuItem gastoToolStripMenuItemGasto;
        private System.Windows.Forms.ToolStripMenuItem receitaToolStripMenuItemReceita;
        private System.Windows.Forms.ToolStripMenuItem centroDeCustoToolStripMenuItem;
    }
}

