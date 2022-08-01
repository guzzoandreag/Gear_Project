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
    public partial class FrmPSQ<T> : FrmBase
    {
        private readonly string URL;
        T _objectModel;

        private BLLDeposito objBLLDeposito;
        private BLLUsers objBLLUsers;
        private BLLProdutos objBLLProdutos;
        private BLLEstoque objBLLEstoque;


        private Deposito_00 returnDeposito;
        public Deposito_00 ReturnDeposito { get => returnDeposito; set => returnDeposito = value; }

        private Produto_00 returnProdutos;
        public Produto_00 ReturnProdutos { get => returnProdutos; set => returnProdutos = value; }

        private Estoque_00 returnEstoque;
        public Estoque_00 ReturnEstoque { get => returnEstoque; set => returnEstoque = value; }

        private Despesa_00 returnEstoque;
        public Estoque_00 ReturnEstoque { get => returnEstoque; set => returnEstoque = value; }


        private async void CreateGetAllModelObject()
        {
            var tipoModel = Convert.ToString(_objectModel.GetType());

            if (tipoModel.Contains("Deposito_00"))
            {
                MessageInfo(tipoModel);
                DALConnectionREST restConnection = new(URL);
                objBLLDeposito = new(restConnection);
                var listDeposito = await objBLLDeposito.GetAllDeposito();
                if ((listDeposito != null) && (listDeposito.Count > 0))
                {
                    dgvGridPesquisa.DataSource = listDeposito;
                    CustomizeGridViewAndNameHeadersFromModels(dgvGridPesquisa);
                }
            }
            else if (tipoModel.Contains("Users"))
            {
                MessageInfo(tipoModel);
                DALConnectionREST restConnection = new(URL);
                objBLLUsers = new(restConnection);
                var listUsers = await objBLLUsers.GetAllUsers();
                if ((listUsers != null) && (listUsers.Count > 0))
                {
                    dgvGridPesquisa.DataSource = listUsers;
                    CustomizeGridViewAndNameHeadersFromModels(dgvGridPesquisa);
                }
            }
            else if (tipoModel.Contains("Produto_00"))
            {
                MessageInfo(tipoModel);
                DALConnectionREST restConnection = new(URL);
                objBLLProdutos = new(restConnection);
                var listProdutos = await objBLLProdutos.GetAllProdutos();
                if ((listProdutos != null) && (listProdutos.Count > 0))
                {
                    dgvGridPesquisa.DataSource = listProdutos;
                    CustomizeGridViewAndNameHeadersFromModels(dgvGridPesquisa);
                }
            }
            else if (tipoModel.Contains("Estoque_00"))
            {
                MessageInfo(tipoModel);
                DALConnectionREST restConnection = new(URL);
                objBLLEstoque = new(restConnection);
                var listEstoque = await objBLLEstoque.GetAllEstoque();
                if ((listEstoque != null) && (listEstoque.Count > 0))
                {
                    dgvGridPesquisa.DataSource = listEstoque;
                    CustomizeGridViewAndNameHeadersFromModels(dgvGridPesquisa);
                }
            }
        }

        public FrmPSQ(T models, string URLParameter = "")
        {
            this.URL = URLParameter;
            this._objectModel = models;
            CreateGetAllModelObject();
            InitializeComponent();
            lblMsg.Visible = false;
        }

        private void CustomizeGridViewAndNameHeadersFromModels(DataGridView dataGridView)
        {
            // Customizando o GridView
            dgvGridPesquisa.Focus();
            dgvGridPesquisa.BorderStyle = BorderStyle.None;
            dgvGridPesquisa.MultiSelect = false;
            dgvGridPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGridPesquisa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGridPesquisa.AllowUserToAddRows = false;
            dgvGridPesquisa.AllowUserToDeleteRows = false;
            dgvGridPesquisa.RowHeadersVisible = false;
            // Headers (Cabecalhos)
            dgvGridPesquisa.EnableHeadersVisualStyles = false;
            dgvGridPesquisa.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(45, 45, 48)
                ,
                ForeColor = Color.White
                ,
                SelectionBackColor = Color.FromArgb(68, 35, 89)
                ,
                SelectionForeColor = Color.White
                ,
                WrapMode = DataGridViewTriState.True
                ,
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };
            dgvGridPesquisa.ColumnHeadersDefaultCellStyle.Font = new Font(
                "Consolas" //familyName
                , 10F //size
                      //,FontStyle.Bold //fontStyle
            );
            // Rows (Linhas)
            dgvGridPesquisa.RowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(45, 45, 48)
                ,
                ForeColor = Color.White
                ,
                SelectionBackColor = Color.FromArgb(68, 35, 89)
                ,
                SelectionForeColor = Color.White
            };

            // Customizando de acordo com o Objeto
            var tipoModel = Convert.ToString(_objectModel.GetType());
            if (tipoModel.Contains("Deposito_00"))
            {
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    if (column.Name == "Dep_codigo")
                    {
                        column.HeaderText = "Código";
                    }
                    else if (column.Name == "Dep_nome")
                    {
                        column.HeaderText = "Nome";
                    }
                    else if (column.Name == "Dep_tipocadastro")
                    {
                        column.HeaderText = "Tipo";
                    }
                    else if (column.Name == "Dep_tipoplantio")
                    {
                        column.HeaderText = "Plantio";
                    }
                    else if (column.Name == "Dep_tamanhofazenda")
                    {
                        column.HeaderText = "Tamanho";
                    }
                };
            }
            else if (tipoModel.Contains("Users"))
            {
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    if (column.Name == "Use_codigo")
                    {
                        column.HeaderText = "Código";
                    }
                    else if (column.Name == "Use_nome")
                    {
                        column.HeaderText = "Nome";
                    }
                    else if (column.Name == "Use_email")
                    {
                        column.HeaderText = "Email";
                    }
                    else if (column.Name == "Usu_senha")
                    {
                        column.HeaderText = "Senha";
                    }
                };
            }
            else if (tipoModel.Contains("Produto_00"))
            {
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    if(column.Name == "Pro_codigo")
                    {
                        column.HeaderText = "Código";
                    }
                    if (column.Name == "Pro_nome")
                    {
                        column.HeaderText = "Nome";
                    }
                    if (column.Name == "Pro_valorcusto")
                    {
                        column.HeaderText = "Valor de Custo";
                    }
                    if (column.Name == "Pro_Medida")
                    {
                        column.HeaderText = "Sigla de Medida";
                    }
                    if (column.Name == "Pro_Grupo")
                    {
                        column.HeaderText = "Grupo";
                    }
                };
            }
            else if (tipoModel.Contains("Estoque_00"))
            {
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    if (column.Name == "Etq_codigo")
                    {
                        column.HeaderText = "Código";
                    }
                    if (column.Name == "Pro_codigo")
                    {
                        column.HeaderText = "Cod. Produto";
                    }
                    if (column.Name == "Dep_codigo")
                    {
                        column.HeaderText = "Cod. Deposito";
                    }
                    if (column.Name == "Etq_quantidade")
                    {
                        column.HeaderText = "Quantidade Prod.";
                    }
                    if (column.Name == "Etq_valorcusto")
                    {
                        column.HeaderText = "Valor Custo Produto";
                    }
                    if (column.Name == "Etq_validade")
                    {
                        column.HeaderText = "Data Validade Produto";
                    }
                };
            }
        }

        private void dgvGridPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var tipoModel = Convert.ToString(_objectModel.GetType());
            if (tipoModel.Contains("Deposito_00"))
            {
                Deposito_00 depositoReturn = new();
                this.ReturnDeposito = depositoReturn;
                this.ReturnDeposito.Dep_codigo = Convert.ToInt32(dgvGridPesquisa.CurrentRow.Cells["Dep_codigo"].Value);
                this.ReturnDeposito.Dep_nome = dgvGridPesquisa.CurrentRow.Cells["Dep_nome"].Value.ToString();
                this.ReturnDeposito.Dep_tipocadastro = Convert.ToInt32(dgvGridPesquisa.CurrentRow.Cells["Dep_tipocadastro"].Value) - 1;
                this.ReturnDeposito.Dep_tipoplantio = Convert.ToInt32(dgvGridPesquisa.CurrentRow.Cells["Dep_tipoplantio"].Value) - 1;
                this.ReturnDeposito.Dep_tamanhofazenda = dgvGridPesquisa.CurrentRow.Cells["Dep_tamanhofazenda"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (tipoModel.Contains("Produto_00"))
            {
                Produto_00 produtoReturn = new();
                this.ReturnProdutos = produtoReturn;
                this.ReturnProdutos.Pro_codigo = Convert.ToInt32(dgvGridPesquisa.CurrentRow.Cells["Pro_codigo"].Value);
                this.ReturnProdutos.Pro_nome = dgvGridPesquisa.CurrentRow.Cells["Pro_nome"].Value.ToString();
                this.ReturnProdutos.Pro_Medida = Convert.ToInt32(dgvGridPesquisa.CurrentRow.Cells["Pro_Medida"].Value) - 1;
                this.ReturnProdutos.Pro_Grupo = Convert.ToInt32(dgvGridPesquisa.CurrentRow.Cells["Pro_Grupo"].Value) - 1;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (tipoModel.Contains("Estoque_00"))
            {
                Estoque_00 estoqueReturn = new();
                this.ReturnEstoque = estoqueReturn;
                this.ReturnEstoque.Etq_codigo = Convert.ToInt32(dgvGridPesquisa.CurrentRow.Cells["Etq_codigo"].Value);
                this.ReturnEstoque.Pro_codigo = Convert.ToInt32(dgvGridPesquisa.CurrentRow.Cells["Pro_codigo"].Value);
                this.ReturnEstoque.Dep_codigo = Convert.ToInt32(dgvGridPesquisa.CurrentRow.Cells["Dep_codigo"].Value);
                this.ReturnEstoque.Etq_quantidade = Convert.ToDecimal(dgvGridPesquisa.CurrentRow.Cells["Etq_quantidade"].Value);
                this.ReturnEstoque.Etq_valorcusto = Convert.ToDecimal(dgvGridPesquisa.CurrentRow.Cells["Etq_valorcusto"].Value);
                this.ReturnEstoque.Etq_validade = Convert.ToDateTime(dgvGridPesquisa.CurrentRow.Cells["Etq_validade"].Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
