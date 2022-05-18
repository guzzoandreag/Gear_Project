using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gear_Desktop.Models;
using Gear_Desktop.Controller.DAL;

namespace Gear_Desktop.Controller.BLL
{
    public class BLLUsers
    {
        DALConnectionREST restConnection;

        public BLLUsers(DALConnectionREST restConnectionParameter)
        {
            // Construtor
            restConnection = restConnectionParameter;
        }

        public Task<Users?> GetUsersByEmail(string email)
        {
            email = email.Trim();
            if (email.Length == 0)
            {
                throw new Exception("O campo Email não pode ficar em branco !!");
            }

            DALUsers objDALUsers = new DALUsers(restConnection);
            return objDALUsers.GetUsersByEmail(email);
        }

        public async Task<string> PostUser(Users usersParameter)
        {            
            if (usersParameter.Use_name.Trim().Length == 0)
            {
                throw new Exception("Favor inserir o nome do usuario !!");
            }
            if (usersParameter.Use_email.Trim().Length == 0)
            {
                throw new Exception("Favor inserir o email do usuario !!");
            }
            if (usersParameter.Usu_password.Trim().Length == 0)
            {
                throw new Exception("Favor inserir a senha do usuario !!");
            }
            if (usersParameter.Usu_password.Trim().Length < 6)
            {
                throw new Exception("Senha não pode ser menor do q 6 (seis) caracteres !!");
            }

            DALUsers objDALUsers = new DALUsers(restConnection);
            var result = await objDALUsers.PostUsers(usersParameter);
            return Convert.ToString(result);
        }

        ~BLLUsers()
        {
            // Destroyer
        }
    }
}
