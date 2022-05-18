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
    }
}
