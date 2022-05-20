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
        private readonly DALConnectionREST restConnection;

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
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("O campo Email não pode ficar em branco !!");
            }

            DALUsers objDALUsers = new(restConnection);
            return objDALUsers.GetUsersByEmail(email);
        }

        public async Task<string> PostUser(Users usersParameter)
        {            
            if (usersParameter.Use_nome.Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o nome do usuario !!");
            }
            if (usersParameter.Use_email.Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o email do usuario !!");
            }
            if (usersParameter.Usu_senha.Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir a senha do usuario !!");
            }
            if (usersParameter.Usu_senha.Trim().Length < 6)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Senha não pode ser menor do q 6 (seis) caracteres !!");
            }

            DALUsers objDALUsers = new(restConnection);
            var result = await objDALUsers.PostUsers(usersParameter);
            return Convert.ToString(result);
        }

        ~BLLUsers()
        {
            // Destroyer
        }
    }
}
