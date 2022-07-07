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
        }

        private void txtPro_codigo_Leave(object sender, EventArgs e)
        {
            _produto = new();
            GetProduto(_produto);
        }

        private async void GetProduto(Produto_00 produto)
        {
            DALConnectionREST restConnection = new DALConnectionREST(URL);
            BLLProdutos objBLLProdutos = new(restConnection);
            produto = await objBLLProdutos.GetProduto(Convert.ToInt32(txtPro_codigo.Text));
            txtNomeProduto.Text = produto.Pro_nome;
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

        private void txtDep_codigo_Leave(object sender, EventArgs e)
        {
            txtNomeDeposito.Text = GetDeposito(Convert.ToInt32(txtDep_codigo.Text)).Result.Dep_nome;
        }

        private async Task<Deposito_00> GetDeposito(int deposito_id)
        {
            DALConnectionREST restConnection = new DALConnectionREST(URL);
            BLLDeposito objBLLDeposito = new(restConnection);
            return await objBLLDeposito.GetDeposito(deposito_id);
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtPro_codigo.Enabled = true;
            btnPSQProduto.Enabled = true;
            txtDep_codigo.Enabled = true;
            btnPSQDeposito.Enabled = true;
            txtEtq_quantidade.Enabled = true;
            txtEtq_valorcusto.Enabled = true;
            txtEtq_validade.Enabled = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
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
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length != 0)
            {
                txtPro_codigo.Enabled = true;
                btnPSQProduto.Enabled = true;
                txtDep_codigo.Enabled = true;
                btnPSQDeposito.Enabled = true;
                txtEtq_quantidade.Enabled = true;
                txtEtq_valorcusto.Enabled = true;
                txtEtq_validade.Enabled = true;
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

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPro_codigo.Enabled = false;
            txtPro_codigo.Clear();
            btnPSQProduto.Enabled = false;
            txtDep_codigo.Enabled = false;
            txtDep_codigo.Clear();
            btnPSQDeposito.Enabled = false;
            txtEtq_quantidade.Enabled = false;
            txtEtq_quantidade.Clear();
            txtEtq_valorcusto.Enabled = false;
            txtEtq_valorcusto.Clear();
            txtEtq_validade.Enabled = false;
            txtEtq_validade.Clear();
            btnNovo.Enabled = true;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
        }
    }
}
