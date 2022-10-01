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
            #if DEBUG
                txtURL.Visible = true;
            #endif
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            #if DEBUG
                txtEmail.Text = "guzzoandre.ag@outlook.com";
                txtSenha.Text = "1234567";
            #endif
            ClearMessageInfo();
            GetUsersByEmail();
        }

        private async void GetUsersByEmail()
        {
            Users users = new();
            try
            {
                DALConnectionREST restConnection = new(txtURL.Text);
                BLLUsers objBLLUsers = new(restConnection);
                users = await objBLLUsers.GetUsersByEmail(txtEmail.Text.Trim());
                if (users == null)
                {
                    MessageInfo("Usuario não encontrado. \n" +
                                "Favor realizar o cadastramento.");
                }
                else
                {
                    if (users.Usu_senha.Trim() == txtSenha.Text.Trim())
                    {
                        this.txtSenha.Clear();
                        FrmDesktop frmDesktop = new(txtURL.Text);
                        frmDesktop.CaptionMsgVisible = false;
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
            catch (Exception ex)
            {
                MessageInfo(ex.Message);
            }
        }

        //~FrmLogin()
        //{
            // Destroyer
        //}

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            ClearMessageInfo();
            FrmCadUsers frmCadastroUsers = new(txtURL.Text, txtEmail.Text);
            frmCadastroUsers.ShowDialog();
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            ClearMessageInfo();
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            ClearMessageInfo();
        }
    }
}
