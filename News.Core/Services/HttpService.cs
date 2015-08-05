using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using ModernHttpClient;

namespace News.Core.Services
{
    public interface IHttpService
    {
        Task<T> ReadContentAsync<T>(HttpResponseMessage response);
        Task<HttpResponseMessage> GetAsync (string url);
    }

    public class HttpService : IHttpService
    {
        public async Task<T> ReadContentAsync<T>(HttpResponseMessage response) {
            var message = await response.Content.ReadAsStringAsync ();
            var content = JsonConvert.DeserializeObject<T> (message);
            return content;
        }

        public async Task<HttpResponseMessage> GetAsync (string url)
        {
            using (var client = new HttpClient (new NativeMessageHandler ())) 
            {
                var address = string.Format ("{0}{1}", WebService.BaseUrl, url);
                var response = await client.GetAsync (address);
                return response;
            }
        }
    }
}

