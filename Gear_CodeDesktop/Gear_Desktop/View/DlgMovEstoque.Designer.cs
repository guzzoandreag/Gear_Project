namespace Gear_Desktop.View
{
    partial class DlgMovEstoque
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
            this.btnAdicionarETQ = new System.Windows.Forms.Button();
            this.btnTransferirETQ = new System.Windows.Forms.Button();
            this.pnlCenterCabecalhoRodape.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.pnlCenterMain.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenterCabecalhoRodape
            // 
            this.pnlCenterCabecalhoRodape.Controls.Add(this.btnTransferirETQ);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.btnAdicionarETQ);
            this.pnlCenterCabecalhoRodape.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCenterCabecalhoRodape.Size = new System.Drawing.Size(230, 140);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.btnAdicionarETQ, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.btnTransferirETQ, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.lblMsg, 0);
            // 
            // pnlRodape
            // 
            this.pnlRodape.Location = new System.Drawing.Point(0, 170);
            this.pnlRodape.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRodape.Size = new System.Drawing.Size(230, 30);
            // 
            // BaseFormRodape
            // 
            this.BaseFormRodape.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BaseFormRodape.Size = new System.Drawing.Size(230, 30);
            this.BaseFormRodape.Text = "2022 © Gear Project - All Rights Reserved.";
            // 
            // pnlCenterMain
            // 
            this.pnlCenterMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCenterMain.Size = new System.Drawing.Size(230, 200);
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCabecalho.Size = new System.Drawing.Size(230, 30);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.Location = new System.Drawing.Point(158, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Size = new System.Drawing.Size(36, 30);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(194, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Size = new System.Drawing.Size(36, 30);
            // 
            // BaseFormCabecalho
            // 
            this.BaseFormCabecalho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BaseFormCabecalho.Size = new System.Drawing.Size(148, 30);
            this.BaseFormCabecalho.Text = "Tipo Movto Estoque - Gear Project";
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(0, 140);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMsg.Size = new System.Drawing.Size(230, 0);
            // 
            // btnAdicionarETQ
            // 
            this.btnAdicionarETQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(35)))), ((int)(((byte)(89)))));
            this.btnAdicionarETQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarETQ.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdicionarETQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnAdicionarETQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarETQ.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionarETQ.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarETQ.Location = new System.Drawing.Point(40, 41);
            this.btnAdicionarETQ.Name = "btnAdicionarETQ";
            this.btnAdicionarETQ.Size = new System.Drawing.Size(150, 35);
            this.btnAdicionarETQ.TabIndex = 6;
            this.btnAdicionarETQ.Text = "ADICIONAR";
            this.btnAdicionarETQ.UseVisualStyleBackColor = false;
            this.btnAdicionarETQ.Click += new System.EventHandler(this.btnAdicionarETQ_Click);
            // 
            // btnTransferirETQ
            // 
            this.btnTransferirETQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(35)))), ((int)(((byte)(89)))));
            this.btnTransferirETQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransferirETQ.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTransferirETQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnTransferirETQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferirETQ.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransferirETQ.ForeColor = System.Drawing.Color.White;
            this.btnTransferirETQ.Location = new System.Drawing.Point(40, 91);
            this.btnTransferirETQ.Name = "btnTransferirETQ";
            this.btnTransferirETQ.Size = new System.Drawing.Size(150, 35);
            this.btnTransferirETQ.TabIndex = 7;
            this.btnTransferirETQ.Text = "TRANSFERIR";
            this.btnTransferirETQ.UseVisualStyleBackColor = false;
            this.btnTransferirETQ.Click += new System.EventHandler(this.btnTransferirETQ_Click);
            // 
            // DlgMovEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ButtonMinimizeVisible = true;
            this.CaptionCabecalho = "Tipo Movto Estoque - Gear Project";
            this.CaptionMsgVisible = true;
            this.CaptionRodape = "2022 © Gear Project - All Rights Reserved.";
            this.CaptionRodapeVisible = true;
            this.ClientSize = new System.Drawing.Size(230, 200);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(636, 587);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "DlgMovEstoque";
            this.Text = "FrmMovEstoque";
            this.pnlCenterCabecalhoRodape.ResumeLayout(false);
            this.pnlRodape.ResumeLayout(false);
            this.pnlCenterMain.ResumeLayout(false);
            this.pnlCabecalho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Button btnTransferirETQ;
        public Button btnAdicionarETQ;
    }
}