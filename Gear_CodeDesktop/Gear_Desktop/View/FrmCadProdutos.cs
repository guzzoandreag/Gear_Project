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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gear_Desktop.View
{
    public partial class FrmCadProdutos : FrmBase
    {
        private readonly string URL;
        Produto_00 _produto;

        public FrmCadProdutos(string URLParameter)
        {
            InitializeComponent();
            this.URL = URLParameter;
           
            txtCodigo.ReadOnly = true;
            txtNome.ReadOnly = true;
            //cbMedida.FlatStyle = FlatStyle.Popup;
            //cbMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMedida.Enabled = false;
            cbGrupo.Enabled = false;

            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        private void ClearFields()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            cbMedida.SelectedIndex = -1;
            cbGrupo.SelectedIndex = -1;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearMessageInfo();
            txtCodigo.Clear();
            txtNome.ReadOnly = false;
            txtNome.Clear();
            cbMedida.Enabled = true;
            cbMedida.SelectedIndex = -1;
            cbGrupo.Enabled = true;
            cbGrupo.SelectedIndex = -1;

            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length != 0)
            {
                ClearMessageInfo();
                txtNome.ReadOnly = false;
                cbMedida.Enabled = true;
                cbGrupo.Enabled = true;

                btnNovo.Enabled = false;
                btnAlterar.Enabled = false;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = false;
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
                PutProdutos();
            }
            else
            {
                PostProdutos();
            }
            txtNome.ReadOnly = true;
            cbMedida.Enabled = false;
            cbGrupo.Enabled = false;

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
                txtNome.ReadOnly = true;
                txtNome.Clear();
                cbMedida.Enabled = false;
                cbMedida.SelectedIndex = -1;
                cbGrupo.Enabled = false;
                cbGrupo.SelectedIndex = -1;

                btnNovo.Enabled = true;
                btnAlterar.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = true;
                btnPesquisar.Enabled = true;
            }
            else
            {
                txtNome.ReadOnly = true;
                cbMedida.Enabled = false;
                cbGrupo.Enabled = false;

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
                txtNome.ReadOnly = true;               
                cbMedida.Enabled = false;
                cbGrupo.Enabled = false;                

                btnNovo.Enabled = true;
                btnAlterar.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = true;
                btnPesquisar.Enabled = true;

                DeleteProduto(Convert.ToInt32(txtCodigo.Text.Trim()));

                ClearFields();
            }
            else
            {
                MessageInfo("Não é permitido excluir um cadastro em branco! \n Favor selecionar um através da pesquisa!!");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ClearMessageInfo();
            using (FrmPSQ<Produto_00> frmPSQ = new FrmPSQ<Produto_00>(_produto = new(), URL))
            {
                DialogResult dialogResult = frmPSQ.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    txtCodigo.Text = Convert.ToString(frmPSQ.ReturnProdutos.Pro_codigo);
                    txtNome.Text = frmPSQ.ReturnProdutos.Pro_nome;
                    cbMedida.SelectedIndex = Convert.ToInt32(frmPSQ.ReturnProdutos.Pro_Medida);
                    cbGrupo.SelectedIndex = Convert.ToInt32(frmPSQ.ReturnProdutos.Pro_Grupo);
                }
            }
        }

        private async void PutProdutos()
        {
            DALConnectionREST restConnection = new DALConnectionREST(URL);
            BLLProdutos objBLLProdutos = new(restConnection);
            _produto = new()
            {
                Pro_codigo = Convert.ToInt32(txtCodigo.Text.Trim()),
                Pro_nome = txtNome.Text.Trim(),
                Pro_Grupo = cbGrupo.SelectedIndex + 1,
                Pro_Medida = cbMedida.SelectedIndex + 1
            };
            var result = await objBLLProdutos.PutProdutos(_produto);
            if (result == "Ok")
            {
                MessageInfo("Produto alterado com sucesso !! ", "Green");
            }
            else
            {
                MessageInfo("Erro ao alterar o Produto !! - " + result);
            }
        }

        private async void PostProdutos()
        {
            DALConnectionREST restConnection = new DALConnectionREST(URL);
            BLLProdutos objBLLProdutos = new(restConnection);
            _produto = new()
            {
                Pro_nome = txtNome.Text.Trim(),
                Pro_Grupo = cbGrupo.SelectedIndex + 1,
                Pro_Medida = cbMedida.SelectedIndex + 1
            };
            var result = await objBLLProdutos.PostProdutos(_produto);
            if (result.Pro_codigo.ToString().Length > 0)
            {
                MessageInfo("Produto cadastrado com sucesso !! " , "Green");
                txtCodigo.Text = result.Pro_codigo.ToString();
            }
            else
            {
                MessageInfo("Erro ao cadastar Produto !!");
            }
        }

        private async void DeleteProduto(int proCodigo)
        {
            DALConnectionREST restConnection = new(URL);
            BLLProdutos objBLLProdutos = new(restConnection);
            var result = await objBLLProdutos.DeleteProduto(proCodigo);
            if (result == "Ok")
            {
                MessageInfo("Produto excluido com sucesso !! ", "Green");
            }
            else
            {
                MessageInfo("Erro ao excluido o Produto !! - " + result);
            }
        }
    }
}
