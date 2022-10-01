using Gear_Desktop.Models;
using Gear_Desktop.Controller.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gear_Desktop.Controller.BLL
{
    public class BLLDespesa
    {
        private readonly DALConnectionREST restConnection;

        public BLLDespesa(DALConnectionREST restConnectionParameter)
        {
            //Construtor
            restConnection = restConnectionParameter;
        }

        public async Task<List<Despesa_00>> GetAllDespesa()
        {
            List<Despesa_00> listDespesa = new();
            DALDespesa objDALDespesa = new(restConnection);
            listDespesa = await objDALDespesa.GetAllDespesa();
            return listDespesa;
        }

        public async Task<Despesa_00?> GetDespesa(int desCodigo)
        {
            //Nome = Nome.Trim();
            //if (Nome.Length == 0)
            //{
            //    // resultar a exceção com a mensagem para o formulario
            //    throw new Exception("O campo Nome do Deposito/Fazenda não pode ficar em branco !!");
            //}

            DALDespesa objDALDespesa = new(restConnection);
            return await objDALDespesa.GetDespesa(desCodigo);
        }

        public async Task<string> PutDespesa(Despesa_00 DespesaParameter)
        {
            if (Convert.ToString(DespesaParameter.Des_codigo).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Codigo da Despesa vazio !!");
            }
            if (Convert.ToString(DespesaParameter.Des_datalancamento).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir a Data de Lançamento!!");
            }
            if (Convert.ToString(DespesaParameter.Dep_codigo).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o Local da Despesa !!");
            }
            if (Convert.ToString(DespesaParameter.Des_valor).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o Valor da Despesa !!");
            }
            if (DespesaParameter.Des_observacao.Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir a Observação da Despesa !!");
            }

            DALDespesa objDALDespesa = new(restConnection);
            return await objDALDespesa.PutDespesa(DespesaParameter);
        }

        public async Task<Despesa_00> PostDespesa(Despesa_00 DespesaParameter)
        {
            if (Convert.ToString(DespesaParameter.Des_datalancamento).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir a Data de Lançamento!!");
            }
            if (Convert.ToString(DespesaParameter.Dep_codigo).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o Local da Despesa !!");
            }
            if (Convert.ToString(DespesaParameter.Des_valor).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o Valor da Despesa !!");
            }
            if (DespesaParameter.Des_observacao.Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir a Observação da Despesa !!");
            }

            DALDespesa objDALDespesa = new(restConnection);
            return await objDALDespesa.PostDespesa(DespesaParameter);
        }

        public async Task<string> DeleteDespesa(int desCodigo)
        {
            if (Convert.ToString(desCodigo).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o Codigo da Despesa!!");
            }
            DALDespesa objDALDespesa = new(restConnection);
            return await objDALDespesa.DeleteDespesa(desCodigo);
        }

        ~BLLDespesa()
        {
            // Destroyer
        }
    }
}