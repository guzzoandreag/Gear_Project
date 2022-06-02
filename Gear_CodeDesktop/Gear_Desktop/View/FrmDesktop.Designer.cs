namespace Gear_Desktop.View
{
    partial class FrmDesktop
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnMovDespesa = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnMovTransferencia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCadDeposito = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlCenterCabecalhoRodape.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.pnlCenterMain.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.splitter1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BaseFormCabecalho
            // 
            this.BaseFormCabecalho.Text = "Desktop - Gear Project";
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(166, 541);
            this.lblMsg.Size = new System.Drawing.Size(834, 109);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Black;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(165, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 650);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 650);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 330);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 270);
            this.panel3.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnMovDespesa);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 45);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5, 2, 5, 5);
            this.panel6.Size = new System.Drawing.Size(165, 45);
            this.panel6.TabIndex = 32;
            // 
            // btnMovDespesa
            // 
            this.btnMovDespesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(35)))), ((int)(((byte)(89)))));
            this.btnMovDespesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMovDespesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovDespesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMovDespesa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMovDespesa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnMovDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovDespesa.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMovDespesa.ForeColor = System.Drawing.Color.White;
            this.btnMovDespesa.Location = new System.Drawing.Point(5, 2);
            this.btnMovDespesa.Margin = new System.Windows.Forms.Padding(0);
            this.btnMovDespesa.Name = "btnMovDespesa";
            this.btnMovDespesa.Size = new System.Drawing.Size(155, 38);
            this.btnMovDespesa.TabIndex = 31;
            this.btnMovDespesa.Text = "Despesas";
            this.btnMovDespesa.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnMovTransferencia);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(5, 5, 5, 2);
            this.panel7.Size = new System.Drawing.Size(165, 45);
            this.panel7.TabIndex = 31;
            // 
            // btnMovTransferencia
            // 
            this.btnMovTransferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(35)))), ((int)(((byte)(89)))));
            this.btnMovTransferencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovTransferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMovTransferencia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMovTransferencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnMovTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovTransferencia.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMovTransferencia.ForeColor = System.Drawing.Color.White;
            this.btnMovTransferencia.Location = new System.Drawing.Point(5, 5);
            this.btnMovTransferencia.Margin = new System.Windows.Forms.Padding(0);
            this.btnMovTransferencia.Name = "btnMovTransferencia";
            this.btnMovTransferencia.Size = new System.Drawing.Size(155, 38);
            this.btnMovTransferencia.TabIndex = 30;
            this.btnMovTransferencia.Text = "Transferencia Depositos";
            this.btnMovTransferencia.UseVisualStyleBackColor = false;
            this.btnMovTransferencia.Click += new System.EventHandler(this.btnMovTransferencia_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "MOVIMENTOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 270);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCadProduto);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5, 2, 5, 5);
            this.panel5.Size = new System.Drawing.Size(165, 45);
            this.panel5.TabIndex = 32;
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(35)))), ((int)(((byte)(89)))));
            this.btnCadProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnCadProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadProduto.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadProduto.ForeColor = System.Drawing.Color.White;
            this.btnCadProduto.Location = new System.Drawing.Point(5, 2);
            this.btnCadProduto.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(155, 38);
            this.btnCadProduto.TabIndex = 31;
            this.btnCadProduto.Text = "Produto";
            this.btnCadProduto.UseVisualStyleBackColor = false;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCadDeposito);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5, 5, 5, 2);
            this.panel4.Size = new System.Drawing.Size(165, 45);
            this.panel4.TabIndex = 31;
            // 
            // btnCadDeposito
            // 
            this.btnCadDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(35)))), ((int)(((byte)(89)))));
            this.btnCadDeposito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadDeposito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadDeposito.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadDeposito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnCadDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadDeposito.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadDeposito.ForeColor = System.Drawing.Color.White;
            this.btnCadDeposito.Location = new System.Drawing.Point(5, 5);
            this.btnCadDeposito.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadDeposito.Name = "btnCadDeposito";
            this.btnCadDeposito.Size = new System.Drawing.Size(155, 38);
            this.btnCadDeposito.TabIndex = 30;
            this.btnCadDeposito.Text = "Deposito \\n Fazenda";
            this.btnCadDeposito.UseVisualStyleBackColor = false;
            this.btnCadDeposito.Click += new System.EventHandler(this.btnCadDeposito_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTROS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::Gear_Desktop.Properties.Resources.btnDeslogar32x;
            this.btnLogout.Location = new System.Drawing.Point(0, 600);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(165, 50);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionCabecalho = "Desktop - Gear Project";
            this.CaptionMsgVisible = true;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Name = "FrmDesktop";
            this.Text = "FrmDesktop";
            this.Load += new System.EventHandler(this.FrmDesktop_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlCenterCabecalhoRodape.ResumeLayout(false);
            this.pnlRodape.ResumeLayout(false);
            this.pnlCenterMain.ResumeLayout(false);
            this.pnlCabecalho.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Splitter splitter1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel5;
        private Button btnCadProduto;
        private Panel panel4;
        private Button btnCadDeposito;
        private Panel panel3;
        private Panel panel6;
        private Button btnMovDespesa;
        private Panel panel7;
        private Button btnMovTransferencia;
    }
}