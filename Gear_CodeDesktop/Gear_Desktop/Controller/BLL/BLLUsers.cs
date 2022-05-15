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

        ~BLLUsers()
        {
            // Destroyer
        }
    }
}
