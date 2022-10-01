using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gear_Desktop.View
{
    public partial class FrmBase : Form
    {
        int X = 0;
        int Y = 0;

        // Propriedade para descrever titulo e rodapé do formulario.
        // E personalização de visibilidade do rodape e botão minimizar.
        private string captionCabecalho;
        private string captionRodape;
        private bool captionRodapeVisible = true;
        private bool buttonMinimizarVisible = true;

        // Propriedade para manipular evento de movimentação do formulario.
        private bool frmNotMove = false;

        // Propriedades para manipulação do campo de mensagem.
        private bool captionMsgVisible;
        private string captionMsg;
        private Color captionMsgColor;

        // Metodos Get's / Set's das propriedades.
        public string CaptionCabecalho
        {
            get => captionCabecalho = this.BaseFormCabecalho.Text;
            set
            {
                this.BaseFormCabecalho.Text = value;
            }
        }

        public string CaptionRodape
        {
            get => captionRodape = this.BaseFormRodape.Text;
            set
            {
                this.BaseFormRodape.Text = value;
            }
        }

        public bool CaptionRodapeVisible
        {
            get => captionRodapeVisible = this.pnlRodape.Visible;
            set
            {
                if (value)
                {
                    this.pnlRodape.Visible = value;
                    this.pnlRodape.Size = new Size(984, 30);
                }
                else
                {
                    this.pnlRodape.Visible = value;
                    this.pnlRodape.Size = new Size(984, 0);
                }
            }
        }

        public bool ButtonMinimizeVisible
        {
            get => buttonMinimizarVisible = this.btnMinimizar.Visible;
            set => btnMinimizar.Visible = value;
        }

        public string CaptionMsg 
        {
            get => captionMsg = this.lblMsg.Text;
            set
            {
                this.lblMsg.Text = value;
            }
        }

        public bool CaptionMsgVisible 
        { 
            get => captionMsgVisible = this.lblMsg.Visible;
            set 
            {
                if (value)
                {
                    this.lblMsg.Visible = value;
                    this.lblMsg.Size = new Size(984, 40);
                }
                else
                {
                    this.lblMsg.Visible = value;
                    this.lblMsg.Size = new Size(984, 0);
                }                
            } 
        }
        public Color CaptionMsgColor 
        { 
            get => captionMsgColor = this.lblMsg.ForeColor; 
            set => this.lblMsg.ForeColor = value; 
        }

        public bool FrmNotMove
        {
            get => frmNotMove;
            set => frmNotMove = value;
        }

        public void MessageInfo(string message, string messageColor = "Yellow")
        {
            this.CaptionMsgVisible = true;
            this.CaptionMsg = message;
            if (messageColor == "Red")
            {
                this.CaptionMsgColor = Color.Red;
            }
            else if (messageColor == "Green")
            {
                this.CaptionMsgColor = Color.Green;
            }
            else
            {
                this.CaptionMsgColor = Color.Yellow;
            }
        }

        public void CreateFormInPanel(Panel pPanel, object pForm)
        {
            if (pPanel.Controls.Count > 0)
            {
                pPanel.Controls.RemoveAt(0);
            }
            FrmBase frm = pForm as FrmBase;
            frm.TopLevel = false;
            frm.FrmNotMove = true;
            frm.CaptionRodapeVisible = false;
            frm.ButtonMinimizeVisible = false;
            pPanel.Controls.Add(frm);
            pPanel.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        public void ClearMessageInfo()
        {
            this.CaptionMsgVisible = false;
            this.CaptionMsg = "";
        }

        public FrmBase()
        {
            // Construtor
            InitializeComponent();
            this.Load += new EventHandler(FrmBase_Load);
        }

        private void FrmBase_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void FrmBase_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        public void FrmBase_Load(object sender, EventArgs e)
        {
            if (!FrmNotMove)
            {
                this.MouseDown += new MouseEventHandler(FrmBase_MouseDown);
                this.MouseMove += new MouseEventHandler(FrmBase_MouseMove);
            }
            this.FormBorderStyle = FormBorderStyle.None;
            string year = DateTime.Now.ToString("yyyy");
            BaseFormRodape.Text = year + " © Gear Project - All Rights Reserved.";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_MouseDown(object sender, MouseEventArgs e)
        {
            FrmBase_MouseDown(sender, e);
        }

        private void BtnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            FrmBase_MouseMove(sender, e);
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (!FrmNotMove)
            {
                FrmBase_MouseDown(sender, e);
            }
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (!FrmNotMove)
            {
                FrmBase_MouseMove(sender, e);
            }
        }

        private void BaseFormCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (!FrmNotMove)
            {
                FrmBase_MouseDown(sender, e);
            }
        }

        private void BaseFormCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (!FrmNotMove)
            {
                FrmBase_MouseMove(sender, e);
            }
        }

        private void FrmBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        //~FrmBase()
        //{
        // Destroyer
        //}
    }
}