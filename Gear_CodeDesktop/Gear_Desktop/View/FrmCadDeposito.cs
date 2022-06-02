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
        private readonly string URL;
        Deposito_00 _deposito;

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
            BLLDeposito objBLLDeposito = new(restConnection);
            _deposito = new()
            {
                Dep_nome = txtNome.Text.Trim(),
                Dep_tipocadastro = cbTipoCadastro.SelectedIndex + 1,
                Dep_tipoplantio = cbTipoPlantio.SelectedIndex + 1,
                Dep_tamanhofazenda = txtTamanhoFazenda.Text
            };
            var result = await objBLLDeposito.PostDeposito(_deposito);
            if (result == "Ok")
            {
                ClearFields();
                MessageInfo("Deposito cadastrado com sucesso !!", "Green");
            }
            else
            {
                MessageInfo("Erro ao cadastar deposito !!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FrmPSQ<Deposito_00> frmPSQ = new FrmPSQ<Deposito_00>(_deposito = new(), URL))
            {
                DialogResult dialogResult = frmPSQ.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    txtNome.Text = frmPSQ.ReturnDeposito.Dep_nome;
                    cbTipoCadastro.SelectedIndex = frmPSQ.ReturnDeposito.Dep_tipocadastro;
                    cbTipoPlantio.SelectedIndex = (int)frmPSQ.ReturnDeposito.Dep_tipoplantio;
                    txtTamanhoFazenda.Text = frmPSQ.ReturnDeposito.Dep_tamanhofazenda;
                }

            }
        }
    }
}
