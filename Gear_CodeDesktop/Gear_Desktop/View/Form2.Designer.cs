namespace Gear_Desktop.View
{
    public partial class FrmCadastroUsers
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
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(800, 570);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.None;
            this.panel3.Size = new System.Drawing.Size(663, 20);
            // 
            // BaseFormRodape
            // 
            this.BaseFormRodape.Size = new System.Drawing.Size(663, 20);
            this.BaseFormRodape.Text = "2022 © Gear Project - All Rights Reserved.";
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(800, 600);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(800, 30);
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
            this.BaseFormCabecalho.Text = "Cadastro - Gear Project";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label3.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(336, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Favor a Senha :";
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World);
            this.txt_senha.Location = new System.Drawing.Point(296, 260);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(208, 22);
            this.txt_senha.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(296, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Favor Inserir o Apelido :";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World);
            this.txt_nome.Location = new System.Drawing.Point(296, 150);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(208, 22);
            this.txt_nome.TabIndex = 15;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(35)))), ((int)(((byte)(89)))));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirmar.FlatAppearance.BorderSize = 2;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(325, 290);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 35);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Favor Inserir o E-mail :";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World);
            this.txt_email.Location = new System.Drawing.Point(296, 205);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(208, 22);
            this.txt_email.TabIndex = 13;
            // 
            // FrmCadastroUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionCabecalho = "Cadastro - Gear Project";
            this.CaptionRodape = "2022 © Gear Project - All Rights Reserved.";
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastroUsers";
            this.Text = "";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.txt_email, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnConfirmar, 0);
            this.Controls.SetChildIndex(this.txt_nome, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_senha, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label label3;
        public TextBox txt_senha;
        private Label label2;
        public TextBox txt_nome;
        public Button btnConfirmar;
        private Label label1;
        public TextBox txt_email;
    }
}