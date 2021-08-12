using Domain.Dto;
using Domain.Interface;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class HttpRequest : IHttpRequest
    {
        private readonly HttpClient _httpClient;
        private string _baseUrl;
        public HttpRequest(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _baseUrl = configuration["pokemon"];

        }

        public async Task<string> GetRequest(string url)
        {
            string endpointPath = _baseUrl + url;

            HttpResponseMessage response = await _httpClient.GetAsync(endpointPath);
            if (!response.IsSuccessStatusCode)
            {
                var error = JsonConvert.DeserializeObject<ErrorResult>(response.Content.ReadAsStringAsync().Result);
                throw new Exception(error.Message);
            }
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> PostRequest(string url, object data)
        {
            string endpointPath = _baseUrl + url;
            HttpContent content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(endpointPath, content);
            if (!response.IsSuccessStatusCode)
            {
                var error = JsonConvert.DeserializeObject<ErrorResult>(response.Content.ReadAsStringAsync().Result);
                throw new Exception(error.Message);
            }

            return await response.Content.ReadAsStringAsync();
        }
    }
}
