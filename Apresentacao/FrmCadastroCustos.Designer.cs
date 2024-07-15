namespace Apresentacao
{
    partial class FrmCadastroCustos
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
            this.comboBoxGastos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxTotal = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelCdc = new System.Windows.Forms.Label();
            this.comboBoxCdc = new System.Windows.Forms.ComboBox();
            this.textBoxFavorecido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxGastos
            // 
            this.comboBoxGastos.FormattingEnabled = true;
            this.comboBoxGastos.Items.AddRange(new object[] {
            "Instalaçao",
            "Manutenção",
            "Operação"});
            this.comboBoxGastos.Location = new System.Drawing.Point(62, 28);
            this.comboBoxGastos.Name = "comboBoxGastos";
            this.comboBoxGastos.Size = new System.Drawing.Size(126, 21);
            this.comboBoxGastos.TabIndex = 0;
            this.comboBoxGastos.Text = "Instalaçao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Valor:";
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Location = new System.Drawing.Point(62, 85);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(306, 20);
            this.textBoxProduto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Produto:";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(62, 57);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(306, 20);
            this.textBoxCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Gastos:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(293, 192);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(212, 192);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "Inserir";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(62, 2);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.ReadOnly = true;
            this.textBoxCodigo.Size = new System.Drawing.Size(63, 20);
            this.textBoxCodigo.TabIndex = 42;
            this.textBoxCodigo.TabStop = false;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(16, 5);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 40;
            this.labelCodigo.Text = "Código:";
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(304, 113);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(64, 20);
            this.maskedTextBoxData.TabIndex = 6;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxQuantidade
            // 
            this.maskedTextBoxQuantidade.Location = new System.Drawing.Point(62, 113);
            this.maskedTextBoxQuantidade.Name = "maskedTextBoxQuantidade";
            this.maskedTextBoxQuantidade.Size = new System.Drawing.Size(47, 20);
            this.maskedTextBoxQuantidade.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Quant:";
            // 
            // maskedTextBoxTotal
            // 
            this.maskedTextBoxTotal.Location = new System.Drawing.Point(222, 113);
            this.maskedTextBoxTotal.Name = "maskedTextBoxTotal";
            this.maskedTextBoxTotal.Size = new System.Drawing.Size(47, 20);
            this.maskedTextBoxTotal.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Total:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(142, 113);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(47, 20);
            this.textBoxValor.TabIndex = 4;
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBoxValor_TextChanged);
            // 
            // labelCdc
            // 
            this.labelCdc.AutoSize = true;
            this.labelCdc.Location = new System.Drawing.Point(30, 142);
            this.labelCdc.Name = "labelCdc";
            this.labelCdc.Size = new System.Drawing.Size(29, 13);
            this.labelCdc.TabIndex = 48;
            this.labelCdc.Text = "Cdc:";
            // 
            // comboBoxCdc
            // 
            this.comboBoxCdc.FormattingEnabled = true;
            this.comboBoxCdc.Items.AddRange(new object[] {
            "Instalaçao",
            "Manutenção",
            "Operação"});
            this.comboBoxCdc.Location = new System.Drawing.Point(62, 139);
            this.comboBoxCdc.Name = "comboBoxCdc";
            this.comboBoxCdc.Size = new System.Drawing.Size(306, 21);
            this.comboBoxCdc.TabIndex = 7;
            // 
            // textBoxFavorecido
            // 
            this.textBoxFavorecido.Location = new System.Drawing.Point(65, 165);
            this.textBoxFavorecido.Name = "textBoxFavorecido";
            this.textBoxFavorecido.Size = new System.Drawing.Size(303, 20);
            this.textBoxFavorecido.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Destinado:";
            // 
            // FrmCadastroCustos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 217);
            this.Controls.Add(this.textBoxFavorecido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxCdc);
            this.Controls.Add(this.labelCdc);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.maskedTextBoxTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBoxQuantidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.comboBoxGastos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroCustos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGastos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label labelCdc;
        private System.Windows.Forms.ComboBox comboBoxCdc;
        private System.Windows.Forms.TextBox textBoxFavorecido;
        private System.Windows.Forms.Label label8;
    }
}