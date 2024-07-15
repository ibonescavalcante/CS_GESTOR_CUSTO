namespace Apresentacao
{
    partial class FrmCadastraReceita
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxvalor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPatrocinio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCdc = new System.Windows.Forms.ComboBox();
            this.labelCdc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(287, 123);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(206, 123);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Inserir";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(64, 6);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.ReadOnly = true;
            this.textBoxCodigo.Size = new System.Drawing.Size(63, 20);
            this.textBoxCodigo.TabIndex = 53;
            this.textBoxCodigo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Data:";
            // 
            // textBoxvalor
            // 
            this.textBoxvalor.Location = new System.Drawing.Point(236, 62);
            this.textBoxvalor.Name = "textBoxvalor";
            this.textBoxvalor.Size = new System.Drawing.Size(126, 20);
            this.textBoxvalor.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Valor:";
            // 
            // textBoxPatrocinio
            // 
            this.textBoxPatrocinio.Location = new System.Drawing.Point(64, 34);
            this.textBoxPatrocinio.Name = "textBoxPatrocinio";
            this.textBoxPatrocinio.Size = new System.Drawing.Size(298, 20);
            this.textBoxPatrocinio.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Patrocinio:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(15, 10);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 54;
            this.labelCodigo.Text = "Código:";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(64, 63);
            this.textBoxData.Mask = "00/00/0000";
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(126, 20);
            this.textBoxData.TabIndex = 1;
            this.textBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxCdc
            // 
            this.comboBoxCdc.FormattingEnabled = true;
            this.comboBoxCdc.Items.AddRange(new object[] {
            "Instalaçao",
            "Manutenção",
            "Operação"});
            this.comboBoxCdc.Location = new System.Drawing.Point(64, 96);
            this.comboBoxCdc.Name = "comboBoxCdc";
            this.comboBoxCdc.Size = new System.Drawing.Size(298, 21);
            this.comboBoxCdc.TabIndex = 3;
            // 
            // labelCdc
            // 
            this.labelCdc.AutoSize = true;
            this.labelCdc.Location = new System.Drawing.Point(29, 99);
            this.labelCdc.Name = "labelCdc";
            this.labelCdc.Size = new System.Drawing.Size(29, 13);
            this.labelCdc.TabIndex = 55;
            this.labelCdc.Text = "Cdc:";
            // 
            // FrmCadastraReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 176);
            this.Controls.Add(this.comboBoxCdc);
            this.Controls.Add(this.labelCdc);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxvalor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPatrocinio);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCadastraReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastraReceita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxvalor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPatrocinio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.MaskedTextBox textBoxData;
        private System.Windows.Forms.ComboBox comboBoxCdc;
        private System.Windows.Forms.Label labelCdc;
    }
}