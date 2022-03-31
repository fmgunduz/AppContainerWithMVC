using ContainerAppMvc.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ContainerAppMvc.DataAccess
{
    public class QuotesDal : IQuotesDal
    {

        public async Task<IEnumerable<QuoteModel>> GetAllQuotesAsync()
        {
            var url = "https://type.fit/api/quotes";
            using (HttpClient httpClient = new ())
            {
                var response = await httpClient.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<QuoteModel>>(result);
            }
        }
    }
}
