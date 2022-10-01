using Gear_Desktop.Controller.BLL;
using Gear_Desktop.Controller.DAL;
using Gear_Desktop.Models;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gear_Desktop.View
{
    public partial class FrmMovDespesa : FrmBase
    {
        string URL;
        Despesa_00 _despesa;
        Deposito_00 _deposito;

        public FrmMovDespesa(string URLParameter)
        {
            InitializeComponent();
            this.URL = URLParameter;
            txtNomeDeposito.ReadOnly = true;
        }

        private void ClearFields()
        {
            txtCodigo.Clear();
            txtDes_datalancamento.Clear();
            txtDep_codigo.Clear();
            txtNomeDeposito.Clear();
            txtDes_valor.Clear();
            txtDes_observacao.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearMessageInfo();
            txtCodigo.Clear();
            txtDep_codigo.ReadOnly = false;
            txtDep_codigo.Clear();
            txtDes_datalancamento.ReadOnly = false;
            txtDes_datalancamento.Clear();
            txtDes_valor.ReadOnly = false;
            txtDes_valor.Clear();
            txtDes_observacao.ReadOnly = false;
            txtDes_observacao.Clear();

            btnPSQDeposito.Enabled = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;

            txtDes_datalancamento.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length != 0)
            {
                ClearMessageInfo();
                txtDep_codigo.ReadOnly = false;
                txtDes_datalancamento.ReadOnly = false;
                txtDes_valor.ReadOnly = false;
                txtDes_observacao.ReadOnly = false;

                btnPSQDeposito.Enabled = true;
                btnNovo.Enabled = false;
                btnAlterar.Enabled = false;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = false;
                btnPesquisar.Enabled = false;
            }
            else
            {
                MessageInfo("Não é permitido alterar movimento em branco! \n Favor selecionar um através da pesquisa!!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClearMessageInfo();
            if (txtCodigo.Text.Length > 0)
            {
                PutDespesa();
            }
            else
            {
                PostDespesa();
            }
            txtDep_codigo.ReadOnly = true;
            txtDes_datalancamento.ReadOnly = true;
            txtDes_valor.ReadOnly = true;
            txtDes_observacao.ReadOnly = true;

            btnPSQDeposito.Enabled = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearMessageInfo();
            if (txtCodigo.Text.Length == 0)
            {
                txtCodigo.Clear();
                txtDep_codigo.ReadOnly = true;
                txtDep_codigo.Clear();
                txtDes_datalancamento.ReadOnly = true;
                txtDes_datalancamento.Clear();
                txtDes_valor.ReadOnly = true;
                txtDes_valor.Clear();
                txtDes_observacao.ReadOnly = true;
                txtDes_observacao.Clear();

                btnPSQDeposito.Enabled = false;
                btnNovo.Enabled = true;
                btnAlterar.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = true;
                btnPesquisar.Enabled = true;
            }
            else
            {
                txtDep_codigo.ReadOnly = true;
                txtDes_datalancamento.ReadOnly = true;
                txtDes_valor.ReadOnly = true;
                txtDes_observacao.ReadOnly = true;

                btnPSQDeposito.Enabled = false;
                btnNovo.Enabled = true;
                btnAlterar.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnPesquisar.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length != 0)
            {
                ClearMessageInfo();
                //txtCodigo.Clear();
                txtDes_datalancamento.ReadOnly = true;
                txtDep_codigo.ReadOnly = true;
                txtDes_valor.ReadOnly = true;
                txtDes_observacao.ReadOnly = true;

                btnNovo.Enabled = true;
                btnAlterar.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = true;
                btnPesquisar.Enabled = true;

                DeleteDespesa(Convert.ToInt32(txtCodigo.Text.Trim()));

                ClearFields();
            }
            else
            {
                MessageInfo("Não é permitido excluir um cadastro em branco! \n Favor selecionar um através da pesquisa!!");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            using (FrmPSQ<Despesa_00> frmPSQ = new FrmPSQ<Despesa_00>(_despesa = new(), URL))
            {
                DialogResult dialogResult = frmPSQ.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    txtCodigo.Text = Convert.ToString(frmPSQ.ReturnDespesa.Des_codigo);
                    txtDep_codigo.Text = Convert.ToString(frmPSQ.ReturnDespesa.Dep_codigo);
                    txtDes_datalancamento.Text = Convert.ToString(frmPSQ.ReturnDespesa.Des_datalancamento);
                    txtDes_valor.Text = Convert.ToString(frmPSQ.ReturnDespesa.Des_valor);
                    txtDes_observacao.Text = Convert.ToString(frmPSQ.ReturnDespesa.Des_observacao);
                }
            }
            if (txtDep_codigo.Text.Length > 0)
            {
                _deposito = new();
                GetDeposito(_deposito);
            }
        }

        private async void GetDeposito(Deposito_00 deposito)
        {
            if (deposito is null)
            {
                throw new ArgumentNullException(nameof(deposito));
            }

            DALConnectionREST restConnection = new(URL);
            BLLDeposito objBLLDeposito = new(restConnection);
            deposito = await objBLLDeposito.GetDeposito(Convert.ToInt32(txtDep_codigo.Text));
            txtNomeDeposito.Text = deposito.Dep_nome;
        }

        private async void PutDespesa()
        {
            DALConnectionREST restConnection = new DALConnectionREST(URL);
            BLLDespesa objBLLDespesa = new(restConnection);
            _despesa = new()
            {
                Des_codigo = Convert.ToInt32(txtCodigo.Text.Trim()),
                Des_datalancamento = Convert.ToDateTime(txtDes_datalancamento.Text.Trim()),
                Dep_codigo = Convert.ToInt32(txtDep_codigo.Text.Trim()),
                Des_valor = Convert.ToDecimal(txtDes_valor.Text.Trim()),
                Des_observacao = txtDes_observacao.Text.Trim()
            };
            var result = await objBLLDespesa.PutDespesa(_despesa);
            if (result == "Ok")
            {
                MessageInfo("Despesa alterada com sucesso !! ", "Green");
            }
            else
            {
                MessageInfo("Erro ao alterar a Despesa !! - " + result);
            }
        }

        private async void PostDespesa()
        {
            DALConnectionREST restConnection = new DALConnectionREST(URL);
            BLLDespesa objBLLDespesa = new(restConnection);
            _despesa = new()
            {
                //Des_codigo = Convert.ToInt32(txtCodigo.Text.Trim()),
                Des_datalancamento = Convert.ToDateTime(txtDes_datalancamento.Text.Trim()),
                Des_valor = Convert.ToDecimal(txtDes_valor.Text.Trim()),
                Des_observacao = txtDes_observacao.Text.Trim()
            };
            var result = await objBLLDespesa.PostDespesa(_despesa);
            if (result.Des_codigo.ToString().Length > 0)
            {
                MessageInfo("Despesa salva com sucesso !! ", "Green");
                txtCodigo.Text = result.Des_codigo.ToString();
            }
            else
            {
                MessageInfo("Erro ao salvar Despesa !!");
            }
        }

        private async void DeleteDespesa(int desCodigo)
        {
            DALConnectionREST restConnection = new(URL);
            BLLDespesa objBLLDespesa = new(restConnection);
            var result = await objBLLDespesa.DeleteDespesa(desCodigo);
            if (result == "Ok")
            {
                MessageInfo("Despesa excluido com sucesso !! ", "Green");
            }
            else
            {
                MessageInfo("Erro ao excluido a Despesa !! - " + result);
            }
        }

        private void btnPSQDeposito_Click(object sender, EventArgs e)
        {
            using (FrmPSQ<Deposito_00> frmPSQ = new FrmPSQ<Deposito_00>(_deposito = new(), URL))
            {
                DialogResult dialogResult = frmPSQ.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    txtDep_codigo.Text = Convert.ToString(frmPSQ.ReturnDeposito.Dep_codigo);
                    txtNomeDeposito.Text = frmPSQ.ReturnDeposito.Dep_nome;
                }
            }
        }

        private void txtDes_valor_Leave(object sender, EventArgs e)
        {
            //txtDes_valor.Text = Convert.ToDecimal(txtDes_valor.Text).ToString("C", CultureInfo.CurrentCulture);
        }

        private void txtDep_codigo_Leave(object sender, EventArgs e)
        {            
            GetDeposito(_deposito = new());
        }
    }
}
