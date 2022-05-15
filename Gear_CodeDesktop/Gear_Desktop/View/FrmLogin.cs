using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gear_Desktop.View;
using Gear_Desktop.Models;
using Newtonsoft.Json;
using Gear_Desktop.Controller.DAL;
using Gear_Desktop.Controller.BLL;

namespace Gear_Desktop.View
{
    public partial class FrmLogin : FrmBase
    {
        public FrmLogin()
        {
            // Construtor
            InitializeComponent();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            DALConnectionREST restConnection = new DALConnectionREST();
            BLLUsers objBLLUsers = new BLLUsers(restConnection);
            Users users = await objBLLUsers.GetUsersByEmail(txtEmail.Text.Trim());
            if (users == null)
            {
                MessageBox.Show("Usuario não encontrado. \n" +
                                "Favor realizar o cadastramento.");
                //throw new Exception("Usuario não encontrado. \n" +
                //                    "Favor realizar o cadastramento.");
            }
            else
            {
                if (users.Usu_password.Trim() == txtSenha.Text.Trim())
                {
                    FrmDesktop frmDesktop = new FrmDesktop();
                    this.Visible = false;
                    frmDesktop.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Senha incorreta !!");
                }
            }
        }

        ~FrmLogin()
        {
            // Destroyer
        }
    }
}
