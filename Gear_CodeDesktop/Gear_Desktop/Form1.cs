using Newtonsoft.Json;
using Gear_Desktop.Models;

namespace Gear_Desktop
{
    public partial class Form1 : Form
    {

        // teste
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //InputBox();
            if (txtEmail.Text.Length > 0)
            {
                GetUsersByEmail(txtEmail.Text);
            }
        }

        //private void InputBox()
        //{
        //    /* usando a função VB.Net para exibir um prompt para o usuário informar a senha */
        //    string Prompt = "Informe o código do Produto.";
        //    string Titulo = "www.macoratti.net";
        //    string Resultado = Microsoft.VisualBasic.Interaction.InputBox(Prompt, Titulo, "9", 600, 350);
        //    /* verifica se o resultado é uma string vazia o que indica que foi cancelado. */
        //    if (Resultado != "")
        //    {
        //        codigoProduto = Convert.ToInt32(Resultado);
        //    }
        //    else
        //    {
        //        codigoProduto = -1;
        //    }
        //}

        private async void GetUsersByEmail(string use_email)
        {
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                var URI = txtURL_API.Text + use_email;

                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var UsersJsonString = await response.Content.ReadAsStringAsync();
                    Users users = new Users();
                    users = JsonConvert.DeserializeObject<Users>(UsersJsonString);
                    if (txtSenha.Text == users.Usu_password)
                    {
                        lblName.Visible = true;
                        lblName.Text = "Olá " + users.Use_name;
                        MessageBox.Show("SENHA OK !!!");
                    }
                    else
                    {
                        MessageBox.Show("SENHA INCORRETA !!!");
                    }


                    //dgvDados.DataSource = bsDados;
                }
                else
                {
                    MessageBox.Show("Falha ao logar no sistema : " + response.StatusCode);
                }
            }
        }
    }
}
