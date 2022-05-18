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
    internal class DALDeposito
    {
        DALConnectionREST restConnection;

        public DALDeposito(DALConnectionREST restConnectionParameter)
        {
            //Construtor
            restConnection = restConnectionParameter;
            if (!restConnection.Url.Contains("Deposito"))
            {
                restConnection.Url = restConnection.Url + "Deposito";
            }
        }

        public async Task<Deposito_00?> GetDeposito(string Nome)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            var URL = restConnection.Url + "/Deposito/" + Nome;

            try
            {
                HttpResponseMessage response = await client.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var DepositoJsonString = await response.Content.ReadAsStringAsync();
                    Deposito_00 deposito = new Deposito_00();
                    deposito = JsonConvert.DeserializeObject<Deposito_00>(DepositoJsonString);
                    return deposito;
                }
                else
                {
                    return null;
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao comunicar-se com o servidor. \n\n" +
                    "Class : DALDeposito \n" +
                    "Function : GetDeposito \n\n" +
                    ex.Message);
            }
        }
        public async Task<string> PostDeposito(Deposito_00 DepositoParameter)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            var URL = restConnection.Url;
            var serializedCadastro = JsonConvert.SerializeObject(DepositoParameter);
            var content = new StringContent(serializedCadastro, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(URL, content);
            if (result.IsSuccessStatusCode)
            {
                return "Ok";
            }
            else
            {
                return "Fail";
            }
        }

        //~DALUsers()
        //{
        //     //Destroyer
        //}
    }
}
