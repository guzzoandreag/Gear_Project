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
    public partial class FrmMovTransfEstoque : FrmBase
    {
        string URL;
        public FrmMovTransfEstoque(string URLParameter)
        {
            InitializeComponent();
            this.URL = URLParameter;
        }
    }
}
