namespace Gear_Desktop.View
{
    partial class FrmPSQ<T>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGridPesquisa = new System.Windows.Forms.DataGridView();
            this.pnlMenuPSQ = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCenterCabecalhoRodape.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.pnlCenterMain.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGridPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCenterCabecalhoRodape
            // 
            this.pnlCenterCabecalhoRodape.Controls.Add(this.dgvGridPesquisa);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.panel1);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.pnlMenuPSQ);
            this.pnlCenterCabecalhoRodape.Size = new System.Drawing.Size(778, 400);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.lblMsg, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.pnlMenuPSQ, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.panel1, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.dgvGridPesquisa, 0);
            // 
            // pnlRodape
            // 
            this.pnlRodape.Location = new System.Drawing.Point(0, 430);
            this.pnlRodape.Size = new System.Drawing.Size(778, 20);
            // 
            // BaseFormRodape
            // 
            this.BaseFormRodape.Size = new System.Drawing.Size(778, 20);
            this.BaseFormRodape.Text = "2022 © Gear Project - All Rights Reserved.";
            // 
            // pnlCenterMain
            // 
            this.pnlCenterMain.Size = new System.Drawing.Size(778, 450);
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.Size = new System.Drawing.Size(778, 30);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.Location = new System.Drawing.Point(666, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(722, 0);
            // 
            // BaseFormCabecalho
            // 
            this.BaseFormCabecalho.Location = new System.Drawing.Point(8, 0);
            this.BaseFormCabecalho.Size = new System.Drawing.Size(658, 30);
            this.BaseFormCabecalho.Text = "Pesquisa - Gear Project";
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(0, 362);
            this.lblMsg.Size = new System.Drawing.Size(778, 38);
            // 
            // dgvGridPesquisa
            // 
            this.dgvGridPesquisa.AllowUserToAddRows = false;
            this.dgvGridPesquisa.AllowUserToDeleteRows = false;
            this.dgvGridPesquisa.AllowUserToOrderColumns = true;
            this.dgvGridPesquisa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvGridPesquisa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(35)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGridPesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGridPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGridPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGridPesquisa.GridColor = System.Drawing.Color.Black;
            this.dgvGridPesquisa.Location = new System.Drawing.Point(75, 37);
            this.dgvGridPesquisa.Name = "dgvGridPesquisa";
            this.dgvGridPesquisa.ReadOnly = true;
            this.dgvGridPesquisa.RowHeadersWidth = 51;
            this.dgvGridPesquisa.RowTemplate.Height = 25;
            this.dgvGridPesquisa.Size = new System.Drawing.Size(703, 325);
            this.dgvGridPesquisa.TabIndex = 5;
            this.dgvGridPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGridPesquisa_CellDoubleClick);
            // 
            // pnlMenuPSQ
            // 
            this.pnlMenuPSQ.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuPSQ.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuPSQ.Name = "pnlMenuPSQ";
            this.pnlMenuPSQ.Size = new System.Drawing.Size(75, 362);
            this.pnlMenuPSQ.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(75, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 37);
            this.panel1.TabIndex = 7;
            // 
            // FrmPSQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionCabecalho = "Pesquisa - Gear Project";
            this.CaptionMsgVisible = true;
            this.CaptionRodape = "2022 © Gear Project - All Rights Reserved.";
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPSQ";
            this.Text = "FrmPSQ";
            this.pnlCenterCabecalhoRodape.ResumeLayout(false);
            this.pnlRodape.ResumeLayout(false);
            this.pnlCenterMain.ResumeLayout(false);
            this.pnlCabecalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGridPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvGridPesquisa;
        private Panel panel1;
        private Panel pnlMenuPSQ;
    }
}