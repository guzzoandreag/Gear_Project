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
    public partial class FrmProdutos : FrmBase
    {
        private readonly string URL;

        public FrmProdutos(string URLParameter)
        {
            URL = URLParameter;
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ClearMessageInfo();
            PostProdutos();
        }

        private async void PostProdutos()
        {
            DALConnectionREST restConnection = new DALConnectionREST(URL);
            BLLProdutos objBLLProdutos = new BLLProdutos(restConnection);
            Produto_00 produto = new Produto_00();
            produto.Pro_nome = txtNome.Text.Trim();
           // produto.Pro_valorcusto = txtCusto.Text.Trim();
            produto.Pro_Medida = cbMedida.SelectedIndex + 1;
            produto.Pro_Grupo = cbGrupo.SelectedIndex + 1;
            var result = await objBLLProdutos.PostProdutos(produto);

            if (result == "Ok")
            {
               // ClearFields();
                MessageInfo("Produto cadastrado com sucesso !!", "Green");
            }
            else
            {
                MessageInfo("Erro ao cadastar Produto !!");
            }
        }

    }
}
