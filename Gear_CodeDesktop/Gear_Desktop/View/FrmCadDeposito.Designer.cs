namespace Gear_Desktop.View
{
    partial class FrmCadDeposito
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
            this.cbTipoPlantio = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTamanhoFazenda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoCadastro = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlCenterCabecalhoRodape.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.pnlCenterMain.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenterCabecalhoRodape
            // 
            this.pnlCenterCabecalhoRodape.Controls.Add(this.btnConfirmar);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.label4);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.cbTipoCadastro);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.label3);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.label2);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.txtTamanhoFazenda);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.label1);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.txtNome);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.cbTipoPlantio);
            this.pnlCenterCabecalhoRodape.Size = new System.Drawing.Size(800, 400);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.lblMsg, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.cbTipoPlantio, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.txtNome, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.label1, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.txtTamanhoFazenda, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.label2, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.label3, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.cbTipoCadastro, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.label4, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.btnConfirmar, 0);
            // 
            // pnlRodape
            // 
            this.pnlRodape.Location = new System.Drawing.Point(0, 430);
            this.pnlRodape.Size = new System.Drawing.Size(800, 20);
            // 
            // BaseFormRodape
            // 
            this.BaseFormRodape.Size = new System.Drawing.Size(800, 20);
            this.BaseFormRodape.Text = "2022 © Gear Project - All Rights Reserved.";
            // 
            // pnlCenterMain
            // 
            this.pnlCenterMain.Size = new System.Drawing.Size(800, 450);
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.Size = new System.Drawing.Size(800, 30);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.Location = new System.Drawing.Point(688, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(744, 0);
            // 
            // BaseFormCabecalho
            // 
            this.BaseFormCabecalho.Size = new System.Drawing.Size(678, 30);
            this.BaseFormCabecalho.Text = "Cadastro de Deposito/Fazenda - Gear Project";
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(0, 300);
            this.lblMsg.Size = new System.Drawing.Size(800, 100);
            // 
            // cbTipoPlantio
            // 
            this.cbTipoPlantio.BackColor = System.Drawing.Color.DimGray;
            this.cbTipoPlantio.FormattingEnabled = true;
            this.cbTipoPlantio.Items.AddRange(new object[] {
            "1 - CAFÉ",
            "2 - BANANA",
            "3 - SERINGA",
            "4 - PIMENTA"});
            this.cbTipoPlantio.Location = new System.Drawing.Point(292, 208);
            this.cbTipoPlantio.Name = "cbTipoPlantio";
            this.cbTipoPlantio.Size = new System.Drawing.Size(217, 23);
            this.cbTipoPlantio.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.DimGray;
            this.txtNome.Location = new System.Drawing.Point(292, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(217, 23);
            this.txtNome.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(380, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(324, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tamanho da Fazenda";
            // 
            // txtTamanhoFazenda
            // 
            this.txtTamanhoFazenda.BackColor = System.Drawing.Color.DimGray;
            this.txtTamanhoFazenda.Location = new System.Drawing.Point(292, 264);
            this.txtTamanhoFazenda.Name = "txtTamanhoFazenda";
            this.txtTamanhoFazenda.Size = new System.Drawing.Size(217, 23);
            this.txtTamanhoFazenda.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(336, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo de Plantio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(380, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo";
            // 
            // cbTipoCadastro
            // 
            this.cbTipoCadastro.BackColor = System.Drawing.Color.DimGray;
            this.cbTipoCadastro.FormattingEnabled = true;
            this.cbTipoCadastro.Items.AddRange(new object[] {
            "1 - MATRIZ",
            "2 - FAZENDA",
            "3 - DEPOSITO",
            "4 - SECADOR"});
            this.cbTipoCadastro.Location = new System.Drawing.Point(292, 152);
            this.cbTipoCadastro.Name = "cbTipoCadastro";
            this.cbTipoCadastro.Size = new System.Drawing.Size(217, 23);
            this.cbTipoCadastro.TabIndex = 11;
            this.cbTipoCadastro.SelectedValueChanged += new System.EventHandler(this.cb_dep_faz_SelectedValueChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(35)))), ((int)(((byte)(89)))));
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(325, 313);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 35);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmCadDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionCabecalho = "Cadastro de Deposito/Fazenda - Gear Project";
            this.CaptionMsgVisible = true;
            this.CaptionRodape = "2022 © Gear Project - All Rights Reserved.";
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadDeposito";
            this.Text = "FrmDeposito";
            this.Load += new System.EventHandler(this.FrmDeposito_Load);
            this.pnlCenterCabecalhoRodape.ResumeLayout(false);
            this.pnlCenterCabecalhoRodape.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.pnlCenterMain.ResumeLayout(false);
            this.pnlCabecalho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox txtTamanhoFazenda;
        private Label label1;
        private TextBox txtNome;
        private ComboBox cbTipoPlantio;
        private Label label4;
        private ComboBox cbTipoCadastro;
        public Button btnConfirmar;
    }
}