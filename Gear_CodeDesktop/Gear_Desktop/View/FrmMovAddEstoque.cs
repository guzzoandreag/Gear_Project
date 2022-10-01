using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gear_Desktop.Models;
using Gear_Desktop.Controller.BLL;
using Gear_Desktop.Controller.DAL;

namespace Gear_Desktop.View
{
    public partial class FrmMovAddEstoque : FrmBase
    {
        readonly string URL;
        Produto_00 _produto;
        Deposito_00 _deposito;
        Estoque_00 _estoque;

        public FrmMovAddEstoque(string URLParameter)
        {
            InitializeComponent();
            this.URL = URLParameter;
            txtNomeProduto.ReadOnly = true;
            txtNomeDeposito.ReadOnly = true;
        }

        private void ClearFields()
        {
            txtCodigo.Clear();
            txtEtq_datalancamento.Clear();
            txtPro_codigo.Clear();
            txtNomeProduto.Clear();
            txtDep_codigo.Clear();
            txtNomeDeposito.Clear();
            txtEtq_quantidade.Clear();
            txtEtq_valorcusto.Clear();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            ClearMessageInfo();
            txtCodigo.Clear();
            txtPro_codigo.ReadOnly = false;
            txtPro_codigo.Clear();
            txtDep_codigo.ReadOnly = false;
            txtDep_codigo.Clear();
            txtEtq_quantidade.ReadOnly = false;
            txtEtq_quantidade.Clear();
            txtEtq_valorcusto.ReadOnly = false;
            txtEtq_valorcusto.Clear();
            txtEtq_datalancamento.ReadOnly = false;
            txtEtq_datalancamento.Clear();

            btnPSQProduto.Enabled = true;
            btnPSQDeposito.Enabled = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;

            txtEtq_datalancamento.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length != 0)
            {
                ClearMessageInfo();
                txtPro_codigo.ReadOnly = false;
                txtDep_codigo.ReadOnly = false;
                txtEtq_quantidade.ReadOnly = false;
                txtEtq_valorcusto.ReadOnly = false;
                txtEtq_datalancamento.ReadOnly = false;

                btnPSQProduto.Enabled = true;
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            ClearMessageInfo();
            if (txtCodigo.Text.Length > 0)
            {
                PutEstoque();
            }
            else
            {
                PostEstoque();
            }
            txtPro_codigo.ReadOnly = true;
            txtDep_codigo.ReadOnly = true;
            txtEtq_quantidade.ReadOnly = true;
            txtEtq_valorcusto.ReadOnly = true;
            //txtEtq_datalancamento.ReadOnly = true;

            btnPSQProduto.Enabled = false;
            btnPSQDeposito.Enabled = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ClearMessageInfo();
            if (txtCodigo.Text.Length == 0)
            {
                txtCodigo.Clear();
                txtPro_codigo.ReadOnly = true;
                txtPro_codigo.Clear();
                txtDep_codigo.ReadOnly = true;
                txtDep_codigo.Clear();
                txtEtq_quantidade.ReadOnly = true;
                txtEtq_quantidade.Clear();
                txtEtq_valorcusto.ReadOnly = true;
                txtEtq_valorcusto.Clear();
                //txtEtq_datalancamento.ReadOnly = true;
                //txtEtq_datalancamento.Clear();

                btnPSQProduto.Enabled = false;
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
                txtPro_codigo.ReadOnly = true;
                txtDep_codigo.ReadOnly = true;
                txtEtq_quantidade.ReadOnly = true;
                txtEtq_valorcusto.ReadOnly = true;
                //txtEtq_datalancamento.ReadOnly = true;

                btnPSQProduto.Enabled = false;
                btnPSQDeposito.Enabled = false;
                btnNovo.Enabled = true;
                btnAlterar.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = true;
                btnPesquisar.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length != 0)
            {
                ClearMessageInfo();
                txtPro_codigo.ReadOnly = true;
                txtDep_codigo.ReadOnly = true;
                txtEtq_quantidade.ReadOnly = true;
                txtEtq_valorcusto.ReadOnly = true;

                btnNovo.Enabled = true;
                btnAlterar.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = true;
                btnPesquisar.Enabled = true;

                DeleteEstoque(Convert.ToInt32(txtCodigo.Text.Trim()));

                ClearFields();
            }
            else
            {
                MessageInfo("Não é permitido excluir um cadastro em branco! \n Favor selecionar um através da pesquisa!!");
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            using (FrmPSQ<Estoque_00> frmPSQ = new(_estoque = new(), URL))
            {
                DialogResult dialogResult = frmPSQ.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    txtCodigo.Text = Convert.ToString(frmPSQ.ReturnEstoque.Etq_codigo);
                    txtPro_codigo.Text = Convert.ToString(frmPSQ.ReturnEstoque.Pro_codigo);
                    txtDep_codigo.Text = Convert.ToString(frmPSQ.ReturnEstoque.Dep_codigo);
                    txtEtq_quantidade.Text = Convert.ToString(frmPSQ.ReturnEstoque.Etq_quantidade);
                    txtEtq_valorcusto.Text = Convert.ToString(frmPSQ.ReturnEstoque.Etq_valorcusto);
                    txtEtq_datalancamento.Text = Convert.ToString(frmPSQ.ReturnEstoque.Etq_datalancamento);
                }
            }
            if (txtPro_codigo.Text.Length > 0)
            {
                _produto = new();
                GetProduto(_produto);
            }
            if (txtDep_codigo.Text.Length > 0)
            {
                _deposito = new();
                GetDeposito(_deposito);
            }
        }

