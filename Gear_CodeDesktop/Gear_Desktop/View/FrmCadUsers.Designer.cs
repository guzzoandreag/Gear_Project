namespace Gear_Desktop.View
{
    partial class FrmCadUsers
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pnlCenterCabecalhoRodape.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.pnlCenterMain.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenterCabecalhoRodape
            // 
            this.pnlCenterCabecalhoRodape.Controls.Add(this.btnPesquisar);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.label3);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.txtSenha);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.label2);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.txtName);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.btnConfirmar);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.label1);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.txtEmail);
            this.pnlCenterCabecalhoRodape.Size = new System.Drawing.Size(834, 600);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.txtEmail, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.label1, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.btnConfirmar, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.txtName, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.label2, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.txtSenha, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.label3, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.lblMsg, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.btnPesquisar, 0);
            // 
            // pnlRodape
            // 
            this.pnlRodape.Location = new System.Drawing.Point(0, 630);
            this.pnlRodape.Size = new System.Drawing.Size(834, 20);
            // 
            // BaseFormRodape
            // 
            this.BaseFormRodape.Size = new System.Drawing.Size(834, 20);
            this.BaseFormRodape.Text = "2022 © Gear Project - All Rights Reserved.";
            // 
            // pnlCenterMain
            // 
            this.pnlCenterMain.Size = new System.Drawing.Size(834, 650);
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.Size = new System.Drawing.Size(834, 30);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.Location = new System.Drawing.Point(722, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(778, 0);
            // 
            // BaseFormCabecalho
            // 
            this.BaseFormCabecalho.Size = new System.Drawing.Size(712, 30);
            this.BaseFormCabecalho.Text = "Cad. Usuario - Gear Project";
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(0, 560);
            this.lblMsg.Size = new System.Drawing.Size(834, 40);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(393, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.DarkGray;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.Location = new System.Drawing.Point(313, 307);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(208, 23);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.Enter += new System.EventHandler(this.TxtSenha_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(397, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.DarkGray;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(313, 197);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 23);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.Enter += new System.EventHandler(this.TxtName_Enter);
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
            this.btnConfirmar.Location = new System.Drawing.Point(342, 352);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 35);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(393, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.DarkGray;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(313, 252);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 23);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.Enter += new System.EventHandler(this.TxtEmail_Enter);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(35)))), ((int)(((byte)(89)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(359, 393);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(117, 35);
            this.btnPesquisar.TabIndex = 25;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Visible = false;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // FrmCadUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ButtonMinimizeVisible = true;
            this.CaptionCabecalho = "Cad. Usuario - Gear Project";
            this.CaptionMsgVisible = true;
            this.CaptionRodape = "2022 © Gear Project - All Rights Reserved.";
            this.CaptionRodapeVisible = true;
            this.ClientSize = new System.Drawing.Size(834, 650);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadUsers";
            this.Text = "FrmCadUsers";
            this.pnlCenterCabecalhoRodape.ResumeLayout(false);
            this.pnlCenterCabecalhoRodape.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.pnlCenterMain.ResumeLayout(false);
            this.pnlCabecalho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Label label3;
        public TextBox txtSenha;
        private Label label2;
        public TextBox txtName;
        public Button btnConfirmar;
        private Label label1;
        public TextBox txtEmail;
        public Button btnPesquisar;
    }
}