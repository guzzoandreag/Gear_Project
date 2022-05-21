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
    public partial class FrmCadDeposito : FrmBase
    {
        string URL;

        public FrmCadDeposito(string URLParameter)
        {
            InitializeComponent();
            this.URL = URLParameter;
            txtNome.Text = "";
            txtTamanhoFazenda.Text = "";

        }

        private void ClearFields()
        {
            txtNome.Clear();
            cbTipoCadastro.ResetText();
            cbTipoPlantio.ResetText();
            txtTamanhoFazenda.Clear();
        }

        private void FrmDeposito_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            PostDeposito();

        }

        private async void PostDeposito()
        {
            DALConnectionREST restConnection = new DALConnectionREST(URL);
            BLLDeposito objBLLDeposito = new BLLDeposito(restConnection);
            Deposito_00 deposito = new Deposito_00();
            deposito.Dep_nome = txtNome.Text.Trim();
            deposito.Dep_tipocadastro = cbTipoCadastro.SelectedIndex + 1;
            deposito.Dep_tipoplantio = cbTipoPlantio.SelectedIndex + 1;
            deposito.Dep_tamanhofazenda = txtTamanhoFazenda.Text;
            var result = await objBLLDeposito.PostDeposito(deposito);
            if (result == "Ok")
            {
                ClearFields();
                MessageInfo("Usuario cadastrado com sucesso !!", "Green");
            }
            else
            {
                MessageInfo("Erro ao cadastar usuario !!");
            }
        }

        private void cb_dep_faz_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
