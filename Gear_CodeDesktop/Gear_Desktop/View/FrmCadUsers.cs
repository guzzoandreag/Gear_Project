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

        public FrmCadUsers(string URLParameter)
        {
            InitializeComponent();
            this.URL = URLParameter;
            txtName.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
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
                users.Use_name = txtName.Text.Trim();
                users.Use_email = txtEmail.Text.Trim();
                users.Usu_password = txtSenha.Text.Trim();
                var result = await objBLLUsers.PostUser(users);
                if (result == "Ok")
                {
                    MessageBox.Show("Usuario cadastrado com sucesso !!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastar usuario !!");
                }
            }
            else
            {
                MessageBox.Show("Usuario já existe !!");
            }
        }
    }
}
