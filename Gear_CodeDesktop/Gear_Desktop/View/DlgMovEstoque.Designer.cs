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
            this.pnlCenterCabecalhoRodape.Size = new System.Drawing.Size(400, 250);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.btnAdicionarETQ, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.btnTransferirETQ, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.lblMsg, 0);
            // 
            // pnlRodape
            // 
            this.pnlRodape.Location = new System.Drawing.Point(0, 280);
            this.pnlRodape.Size = new System.Drawing.Size(400, 20);
            // 
            // BaseFormRodape
            // 
            this.BaseFormRodape.Size = new System.Drawing.Size(400, 20);
            this.BaseFormRodape.Text = "2022 © Gear Project - All Rights Reserved.";
            // 
            // pnlCenterMain
            // 
            this.pnlCenterMain.Size = new System.Drawing.Size(400, 300);
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.Size = new System.Drawing.Size(400, 30);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.Location = new System.Drawing.Point(288, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(344, 0);
            // 
            // BaseFormCabecalho
            // 
            this.BaseFormCabecalho.Size = new System.Drawing.Size(278, 30);
            this.BaseFormCabecalho.Text = "Tipo Movto Estoque - Gear Project";
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(0, 233);
            this.lblMsg.Size = new System.Drawing.Size(400, 17);
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
            this.btnAdicionarETQ.Location = new System.Drawing.Point(82, 60);
            this.btnAdicionarETQ.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdicionarETQ.Name = "btnAdicionarETQ";
            this.btnAdicionarETQ.Size = new System.Drawing.Size(236, 54);
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
            this.btnTransferirETQ.Location = new System.Drawing.Point(82, 136);
            this.btnTransferirETQ.Margin = new System.Windows.Forms.Padding(5);
            this.btnTransferirETQ.Name = "btnTransferirETQ";
            this.btnTransferirETQ.Size = new System.Drawing.Size(236, 54);
            this.btnTransferirETQ.TabIndex = 7;
            this.btnTransferirETQ.Text = "TRANSFERIR";
            this.btnTransferirETQ.UseVisualStyleBackColor = false;
            this.btnTransferirETQ.Click += new System.EventHandler(this.btnTransferirETQ_Click);
            // 
            // DlgMovEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionCabecalho = "Tipo Movto Estoque - Gear Project";
            this.CaptionMsgVisible = true;
            this.CaptionRodape = "2022 © Gear Project - All Rights Reserved.";
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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