using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary
{
    public class APIHelper
    {
        public HttpClient _apiClient { get; }
        public APIHelper()
        {
            //Setup a http client
            _apiClient = new HttpClient();
            //Set the base address (the address at which we're communicating with)
            _apiClient.BaseAddress = new Uri("https://localhost:44350/");
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
