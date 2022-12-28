using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.Endpoints
{
    public class ExpressionSolverEndpoint
    {
        private HttpClient _client = new HttpClient();

        public async Task<string> SolveExpressionAsync(string expression)
        {
            string hexExpression = HelperMethods.ASCIITOHEX(expression);
            var values = new Dictionary<string, string>
            {
                { "Input", hexExpression  }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await _client.PostAsync("http://localhost:8080/api/getExpressionResult/", content);

            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }
    }
}
