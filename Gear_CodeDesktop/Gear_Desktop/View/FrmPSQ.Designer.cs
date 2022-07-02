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
            this.pnlCenterCabecalhoRodape.Location = new System.Drawing.Point(0, 40);
            this.pnlCenterCabecalhoRodape.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCenterCabecalhoRodape.Size = new System.Drawing.Size(1000, 533);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.lblMsg, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.dgvGridPesquisa, 0);
            // 
            // pnlRodape
            // 
            this.pnlRodape.Location = new System.Drawing.Point(0, 573);
            this.pnlRodape.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRodape.Size = new System.Drawing.Size(1000, 27);
            // 
            // BaseFormRodape
            // 
            this.BaseFormRodape.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BaseFormRodape.Size = new System.Drawing.Size(1000, 27);
            this.BaseFormRodape.Text = "2022 © Gear Project - All Rights Reserved.";
            // 
            // pnlCenterMain
            // 
            this.pnlCenterMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCenterMain.Size = new System.Drawing.Size(1000, 600);
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCabecalho.Size = new System.Drawing.Size(1000, 40);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.Location = new System.Drawing.Point(856, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Size = new System.Drawing.Size(72, 40);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(928, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Size = new System.Drawing.Size(72, 40);
            // 
            // BaseFormCabecalho
            // 
            this.BaseFormCabecalho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BaseFormCabecalho.Size = new System.Drawing.Size(846, 40);
            this.BaseFormCabecalho.Text = "Pesquisa - Gear Project";
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(0, 482);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Size = new System.Drawing.Size(1000, 51);
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
            this.dgvGridPesquisa.Location = new System.Drawing.Point(0, 0);
            this.dgvGridPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGridPesquisa.Name = "dgvGridPesquisa";
            this.dgvGridPesquisa.ReadOnly = true;
            this.dgvGridPesquisa.RowHeadersWidth = 51;
            this.dgvGridPesquisa.RowTemplate.Height = 25;
            this.dgvGridPesquisa.Size = new System.Drawing.Size(1000, 482);
            this.dgvGridPesquisa.TabIndex = 5;
            this.dgvGridPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGridPesquisa_CellDoubleClick);
            // 
            // FrmPSQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionCabecalho = "Pesquisa - Gear Project";
            this.CaptionMsgVisible = true;
            this.CaptionRodape = "2022 © Gear Project - All Rights Reserved.";
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1286, 1200);
            this.MinimumSize = new System.Drawing.Size(514, 400);
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
    }
}