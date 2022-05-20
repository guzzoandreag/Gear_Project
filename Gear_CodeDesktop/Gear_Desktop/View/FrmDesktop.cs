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
    public partial class FrmDesktop : FrmBaseDesktop
    {
        string URL;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadDeposito_Click(object sender, EventArgs e)
        {
            FrmCadDeposito frmDeposito = new FrmCadDeposito(URL);
                frmDeposito.ShowDialog();
        }
    }
}
