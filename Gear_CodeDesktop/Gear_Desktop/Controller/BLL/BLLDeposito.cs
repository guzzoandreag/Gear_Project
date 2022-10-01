using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gear_Desktop.Models;
using Gear_Desktop.Controller.DAL;

namespace Gear_Desktop.Controller.BLL
{
    public class BLLDeposito
    {
        private readonly DALConnectionREST restConnection;

        public BLLDeposito(DALConnectionREST restConnectionParameter)
        {
            // Construtor
            restConnection = restConnectionParameter;
        }

        public async Task<List<Deposito_00>> GetAllDeposito()
        {
            DALDeposito objDALDeposito = new(restConnection);
            List<Deposito_00> listDeposito = await objDALDeposito.GetAllDeposito();
            return listDeposito;
        }

        public async Task<Deposito_00?> GetDeposito(int depCodigo)
        {
            //Nome = Nome.Trim();
            //if (Nome.Length == 0)
            //{
            //    // resultar a exceção com a mensagem para o formulario
            //    throw new Exception("O campo Nome do Deposito/Fazenda não pode ficar em branco !!");
            //}

            DALDeposito objDALDeposito = new(restConnection);
            return await objDALDeposito.GetDeposito(depCodigo);
        }

        public async Task<string> PutDeposito(Deposito_00 DepositoParameter)
        {
            if (DepositoParameter.Dep_nome.Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o nome do Deposito !!");
            }
            if (Convert.ToString(DepositoParameter.Dep_tipocadastro).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o Tipo do Cadastro!!");
            }
            if (Convert.ToString(DepositoParameter.Dep_tipoplantio).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o Tipo de Plantio !!");
            }
            if (Convert.ToString(DepositoParameter.Dep_tamanhofazenda).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o Tipo de Plantio !!");
            }

            DALDeposito objDALDeposito = new(restConnection);
            return await objDALDeposito.PutDeposito(DepositoParameter);
        }

        public async Task<Deposito_00> PostDeposito(Deposito_00 depositoParameter)
        {
            if (depositoParameter.Dep_nome.Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o nome do Deposito / Fazenda usuario !!");
            }

            if (Convert.ToString(depositoParameter.Dep_tipocadastro).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o tipo !!");
            }

            if ((depositoParameter.Dep_tipocadastro == 2) && (Convert.ToString(depositoParameter.Dep_tipoplantio).Trim().Length == 0))
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o Tipo de Plantio !!");
            }

            if ((depositoParameter.Dep_tipocadastro == 2) && (depositoParameter.Dep_tamanhofazenda.Trim().Length == 0))
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o Tamanho da Fazenda !!");
            }

            DALDeposito objDALDeposito = new(restConnection);
            return await objDALDeposito.PostDeposito(depositoParameter);
        }

        public async Task<string> DeleteDeposito(int depCodigo)
        {
            if (Convert.ToString(depCodigo).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o Codigo do Deposito!!");
            }
            DALDeposito objDALDeposito = new(restConnection);
            return await objDALDeposito.DeleteDeposito(depCodigo);
        }

        //~BLLDeposito()
        //{
        // Destroyer
        //}
    }
}
