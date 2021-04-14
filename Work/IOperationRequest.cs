using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    public interface IOperationRequest
    {
        public HttpClient HttpClient { get; set; }
        public string Token { get; set; }
        public string SecretKey { get; set; }
        public Task<T> ProcessGetRequest<T>(string url);
    }
}
