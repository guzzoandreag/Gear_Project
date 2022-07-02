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
    public partial class DlgMovEstoque : FrmBase
    {
        string URL;

        public DlgMovEstoque(string URLParameter)
        {
            InitializeComponent();
            this.URL = URLParameter;
        }

        private void btnAdicionarETQ_Click(object sender, EventArgs e)
        {
            FrmMovAddEstoque frmMovAddEstoque = new(URL);
            frmMovAddEstoque.ShowDialog();
        }

        private void btnTransferirETQ_Click(object sender, EventArgs e)
        {
            FrmMovTransfEstoque frmMovTransfEstoque = new(URL);
            frmMovTransfEstoque.ShowDialog();
        }
    }
}
