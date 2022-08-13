using Gear_Desktop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gear_Desktop.Controller.DAL
{
    internal class DALDespesa
    {
        private readonly DALConnectionREST restConnection;

        public DALDespesa(DALConnectionREST restConnectionParameter)
        {
            //Construtor
            restConnection = restConnectionParameter;
            if (!restConnection.Url.Contains("Despesa_00"))
            {
                restConnection.Url += "Despesa_00";
            }
        }

        public async Task<List<Despesa_00>> GetAllDespesa()
        {
            HttpClientHandler clientHandler = new();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors)
            => { return true; };

            HttpClient client = new(clientHandler);
            var URL = restConnection.Url;

            try
            {
                List<Despesa_00> listDespesa = new();
                HttpResponseMessage response = await client.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var DespesaJsonString = await response.Content.ReadAsStringAsync();
                    listDespesa = JsonConvert.DeserializeObject<Despesa_00[]>(DespesaJsonString).ToList();
                }
                return listDespesa;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao comunicar-se com o servidor. \n\n" +
                                    "Class : DALDespesa \n" +
                                    "Function : GetAllDespesa \n\n" +
                                    ex.Message);
            }
        }

        public async Task<Despesa_00?> GetDespesa(int desCodigo)
        {
            HttpClientHandler clientHandler = new();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new(clientHandler);
            var URL = restConnection.Url + "/" + desCodigo;

            try
            {
                HttpResponseMessage response = await client.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var DespesaJsonString = await response.Content.ReadAsStringAsync();
                    Despesa_00 despesa = new();
                    despesa = JsonConvert.DeserializeObject<Despesa_00>(DespesaJsonString);
                    return despesa;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao comunicar-se com o servidor. \n\n" +
                                    "Class : DALDespesa \n" +
                                    "Function : GetDespesa \n\n" +
                                    ex.Message);
            }
        }

        public async Task<string> PutDespesa(Despesa_00 DespesaParameter)
        {
            HttpClientHandler clientHandler = new();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new(clientHandler);
            var URL = restConnection.Url + "/" + DespesaParameter.Des_codigo;
            var serializedCadastroDespesa = JsonConvert.SerializeObject(DespesaParameter);
            var content = new StringContent(serializedCadastroDespesa, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(URL, content);
            if (response.IsSuccessStatusCode)
            {
                return "Ok";
            }
            else
            {
                return "Erro : " + response.StatusCode;
            }
        }

        public async Task<Despesa_00> PostDespesa(Despesa_00 DespesaParameter)
        {
            HttpClientHandler clientHandler = new();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new(clientHandler);
            var URL = restConnection.Url;
            var serializedCadastroDespesa = JsonConvert.SerializeObject(DespesaParameter);
            var content = new StringContent(serializedCadastroDespesa, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(URL, content);
            if (response.IsSuccessStatusCode)
            {
                var despesaString = await response.Content.ReadAsStringAsync();
                Despesa_00 despesa = JsonConvert.DeserializeObject<Despesa_00>(despesaString);
                return despesa;
            }
            else
            {
                return null;
            }
        }

        ~DALDespesa()
        {
            //Destroyer
        }
    }
}
