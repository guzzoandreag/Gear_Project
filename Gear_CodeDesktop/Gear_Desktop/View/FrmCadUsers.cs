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
        public FrmCadUsers()
        {
            InitializeComponent();
            txt_nome.Text = "Andre Guzzo";
            txt_email.Text = "guzzoandre@gmail.com";
            txt_senha.Text = "1234567";

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            PostUser();
        }

        private async void PostUser()
        {
            DALConnectionREST restConnection = new DALConnectionREST("https://localhost:44388/api/");
            //https://localhost:44388/api/Users
            BLLUsers objBLLUsers = new BLLUsers(restConnection);
            Users users = null;
            //Users users = await objBLLUsers.GetUsersByEmail(txt_email.Text.Trim());
            if (users == null)
            {
                users = new Users();
                users.Use_name = txt_nome.Text.Trim();
                users.Use_email = txt_email.Text.Trim();
                users.Usu_password = txt_senha.Text.Trim();
                //objBLLUsers.PostUser(users);
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
