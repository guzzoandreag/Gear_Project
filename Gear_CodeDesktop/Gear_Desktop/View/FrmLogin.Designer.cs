namespace Gear_Desktop.View
{
    partial class FrmLogin
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
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtURL);
            this.panel4.Controls.Add(this.txtSenha);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Controls.Add(this.btnEntrar);
            this.panel4.Controls.Add(this.btnCadastrar);
            this.panel4.Size = new System.Drawing.Size(800, 550);
            this.panel4.Controls.SetChildIndex(this.btnCadastrar, 0);
            this.panel4.Controls.SetChildIndex(this.btnEntrar, 0);
            this.panel4.Controls.SetChildIndex(this.txtEmail, 0);
            this.panel4.Controls.SetChildIndex(this.txtSenha, 0);
            this.panel4.Controls.SetChildIndex(this.txtURL, 0);
            this.panel4.Controls.SetChildIndex(this.label2, 0);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.lblMsg, 0);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 580);
            this.panel3.Size = new System.Drawing.Size(800, 20);
            // 
            // BaseFormRodape
            // 
            this.BaseFormRodape.Size = new System.Drawing.Size(800, 20);
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
            this.BaseFormCabecalho.Text = "Login - Gear Project";
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(0, 441);
            this.lblMsg.Size = new System.Drawing.Size(800, 109);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.DimGray;
            this.txtSenha.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.Location = new System.Drawing.Point(264, 246);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(272, 23);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.DimGray;
            this.txtEmail.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(264, 196);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 23);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.White;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(35)))), ((int)(((byte)(89)))));
            this.btnEntrar.FlatAppearance.BorderSize = 2;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(35)))), ((int)(((byte)(89)))));
            this.btnEntrar.Location = new System.Drawing.Point(325, 322);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(150, 35);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(35)))), ((int)(((byte)(89)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(325, 363);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(150, 35);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.Color.DimGray;
            this.txtURL.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtURL.Location = new System.Drawing.Point(12, 16);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(272, 23);
            this.txtURL.TabIndex = 4;
            this.txtURL.Text = "http://localhost:8091/api/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(340, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Usuario(Email)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(376, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Senha";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionCabecalho = "Login - Gear Project";
            this.CaptionRodape = "2022 © Gear Project - All Rights Reserved.";
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtSenha;
        private TextBox txtEmail;
        private Button btnEntrar;
        private Button btnCadastrar;
        private TextBox txtURL;
        private Label label1;
        private Label label2;
    }
}