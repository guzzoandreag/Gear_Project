using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gear_Desktop.Controller.DAL;
using Gear_Desktop.Controller.BLL;
using Gear_Desktop.Models;

namespace Gear_Desktop.View
{
    public partial class FrmCadUsers : FrmBase
    {
        string URL;

        public FrmCadUsers(string URLParameter, string emailCadastrarParameter)
        {
            InitializeComponent();
            this.URL = URLParameter;
            txtName.Text = "";
            txtEmail.Text = emailCadastrarParameter;
            txtSenha.Text = "";

        }

        private void ClearFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ClearMessageInfo();
            PostUser();
        }

        private async void PostUser()
        {
            DALConnectionREST restConnection = new DALConnectionREST(URL);
            BLLUsers objBLLUsers = new BLLUsers(restConnection);
            Users users = await objBLLUsers.GetUsersByEmail(txtEmail.Text.Trim());
            if (users == null)
            {
                users = new Users();
                users.Use_nome = txtName.Text.Trim();
                users.Use_email = txtEmail.Text.Trim();
                users.Usu_senha = txtSenha.Text.Trim();
                var result = await objBLLUsers.PostUser(users);
                if (result == "Ok")
                {
                    this.ClearFields();
                    MessageInfo("Usuario cadastrado com sucesso !!","Green");
                }
                else
                {
                    MessageInfo("Erro ao cadastar usuario !!");
                }
            }
            else
            {
                MessageInfo("Usuario já existe !!");
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            ClearMessageInfo();
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
