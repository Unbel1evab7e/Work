using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    public class BaseRequest : IOperationRequest
    {
        public HttpClient HttpClient { get; set; }
        public string Token { get; set; }
        public string SecretKey { get; set; }
        public BaseRequest(string token,string secretKey)
        {
            Token = token;
            SecretKey = secretKey;
            HttpClient = new HttpClient();
        }
        public async Task<T> ProcessGetRequest<T>(string url)
        {
            var streamTask = HttpClient.GetStringAsync(url);
            var response = JsonConvert.DeserializeObject<T>(await streamTask);
            return response;
        }
    }
}
