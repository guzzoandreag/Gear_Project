using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gear_Desktop.Models;
using Newtonsoft.Json;

namespace Gear_Desktop.Controller.DAL
{
    internal class DALEstoque
    {
        private readonly DALConnectionREST restConnection;

        public DALEstoque(DALConnectionREST restConnectionParameter)
        {
            //Construtor
            restConnection = restConnectionParameter;
            if (!restConnection.Url.Contains("Estoque_00"))
            {
                restConnection.Url += "Estoque_00";
            }
        }

        public async Task<List<Estoque_00>> GetAllEstoque()
        {
            HttpClientHandler clientHandler = new();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new(clientHandler);
            var URL = restConnection.Url;

            try
            {
                List<Estoque_00> listEstoque = new();
                HttpResponseMessage response = await client.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var EstoqueJsonString = await response.Content.ReadAsStringAsync();
                    listEstoque = JsonConvert.DeserializeObject<Estoque_00[]>(EstoqueJsonString).ToList();

                }
                return listEstoque;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao comunicar-se com o servidor. \n\n" +
                                    "Class : DALEstoque \n" +
                                    "Function : GetAllEstoque \n\n" +
                                    ex.Message);
            }
        }

        public async Task<Estoque_00?> GetEstoque(int Etqcodigo)

        {
            HttpClientHandler clientHandler = new();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new(clientHandler);
            var URL = restConnection.Url + Etqcodigo;

            try
            {
                HttpResponseMessage response = await client.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var EstoqueJsonString = await response.Content.ReadAsStringAsync();
                    Estoque_00 estoque = new();
                    estoque = JsonConvert.DeserializeObject<Estoque_00>(EstoqueJsonString);
                    return estoque;
                }
                else
                {
                    return null;
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao comunicar-se com o servidor. \n\n" +
                                    "Class : DALEstoque \n" +
                                    "Function : GetEstoque \n\n" +
                                    ex.Message);
            }
        }

        public async Task<string> PostEstoque(Estoque_00 EstoqueParameter)
        {
            HttpClientHandler clientHandler = new();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new(clientHandler);
            var URL = restConnection.Url;
            var serializedCadastroEstoque = JsonConvert.SerializeObject(EstoqueParameter);
            var content = new StringContent(serializedCadastroEstoque, Encoding.UTF8, "application/json");
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

        ~DALEstoque()
        {
            //Destroyer
        }

    }
}
