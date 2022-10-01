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
        Panel pnlCenterMenu;

        public DlgMovEstoque(Panel pPanelCenterMenu, string URLParameter)
        {
            InitializeComponent();
            this.URL = URLParameter;
            this.pnlCenterMenu = pPanelCenterMenu;
            this.CaptionCabecalho = "Tipo Movto";
            //this.Size = new System.Drawing.Size(230, 200);
            this.lblMsg.Size = new System.Drawing.Size(230, 0);
        }

        private void btnAdicionarETQ_Click(object sender, EventArgs e)
        {
            CreateFormInPanel(pnlCenterMenu, new FrmMovAddEstoque(URL));
            this.Close();
        }

        private void btnTransferirETQ_Click(object sender, EventArgs e)
        {
            CreateFormInPanel(pnlCenterMenu, new FrmMovAddEstoque(URL));
            this.Close();
        }
    }
}
