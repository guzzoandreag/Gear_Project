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
    public partial class FrmCadProdutos : FrmBase
    {
        private readonly string URL;
        Produto_00 _produto;

        public FrmCadProdutos(string URLParameter)
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
            BLLProdutos objBLLProdutos = new(restConnection);
            _produto = new()
            {
                Pro_nome = txtNome.Text.Trim(),
                Pro_Grupo = cbGrupo.SelectedIndex + 1,
                Pro_Medida = cbMedida.SelectedIndex + 1

            };
            var result = await objBLLProdutos.PostProdutos(_produto);

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

        private void button1_Click(object sender, EventArgs e)
        {
            using (FrmPSQ<Produto_00> frmPSQ = new FrmPSQ<Produto_00>(_produto = new(), URL))
            {
                DialogResult dialogResult = frmPSQ.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    txtCodigo.Text = Convert.ToString(frmPSQ.ReturnProdutos.Pro_codigo);
                    txtNome.Text = frmPSQ.ReturnProdutos.Pro_nome;
                    //txtCusto.Text = frmPSQ.ReturnProdutos.Pro_valorcusto;
                    //cbGrupo.SelectedIndex = (int)frmPSQ.ReturnProdutos.Pro_Grupo;
                    //cbMedida.SelectedIndex = (int)frmPSQ.ReturnProdutos.Pro_Medida;

                }

            }
        }
    }
}
