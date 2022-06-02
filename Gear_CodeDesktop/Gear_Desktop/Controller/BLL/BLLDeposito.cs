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
            List<Deposito_00> listDeposito= new();
            DALDeposito objDALDeposito = new(restConnection);
            listDeposito = await objDALDeposito.GetAllDeposito();
            return listDeposito;
        }

        public Task<Deposito_00?> GetDeposito(int depCodigo)
        {
            //Nome = Nome.Trim();
            //if (Nome.Length == 0)
            //{
            //    // resultar a exceção com a mensagem para o formulario
            //    throw new Exception("O campo Nome do Deposito/Fazenda não pode ficar em branco !!");
            //}

            DALDeposito objDALDeposito = new(restConnection);
            return objDALDeposito.GetDeposito(depCodigo);
        }

        public async Task<string> PostDeposito(Deposito_00 depositoParameter)
        {
            var result = "";
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
            result = await objDALDeposito.PostDeposito(depositoParameter);
            return Convert.ToString(result);
        }

        ~BLLDeposito()
        {
            // Destroyer
        }

    }
}
