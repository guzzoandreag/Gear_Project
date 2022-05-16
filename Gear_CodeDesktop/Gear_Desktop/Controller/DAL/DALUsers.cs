using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gear_Desktop.Controller.DAL;
using Gear_Desktop.Models;
using Newtonsoft.Json;

namespace Gear_Desktop.Controller.DAL
{
    internal class DALUsers
    {
        DALConnectionREST restConnection;

        public DALUsers(DALConnectionREST restConnectionParameter)
        {
            // Construtor
            restConnection = restConnectionParameter;
            restConnection.Url = restConnection.Url + "Users";
        }

        public async Task<Users?> GetUsersByEmail(string email)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            var URL = restConnection.Url + "/" + email;
            try
            {
                HttpResponseMessage response = await client.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var UsersJsonString = await response.Content.ReadAsStringAsync();
                    Users users = new Users();
                    users = JsonConvert.DeserializeObject<Users>(UsersJsonString);
                    return users;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Falha ao comunicar-se com o servidor. \n\n" +
                                    "Class : DALUsers \n" +
                                    "Function : GetUsersByEmail \n\n" +
                                    e.Message);
            }
        }

        public async Task<string> PostUsers(Users usersParameter)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            var serializedCadastro = JsonConvert.SerializeObject(usersParameter);
            var content = new StringContent(serializedCadastro, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(restConnection.Url, content);
            if (result.IsSuccessStatusCode)
            {
                return "Ok";
            }
            else
            {
                return "Fail";
            }
        }

            ~DALUsers()
        {
            // Destroyer
        }
    }
}
