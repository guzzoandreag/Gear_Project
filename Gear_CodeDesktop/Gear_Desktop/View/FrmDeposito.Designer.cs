namespace Gear_Desktop.View
{
    partial class FrmDeposito
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
            this.cb_plantio = new System.Windows.Forms.ComboBox();
            this.txt_nome_dep_faz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tamanho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_dep_faz = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.pnlCenterCabecalhoRodape.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.pnlCenterMain.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenterCabecalhoRodape
            // 
            this.pnlCenterCabecalhoRodape.Controls.Add(this.txtURL);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.btnConfirmar);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.label4);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.cb_dep_faz);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.label3);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.label2);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.txt_tamanho);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.label1);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.txt_nome_dep_faz);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.cb_plantio);
            this.pnlCenterCabecalhoRodape.Size = new System.Drawing.Size(800, 400);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.lblMsg, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.cb_plantio, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.txt_nome_dep_faz, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.label1, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.txt_tamanho, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.label2, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.label3, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.cb_dep_faz, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.label4, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.btnConfirmar, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.txtURL, 0);
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
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(0, 300);
            this.lblMsg.Size = new System.Drawing.Size(800, 100);
            // 
            // cb_plantio
            // 
            this.cb_plantio.FormattingEnabled = true;
            this.cb_plantio.Location = new System.Drawing.Point(31, 124);
            this.cb_plantio.Name = "cb_plantio";
            this.cb_plantio.Size = new System.Drawing.Size(217, 23);
            this.cb_plantio.TabIndex = 5;
            // 
            // txt_nome_dep_faz
            // 
            this.txt_nome_dep_faz.Location = new System.Drawing.Point(31, 78);
            this.txt_nome_dep_faz.Name = "txt_nome_dep_faz";
            this.txt_nome_dep_faz.Size = new System.Drawing.Size(217, 23);
            this.txt_nome_dep_faz.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 58);
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
            this.label2.Location = new System.Drawing.Point(31, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tamanho da Fazenda";
            // 
            // txt_tamanho
            // 
            this.txt_tamanho.Location = new System.Drawing.Point(31, 170);
            this.txt_tamanho.Name = "txt_tamanho";
            this.txt_tamanho.Size = new System.Drawing.Size(217, 23);
            this.txt_tamanho.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(31, 104);
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
            this.label4.Location = new System.Drawing.Point(31, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Deposito / Fazenda";
            // 
            // cb_dep_faz
            // 
            this.cb_dep_faz.FormattingEnabled = true;
            this.cb_dep_faz.Location = new System.Drawing.Point(31, 34);
            this.cb_dep_faz.Name = "cb_dep_faz";
            this.cb_dep_faz.Size = new System.Drawing.Size(217, 23);
            this.cb_dep_faz.TabIndex = 11;
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
            this.btnConfirmar.Location = new System.Drawing.Point(31, 210);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 35);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(31, 371);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(256, 23);
            this.txtURL.TabIndex = 14;
            this.txtURL.Text = "http://localhost:8091/api/";
            // 
            // FrmDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionMsgVisible = true;
            this.CaptionRodape = "2022 © Gear Project - All Rights Reserved.";
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDeposito";
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
        private TextBox txt_tamanho;
        private Label label1;
        private TextBox txt_nome_dep_faz;
        private ComboBox cb_plantio;
        private Label label4;
        private ComboBox cb_dep_faz;
        public Button btnConfirmar;
        private TextBox txtURL;
    }
}