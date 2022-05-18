namespace Gear_Desktop.View
{
    partial class FrmBaseDesktop
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlCenterMenu = new System.Windows.Forms.Panel();
            this.pnlCenterCabecalhoRodape.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.pnlCenterMain.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenterCabecalhoRodape
            // 
            this.pnlCenterCabecalhoRodape.Controls.Add(this.pnlCenterMenu);
            this.pnlCenterCabecalhoRodape.Controls.Add(this.pnlMenu);
            this.pnlCenterCabecalhoRodape.Size = new System.Drawing.Size(1000, 650);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.pnlMenu, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.pnlCenterMenu, 0);
            this.pnlCenterCabecalhoRodape.Controls.SetChildIndex(this.lblMsg, 0);
            // 
            // pnlRodape
            // 
            this.pnlRodape.Location = new System.Drawing.Point(0, 680);
            this.pnlRodape.Size = new System.Drawing.Size(1000, 20);
            // 
            // BaseFormRodape
            // 
            this.BaseFormRodape.Size = new System.Drawing.Size(1000, 20);
            this.BaseFormRodape.Text = "2022 © Gear Project - All Rights Reserved.";
            // 
            // pnlCenterMain
            // 
            this.pnlCenterMain.Size = new System.Drawing.Size(1000, 700);
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.Size = new System.Drawing.Size(1000, 30);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.Location = new System.Drawing.Point(888, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(944, 0);
            // 
            // BaseFormCabecalho
            // 
            this.BaseFormCabecalho.Size = new System.Drawing.Size(878, 30);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(166, 550);
            this.lblMsg.Size = new System.Drawing.Size(834, 100);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(166, 650);
            this.pnlMenu.TabIndex = 6;
            // 
            // pnlCenterMenu
            // 
            this.pnlCenterMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterMenu.Location = new System.Drawing.Point(166, 0);
            this.pnlCenterMenu.Name = "pnlCenterMenu";
            this.pnlCenterMenu.Size = new System.Drawing.Size(834, 650);
            this.pnlCenterMenu.TabIndex = 7;
            // 
            // FrmBaseDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionMsgVisible = true;
            this.CaptionRodape = "2022 © Gear Project - All Rights Reserved.";
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBaseDesktop";
            this.Text = "FrmBaseDesktop";
            this.pnlCenterCabecalhoRodape.ResumeLayout(false);
            this.pnlRodape.ResumeLayout(false);
            this.pnlCenterMain.ResumeLayout(false);
            this.pnlCabecalho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Panel pnlCenterMenu;
        public Panel pnlMenu;
    }
}