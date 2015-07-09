using System;
using System.Threading.Tasks;
using System.Net.Http;
using ModernHttpClient;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace News.Core.Services
{
    public interface IHttpService
    {
        Task<T> ReadContentAsync<T>(HttpResponseMessage response);
        Task<HttpResponseMessage> GetAsync (string url, params KeyValuePair<string, object>[] parameters);
    }

    public class HttpService : IHttpService
    {
        public HttpService ()
        {
        }

        public async Task<T> ReadContentAsync<T>(HttpResponseMessage response) {
            var message = await response.Content.ReadAsStringAsync ();
            var content = JsonConvert.DeserializeObject<T> (message);
            return content;
        }

        public async Task<HttpResponseMessage> GetAsync (string url, params KeyValuePair<string, object>[] parameters)
        {
            using (var client = new HttpClient (new NativeMessageHandler ())) 
            {
                var address = string.Format ("{0}{1}", Api.BaseUrl, url);
                AddQueryString (ref address, parameters);
                var response = await client.GetAsync (address);
                return response;
            }
        }

        private void AddQueryString(ref string address, KeyValuePair<string, object>[] parameters)
        {
            if (parameters.Length == 0)
                return;         
            address += "?" + string.Join ("&", parameters.Select (p => string.Format("{0}={1}", p.Key, p.Value)));              
        }
    }
}

