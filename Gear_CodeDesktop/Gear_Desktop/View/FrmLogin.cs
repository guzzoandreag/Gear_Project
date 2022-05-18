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

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            txtEmail.Text = "Sampaio147@hotmail.com";
            txtSenha.Text = "1234567";
            ClearMessageInfo();
            GetUsersByEmail();
        }

        private async void GetUsersByEmail()
        {
            DALConnectionREST restConnection = new DALConnectionREST(txtURL.Text);
            BLLUsers objBLLUsers = new BLLUsers(restConnection);
            Users users = await objBLLUsers.GetUsersByEmail(txtEmail.Text.Trim());
            if (users == null)
            {
                MessageInfo("Usuario não encontrado. \n" +
                            "Favor realizar o cadastramento.");
            }
            else
            {
                if (users.Usu_password.Trim() == txtSenha.Text.Trim())
                {
                    this.txtSenha.Clear();
                    FrmDesktop frmDesktop = new FrmDesktop(txtURL.Text);
                    this.Visible = false;
                    frmDesktop.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageInfo("Senha incorreta !!");
                }
            }
        }

        ~FrmLogin()
        {
            // Destroyer
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            ClearMessageInfo();
            FrmCadUsers frmCadastroUsers = new FrmCadUsers(txtURL.Text, txtEmail.Text);
            frmCadastroUsers.ShowDialog();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            ClearMessageInfo();
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            ClearMessageInfo();
        }
    }
}
