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
        DALConnectionREST restConnection;

        public BLLDeposito(DALConnectionREST restConnectionParameter)
        {
            // Construtor
            restConnection = restConnectionParameter;
        }

        public Task<Deposito_00?> GetDeposito(string Nome)
        {
            Nome = Nome.Trim();
            if (Nome.Length == 0)
            {
                throw new Exception("O campo Nome do Deposito/Fazenda não pode ficar em branco !!");
            }

            DALDeposito objDALDeposito = new DALDeposito(restConnection);
            return objDALDeposito.GetDeposito(Nome);
        }
        public async Task<string> PostDeposito(Deposito_00 DepositoParameter)
        {
            if (DepositoParameter.Dep_name.Trim().Length == 0)
            {
                throw new Exception("Favor inserir o nome do Deposito / Fazenda usuario !!");
            }

            DALDeposito objDALDeposito = new DALDeposito(restConnection);
            var result = await objDALDeposito.PostDeposito(DepositoParameter);
            return Convert.ToString(result);
        }

        //~BLLUsers()
        //{
        //    // Destroyer
        //}

    }
}
