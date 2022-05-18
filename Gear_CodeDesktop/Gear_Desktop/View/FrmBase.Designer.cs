namespace Gear_Desktop.View
{
    partial class FrmBase
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
            this.pnlCenterMain = new System.Windows.Forms.Panel();
            this.pnlCenterCabecalhoRodape = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.BaseFormRodape = new System.Windows.Forms.Label();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.BaseFormCabecalho = new System.Windows.Forms.Label();
            this.pnlSpaceRightCaption = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pTop = new System.Windows.Forms.Panel();
            this.pButtom = new System.Windows.Forms.Panel();
            this.pLeft = new System.Windows.Forms.Panel();
            this.pRight = new System.Windows.Forms.Panel();
            this.pnlCenterMain.SuspendLayout();
            this.pnlCenterCabecalhoRodape.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenterMain
            // 
            this.pnlCenterMain.Controls.Add(this.pnlCenterCabecalhoRodape);
            this.pnlCenterMain.Controls.Add(this.pnlRodape);
            this.pnlCenterMain.Controls.Add(this.pnlCabecalho);
            this.pnlCenterMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterMain.Location = new System.Drawing.Point(0, 0);
            this.pnlCenterMain.Name = "pnlCenterMain";
            this.pnlCenterMain.Size = new System.Drawing.Size(984, 681);
            this.pnlCenterMain.TabIndex = 0;
            // 
            // pnlCenterCabecalhoRodape
            // 
            this.pnlCenterCabecalhoRodape.Controls.Add(this.lblMsg);
            this.pnlCenterCabecalhoRodape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterCabecalhoRodape.Location = new System.Drawing.Point(0, 30);
            this.pnlCenterCabecalhoRodape.Name = "pnlCenterCabecalhoRodape";
            this.pnlCenterCabecalhoRodape.Size = new System.Drawing.Size(984, 631);
            this.pnlCenterCabecalhoRodape.TabIndex = 5;
            // 
            // lblMsg
            // 
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMsg.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(0, 531);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(984, 100);
            this.lblMsg.TabIndex = 4;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMsg.Visible = false;
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.Color.DimGray;
            this.pnlRodape.Controls.Add(this.BaseFormRodape);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 661);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(984, 20);
            this.pnlRodape.TabIndex = 4;
            // 
            // BaseFormRodape
            // 
            this.BaseFormRodape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseFormRodape.Location = new System.Drawing.Point(0, 0);
            this.BaseFormRodape.Name = "BaseFormRodape";
            this.BaseFormRodape.Size = new System.Drawing.Size(984, 20);
            this.BaseFormRodape.TabIndex = 1;
            this.BaseFormRodape.Text = "Year © Gear Project - All Rights Reserved.";
            this.BaseFormRodape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.DimGray;
            this.pnlCabecalho.Controls.Add(this.BaseFormCabecalho);
            this.pnlCabecalho.Controls.Add(this.pnlSpaceRightCaption);
            this.pnlCabecalho.Controls.Add(this.btnMinimizar);
            this.pnlCabecalho.Controls.Add(this.btnClose);
            this.pnlCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(984, 30);
            this.pnlCabecalho.TabIndex = 1;
            // 
            // BaseFormCabecalho
            // 
            this.BaseFormCabecalho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseFormCabecalho.Location = new System.Drawing.Point(10, 0);
            this.BaseFormCabecalho.Name = "BaseFormCabecalho";
            this.BaseFormCabecalho.Size = new System.Drawing.Size(862, 30);
            this.BaseFormCabecalho.TabIndex = 4;
            this.BaseFormCabecalho.Text = "Gear Project - Caption.";
            this.BaseFormCabecalho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BaseFormCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseFormCabecalho_MouseDown);
            this.BaseFormCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseFormCabecalho_MouseMove);
            // 
            // pnlSpaceRightCaption
            // 
            this.pnlSpaceRightCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpaceRightCaption.Location = new System.Drawing.Point(0, 0);
            this.pnlSpaceRightCaption.Name = "pnlSpaceRightCaption";
            this.pnlSpaceRightCaption.Size = new System.Drawing.Size(10, 30);
            this.pnlSpaceRightCaption.TabIndex = 3;
            this.pnlSpaceRightCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.pnlSpaceRightCaption.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Location = new System.Drawing.Point(872, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(56, 30);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.Text = "—";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMinimizar_MouseDown);
            this.btnMinimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMinimizar_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(928, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.White;
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(984, 2);
            this.pTop.TabIndex = 1;
            // 
            // pButtom
            // 
            this.pButtom.BackColor = System.Drawing.Color.White;
            this.pButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtom.Location = new System.Drawing.Point(0, 679);
            this.pButtom.Name = "pButtom";
            this.pButtom.Size = new System.Drawing.Size(984, 2);
            this.pButtom.TabIndex = 2;
            // 
            // pLeft
            // 
            this.pLeft.BackColor = System.Drawing.Color.White;
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 2);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(2, 677);
            this.pLeft.TabIndex = 3;
            // 
            // pRight
            // 
            this.pRight.BackColor = System.Drawing.Color.White;
            this.pRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRight.Location = new System.Drawing.Point(982, 2);
            this.pRight.Name = "pRight";
            this.pRight.Size = new System.Drawing.Size(2, 677);
            this.pRight.TabIndex = 4;
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.pRight);
            this.Controls.Add(this.pLeft);
            this.Controls.Add(this.pButtom);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.pnlCenterMain);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(1000, 900);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FrmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBase";
            this.pnlCenterMain.ResumeLayout(false);
            this.pnlCenterCabecalhoRodape.ResumeLayout(false);
            this.pnlRodape.ResumeLayout(false);
            this.pnlCabecalho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Panel pnlCenterCabecalhoRodape;
        public Panel pnlRodape;
        public Label BaseFormRodape;
        public Panel pnlCenterMain;
        public Panel pnlCabecalho;
        public Button btnMinimizar;
        public Button btnClose;
        public Label BaseFormCabecalho;
        private Panel pTop;
        private Panel pButtom;
        private Panel pLeft;
        private Panel pRight;
        private Panel pnlSpaceRightCaption;
        public Label lblMsg;
    }
}