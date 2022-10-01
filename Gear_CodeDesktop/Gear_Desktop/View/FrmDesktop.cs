using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Gear_Desktop.View
{
    public partial class FrmDesktop : FrmBaseDesktop
    {
        readonly string URL;
        public FrmDesktop(string URLParameter)
        {
            InitializeComponent();
            this.URL = URLParameter;
            this.btnCadDeposito.Text = "Deposito\nFazenda";
            this.btnCadProduto.Text = "Produto";
            this.btnMovTransferencia.Text = "Transferencia\nDeposito";
            this.btnMovDespesa.Text = "Despesa";
        }

        private void FrmDesktop_Load(object sender, EventArgs e)
        {
            //
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCadDeposito_Click(object sender, EventArgs e)
        {
            CreateFormInPanel(this.pnlCenterMenu, new FrmCadDeposito(URL));
        }

        private void BtnCadProduto_Click(object sender, EventArgs e)
        {
            CreateFormInPanel(this.pnlCenterMenu, new FrmCadProdutos(URL));
        }

        private void BtnMovTransferencia_Click(object sender, EventArgs e)
        {
            DlgMovEstoque dlgEstoque = new(this.pnlCenterMenu, URL);
            dlgEstoque.FrmNotMove = true;
            dlgEstoque.CaptionRodapeVisible = false;
            dlgEstoque.ButtonMinimizeVisible = false;
            dlgEstoque.ShowDialog();
        }

        private void BtnMovDespesa_Click(object sender, EventArgs e)
        {
            CreateFormInPanel(this.pnlCenterMenu, new FrmMovDespesa(URL));
        }
    }
}
