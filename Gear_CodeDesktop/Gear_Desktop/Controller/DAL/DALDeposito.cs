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
        private readonly DALConnectionREST restConnection;

        public DALDeposito(DALConnectionREST restConnectionParameter)
        {
            //Construtor
            restConnection = restConnectionParameter;
            if (!restConnection.Url.Contains("Deposito_00"))
            {
                restConnection.Url += "Deposito_00";
            }
        }

        public async Task<List<Deposito_00>> GetAllDeposito()
        {
            HttpClientHandler clientHandler = new();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) 
            => { return true; };

            HttpClient client = new(clientHandler);
            var URL = restConnection.Url;

            try
            {
                List<Deposito_00> listDeposito = new();
                HttpResponseMessage response = await client.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var DepositoJsonString = await response.Content.ReadAsStringAsync();                    
                    listDeposito = JsonConvert.DeserializeObject<Deposito_00[]>(DepositoJsonString).ToList();

                }
                return listDeposito;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao comunicar-se com o servidor. \n\n" +
                                    "Class : DALDeposito \n" +
                                    "Function : GetAllDeposito \n\n" +
                                    ex.Message);
            }
        }

        public async Task<Deposito_00?> GetDeposito(int depCodigo)
        {
            HttpClientHandler clientHandler = new();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new(clientHandler);
            var URL = restConnection.Url + "/" +  depCodigo;

            try
            {
                HttpResponseMessage response = await client.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var DepositoJsonString = await response.Content.ReadAsStringAsync();
                    Deposito_00 deposito = new();
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

        public async Task<string> PostDeposito(Deposito_00 depositoParameter)
        {
            HttpClientHandler clientHandler = new();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new(clientHandler);
            var URL = restConnection.Url;
            var serializedCadastro = JsonConvert.SerializeObject(depositoParameter);
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

        ~DALDeposito()
        {
            //Destroyer
        }
    }
}
