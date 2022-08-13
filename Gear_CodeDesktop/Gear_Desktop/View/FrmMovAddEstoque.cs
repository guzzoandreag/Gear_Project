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
        string URL;
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

        private void btnNovo_Click(object sender, EventArgs e)
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
            txtEtq_validade.ReadOnly = false;
            txtEtq_validade.Clear();

            btnPSQProduto.Enabled = true;
            btnPSQDeposito.Enabled = true;
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
                txtPro_codigo.ReadOnly = false;
                txtDep_codigo.ReadOnly = false;
                txtEtq_quantidade.ReadOnly = false;
                txtEtq_valorcusto.ReadOnly = false;
                txtEtq_validade.ReadOnly = false;

                btnPSQProduto.Enabled = true;
                btnPSQDeposito.Enabled = true;
                btnNovo.Enabled = false;
                btnAlterar.Enabled = false;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
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
            txtEtq_validade.ReadOnly = true;

            btnPSQProduto.Enabled = false;
            btnPSQDeposito.Enabled = false;
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
                txtPro_codigo.ReadOnly = true;
                txtPro_codigo.Clear();
                txtDep_codigo.ReadOnly = true;
                txtDep_codigo.Clear();
                txtEtq_quantidade.ReadOnly = true;
                txtEtq_quantidade.Clear();
                txtEtq_valorcusto.ReadOnly = true;
                txtEtq_valorcusto.Clear();
                txtEtq_validade.ReadOnly = true;
                txtEtq_validade.Clear();

                btnPSQProduto.Enabled = false;
                btnPSQDeposito.Enabled = false;
                btnNovo.Enabled = true;
                btnAlterar.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnPesquisar.Enabled = true;
            }
            else
            {
                txtPro_codigo.ReadOnly = true;
                txtDep_codigo.ReadOnly = true;
                txtEtq_quantidade.ReadOnly = true;
                txtEtq_valorcusto.ReadOnly = true;
                txtEtq_validade.ReadOnly = true;

                btnPSQProduto.Enabled = false;
                btnPSQDeposito.Enabled = false;
                btnNovo.Enabled = true;
                btnAlterar.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnPesquisar.Enabled = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            using (FrmPSQ<Estoque_00> frmPSQ = new FrmPSQ<Estoque_00>(_estoque = new(), URL))
            {
                DialogResult dialogResult = frmPSQ.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    txtCodigo.Text = Convert.ToString(frmPSQ.ReturnEstoque.Etq_codigo);
                    txtPro_codigo.Text = Convert.ToString(frmPSQ.ReturnEstoque.Pro_codigo);
                    txtDep_codigo.Text = Convert.ToString(frmPSQ.ReturnEstoque.Dep_codigo);
                    txtEtq_quantidade.Text = Convert.ToString(frmPSQ.ReturnEstoque.Etq_quantidade);
                    txtEtq_valorcusto.Text = Convert.ToString(frmPSQ.ReturnEstoque.Etq_valorcusto);
                    txtEtq_validade.Text = Convert.ToString(frmPSQ.ReturnEstoque.Etq_validade);
                }
            }
            _produto = new();
            GetProduto(_produto);
            _deposito = new();
            GetDeposito(_deposito);
        }

        private async void GetProduto(Produto_00 produto)
        {
            DALConnectionREST restConnection = new DALConnectionREST(URL);
            BLLProdutos objBLLProdutos = new(restConnection);
            produto = await objBLLProdutos.GetProduto(Convert.ToInt32(txtPro_codigo.Text));
            txtNomeProduto.Text = produto.Pro_nome;
        }

        private async void GetDeposito(Deposito_00 deposito)
        {
            DALConnectionREST restConnection = new DALConnectionREST(URL);
            BLLDeposito objBLLDeposito = new(restConnection);
            deposito = await objBLLDeposito.GetDeposito(Convert.ToInt32(txtDep_codigo.Text));
            txtNomeDeposito.Text = deposito.Dep_nome;
        }

        private async void PutEstoque()
        {
            DALConnectionREST restConnection = new DALConnectionREST(URL);
            BLLEstoque objBLLEstoque = new(restConnection);
            _estoque = new()
            {
                Pro_codigo = Convert.ToInt32(txtPro_codigo.Text.Trim()),
                Dep_codigo = Convert.ToInt32(txtDep_codigo.Text.Trim()),
                Etq_quantidade = Convert.ToDecimal(txtEtq_quantidade.Text.Trim()),
                Etq_valorcusto = Convert.ToDecimal(txtEtq_valorcusto.Text.Trim()),
                Etq_validade = Convert.ToDateTime(txtEtq_validade.Text.Trim())
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
            DALConnectionREST restConnection = new DALConnectionREST(URL);
            BLLEstoque objBLLEstoque = new(restConnection);
            _estoque = new()
            {
                Pro_codigo = Convert.ToInt32(txtPro_codigo.Text.Trim()),
                Dep_codigo = Convert.ToInt32(txtDep_codigo.Text.Trim()),
                Etq_quantidade = Convert.ToDecimal(txtEtq_quantidade.Text.Trim()),
                Etq_valorcusto = Convert.ToDecimal(txtEtq_valorcusto.Text.Trim()),
                Etq_validade = Convert.ToDateTime(txtEtq_validade.Text.Trim())
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

        private void btnPSQProduto_Click(object sender, EventArgs e)
        {
            using (FrmPSQ<Produto_00> frmPSQ = new FrmPSQ<Produto_00>(_produto = new(), URL))
            {
                DialogResult dialogResult = frmPSQ.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    txtPro_codigo.Text = Convert.ToString(frmPSQ.ReturnProdutos.Pro_codigo);
                    txtNomeProduto.Text = frmPSQ.ReturnProdutos.Pro_nome;
                }
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

        private void txtDep_codigo_Leave(object sender, EventArgs e)
        {
            _deposito = new();
            GetDeposito(_deposito);
        }

        private void txtPro_codigo_Leave(object sender, EventArgs e)
        {
            _produto = new();
            GetProduto(_produto);
        }
    }
}
