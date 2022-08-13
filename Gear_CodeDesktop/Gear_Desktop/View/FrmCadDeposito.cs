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

            txtCodigo.ReadOnly = true;
            txtNome.ReadOnly = true;
            cbTipoCadastro.Enabled = false;
            cbTipoPlantio.Enabled = false;
            txtTamanhoFazenda.ReadOnly = true;

            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
        }

        private void ClearFields()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            cbTipoCadastro.ResetText();
            cbTipoPlantio.ResetText();
            txtTamanhoFazenda.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearMessageInfo();
            txtCodigo.Clear();
            txtNome.ReadOnly = false;
            txtNome.Clear();
            cbTipoCadastro.Enabled = true;
            cbTipoCadastro.ResetText();
            cbTipoPlantio.Enabled = true;
            cbTipoPlantio.ResetText();
            txtTamanhoFazenda.ReadOnly = false;
            txtTamanhoFazenda.Clear();

            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length != 0)
            {
                ClearMessageInfo();
                txtNome.ReadOnly = false;
                cbTipoCadastro.Enabled = true;
                cbTipoPlantio.Enabled = true;
                txtTamanhoFazenda.ReadOnly = false;

                btnNovo.Enabled = false;
                btnAlterar.Enabled = false;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                btnPesquisar.Enabled = false;
            }
            else
            {
                MessageInfo("Não é permitido alterar cadastro em branco! \n Favor selecionar um através da pesquisa!!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClearMessageInfo();
            if (txtCodigo.Text.Length > 0)
            {
                PutDeposito();
            }
            else
            {
                PostDeposito();
            }
            txtNome.ReadOnly = true;
            cbTipoCadastro.Enabled = false;
            cbTipoPlantio.Enabled = false;
            txtTamanhoFazenda.ReadOnly = true;

            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearMessageInfo();
            if (txtCodigo.Text.Length == 0)
            {
                txtCodigo.Clear();
                txtNome.ReadOnly = true;
                txtNome.Clear();
                cbTipoCadastro.Enabled = false;
                cbTipoCadastro.ResetText();
                cbTipoPlantio.Enabled = false;
                cbTipoPlantio.ResetText();
                txtTamanhoFazenda.ReadOnly = true;
                txtTamanhoFazenda.Clear();

                btnNovo.Enabled = true;
                btnAlterar.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnPesquisar.Enabled = true;
            }
            else
            {
                txtNome.ReadOnly = true;
                cbTipoCadastro.Enabled = false;
                cbTipoPlantio.Enabled = false;
                txtTamanhoFazenda.ReadOnly = true;

                btnNovo.Enabled = true;
                btnAlterar.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnPesquisar.Enabled = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ClearMessageInfo();
            using (FrmPSQ<Deposito_00> frmPSQ = new FrmPSQ<Deposito_00>(_deposito = new(), URL))
            {
                DialogResult dialogResult = frmPSQ.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    txtCodigo.Text = Convert.ToString(frmPSQ.ReturnDeposito.Dep_codigo);
                    txtNome.Text = frmPSQ.ReturnDeposito.Dep_nome;
                    cbTipoCadastro.SelectedIndex = Convert.ToInt32(frmPSQ.ReturnDeposito.Dep_tipocadastro);
                    cbTipoPlantio.SelectedIndex = Convert.ToInt32(frmPSQ.ReturnDeposito.Dep_tipoplantio);
                    txtTamanhoFazenda.Text = frmPSQ.ReturnDeposito.Dep_tamanhofazenda;
                }
            }
        }

        private async void PutDeposito()
        {
            DALConnectionREST restConnection = new DALConnectionREST(URL);
            BLLDeposito objBLLDeposito = new(restConnection);
            _deposito = new()
            {
                Dep_codigo = Convert.ToInt32(txtCodigo.Text.Trim()),
                Dep_nome = txtNome.Text.Trim(),
                Dep_tipocadastro = cbTipoCadastro.SelectedIndex + 1,
                Dep_tipoplantio = cbTipoPlantio.SelectedIndex + 1,
                Dep_tamanhofazenda = txtTamanhoFazenda.Text.Trim()
            };
            var result = await objBLLDeposito.PutDeposito(_deposito);
            if (result == "Ok")
            {
                MessageInfo("Deposito alterado com sucesso !! ", "Green");
            }
            else
            {
                MessageInfo("Erro ao alterar o Deposito !! - " + result);
            }
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
            if (result.Dep_codigo.ToString().Length > 0)
            {
                MessageInfo("Deposito cadastrado com sucesso !! ", "Green");
                txtCodigo.Text = result.Dep_codigo.ToString();
            }
            else
            {
                MessageInfo("Erro ao cadastar Deposito !!");
            }
        }
    }
}