        private async void GetProduto(Produto_00 produto)
        {
            if (produto is null)
            {
                throw new ArgumentNullException(nameof(produto));
            }

            DALConnectionREST restConnection = new(URL);
            BLLProdutos objBLLProdutos = new(restConnection);
            produto = await objBLLProdutos.GetProduto(Convert.ToInt32(value: txtPro_codigo.Text));
            txtNomeProduto.Text = produto.Pro_nome;
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

        private async void PutEstoque()
        {
            DALConnectionREST restConnection = new(URL);
            BLLEstoque objBLLEstoque = new(restConnection);
            _estoque = new()
            {
                Pro_codigo = Convert.ToInt32(txtPro_codigo.Text.Trim()),
                Dep_codigo = Convert.ToInt32(txtDep_codigo.Text.Trim()),
                Etq_quantidade = Convert.ToDecimal(txtEtq_quantidade.Text.Trim()),
                Etq_valorcusto = Convert.ToDecimal(txtEtq_valorcusto.Text.Trim()),
                //Etq_datalancamento = Convert.ToDateTime(txtEtq_datalancamento.Text.Trim())
            };
            var result = await objBLLEstoque.PutEstoque(_estoque);
            if (result == "Ok")
            {
                MessageInfo("Movimento alterado com sucesso !! ", "Green");
            }
            else
            {
                MessageInfo("Erro ao alterar o movimento !! - " + result);
            }
        }

        private async void PostEstoque()
        {
            DALConnectionREST restConnection = new(URL);
            BLLEstoque objBLLEstoque = new(restConnection);
            _estoque = new()
            {
                Pro_codigo = Convert.ToInt32(txtPro_codigo.Text.Trim()),
                Dep_codigo = Convert.ToInt32(txtDep_codigo.Text.Trim()),
                Etq_quantidade = Convert.ToDecimal(txtEtq_quantidade.Text.Trim()),
                Etq_valorcusto = Convert.ToDecimal(txtEtq_valorcusto.Text.Trim()),
                Etq_datalancamento = Convert.ToDateTime(txtEtq_datalancamento.Text.Trim())
            };
            var result = await objBLLEstoque.PostEstoque(_estoque);
            if (result.Etq_codigo.ToString().Length > 0)
            {
                MessageInfo("Movimento cadastrado com sucesso !! ", "Green");
                txtCodigo.Text = result.Etq_codigo.ToString();
            }
            else
            {
                MessageInfo("Erro ao cadastar o movimento !!");
            }
        }

        private async void DeleteEstoque(int etqCodigo)
        {
            DALConnectionREST restConnection = new(URL);
            BLLEstoque objBLLEstoque = new(restConnection);
            var result = await objBLLEstoque.DeleteEstoque(etqCodigo);
            if (result == "Ok")
            {
                MessageInfo("Estoque excluido com sucesso !! ", "Green");
            }
            else
            {
                MessageInfo("Erro ao excluido o Estoque !! - " + result);
            }
        }

        private void btnPSQProduto_Click(object sender, EventArgs e)
        {
            using FrmPSQ<Produto_00> frmPSQ = new FrmPSQ<Produto_00>(_produto = new(), URL);
            DialogResult dialogResult = frmPSQ.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txtPro_codigo.Text = Convert.ToString(frmPSQ.ReturnProdutos.Pro_codigo);
                txtNomeProduto.Text = frmPSQ.ReturnProdutos.Pro_nome;
            }
        }

        private void btnPSQDeposito_Click(object sender, EventArgs e)
        {
            using FrmPSQ<Deposito_00> frmPSQ = new FrmPSQ<Deposito_00>(_deposito = new(), URL);
            DialogResult dialogResult = frmPSQ.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txtDep_codigo.Text = Convert.ToString(frmPSQ.ReturnDeposito.Dep_codigo);
                txtNomeDeposito.Text = frmPSQ.ReturnDeposito.Dep_nome;
            }
        }

        private void txtDep_codigo_Leave(object sender, EventArgs e)
        {
            if (txtDep_codigo.Text.Length > 0)
            {
                GetDeposito(_deposito = new());
            }
        }

        private void txtPro_codigo_Leave(object sender, EventArgs e)
        {
            if (txtPro_codigo.Text.Length > 0)
            {                
                GetProduto(_produto = new());
            }
        }
    }
}
