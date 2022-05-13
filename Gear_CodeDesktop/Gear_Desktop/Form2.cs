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

namespace Gear_Desktop
{
    partial class Form2 : Frm_Padrao
    {
        String From2URL;

        public Form2(string URL, string Email)
        {
            InitializeComponent();
            txt_email.Text = Email;
            From2URL = URL;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            PostUserByEmail();
        }

        private async void PostUserByEmail()
        {
            {
                var URI = From2URL + txt_email;
                Users users = new Users();
                users.Use_email = txt_email.Text;
                users.Usu_password = txt_senha.Text;
                users.Use_name = txt_nome.Text;

                using (var client = new HttpClient())
                {
                    var SerializedCadastro = JsonConvert.SerializeObject(users);
                    var content = new StringContent(SerializedCadastro, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(URI, content);

                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cadastro Não Realizado");
                    }

                    else 
                    {
                        MessageBox.Show("Cadastro Realizado com Sucesso");
                    }

                }

            }
        }
    }
}
