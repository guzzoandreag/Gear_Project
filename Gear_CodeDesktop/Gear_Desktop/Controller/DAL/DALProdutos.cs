﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gear_Desktop.Models;
using Newtonsoft.Json;

namespace Gear_Desktop.Controller.DAL
{
    internal class DALProdutos
    {
        private readonly DALConnectionREST restConnection;

        public DALProdutos(DALConnectionREST restConnectionParameter)
        {
            //Construtor
            restConnection = restConnectionParameter;
            if (!restConnection.Url.Contains("Produto_00"))
            {
                restConnection.Url += "Produto_00";
            }
        }

        public async Task<List<Produto_00>> GetAllProdutos()
        {
            HttpClientHandler clientHandler = new();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors)
            => { return true; };

            HttpClient client = new(clientHandler);
            var URL = restConnection.Url;

            try
            {
                List<Produto_00> listProdutos = new();
                HttpResponseMessage response = await client.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var ProdutosJsonString = await response.Content.ReadAsStringAsync();
                    listProdutos = JsonConvert.DeserializeObject<Produto_00[]>(ProdutosJsonString).ToList();

                }
                return listProdutos;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao comunicar-se com o servidor. \n\n" +
                                    "Class : DALProdutos \n" +
                                    "Function : GetAllProdutos \n\n" +
                                    ex.Message);
            }
        }

        public async Task<Produto_00?> GetProduto(int Procodigo)
        {
            HttpClientHandler clientHandler = new();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new(clientHandler);
            var URL = restConnection.Url + "/" + Procodigo;

            try
            {
                HttpResponseMessage response = await client.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    Produto_00 produto = new();
                    produto = JsonConvert.DeserializeObject<Produto_00>(ProdutoJsonString);
                    return produto;
                }
                else
                {
                    return null;
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Falha ao comunicar-se com o servidor. \n\n" +
                    "Class : DALProduto \n" +
                    "Function : GetProduto \n\n" +
                    ex.Message);
            }
        }

        public async Task<string> PostProduto(Produto_00 ProdutoParameter)
        {
            HttpClientHandler clientHandler = new();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new(clientHandler);
            var URL = restConnection.Url;
            var serializedCadastroProduto = JsonConvert.SerializeObject(ProdutoParameter);
            var content = new StringContent(serializedCadastroProduto, Encoding.UTF8, "application/json");
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

        ~DALProdutos()
        {
            //Destroyer
        }

    }
}