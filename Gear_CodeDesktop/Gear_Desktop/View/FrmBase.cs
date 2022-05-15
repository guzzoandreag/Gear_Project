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

        private string captionRodape;
        private string captionCabecalho;

        public string CaptionRodape
        {
            get => captionRodape = this.BaseFormRodape.Text;
            set
            {
                this.BaseFormRodape.Text = value;
            }
        }

        public string CaptionCabecalho
        {
            get => captionCabecalho = this.BaseFormCabecalho.Text;
            set
            {
                this.BaseFormCabecalho.Text = value;
            }
        }

        public FrmBase()
        {
            // Construtor
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(FrmBase_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmBase_MouseMove);
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
            this.FormBorderStyle = FormBorderStyle.None;
            string year = DateTime.Now.ToString("yyyy");
            BaseFormRodape.Text = year + " © Gear Project - All Rights Reserved.";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_MouseDown(object sender, MouseEventArgs e)
        {
            FrmBase_MouseDown(sender, e);
        }

        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            FrmBase_MouseMove(sender, e);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            FrmBase_MouseDown(sender, e);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            FrmBase_MouseMove(sender, e);
        }

        private void BaseFormCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            FrmBase_MouseDown(sender, e);
        }

        private void BaseFormCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            FrmBase_MouseMove(sender, e);
        }

        ~FrmBase()
        {
            // Destroyer
        }
    }
}
