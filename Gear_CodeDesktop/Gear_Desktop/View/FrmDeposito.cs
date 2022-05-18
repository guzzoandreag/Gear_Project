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
    public partial class FrmDeposito : FrmBase
    {
        string URL;

        public FrmDeposito(string URLParameter,string depositoCadastrarParameter)
        {
            InitializeComponent();
            this.URL = URLParameter;
            txt_nome_dep_faz.Text = depositoCadastrarParameter;
            txt_tamanho.Text = "";

        }

        private void FrmDeposito_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private async void PostDeposito()
        {
            DALConnectionREST restConnection = new DALConnectionREST(URL);
            BLLDeposito objBLLUDeposito = new BLLDeposito(restConnection);
            Deposito_00 deposito = await objBLLUDeposito.GetDeposito(txt_nome_dep_faz.Text.Trim());
            if (deposito == null)
            {
                deposito = new Deposito_00();
                deposito.Dep_name = txt_nome_dep_faz.Text.Trim();
                var result = await objBLLUDeposito.PostDeposito(deposito);
                if (result == "Ok")
                {
                    //ClearFields();
                    MessageInfo("Usuario cadastrado com sucesso !!", "Green");
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
    }
}
