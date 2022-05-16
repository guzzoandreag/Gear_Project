using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Gear_Desktop.Models;
using Gear_Desktop.Controller.DAL;
using Gear_Desktop.Controller.BLL;

namespace Gear_Desktop.View
{
    partial class FrmCadastroUsers : FrmBase
    {      
        public FrmCadastroUsers()
        {
            InitializeComponent();
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            DALConnectionREST restConnection = new DALConnectionREST();
            BLLUsers objBLLUsers = new BLLUsers(restConnection);
            Users users = await objBLLUsers.GetUsersByEmail(txt_email.Text.Trim());
            if (users == null)
            {
                users = new Users();
                users.Use_name = txt_nome.Text.Trim();
                users.Use_email = txt_email.Text.Trim();
                users.Usu_password = txt_senha.Text.Trim();
                var result = objBLLUsers.PostUser(users);
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
